using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace com.cacode.restartService {
    public partial class CACodeServerInit : Form {
        private string[] filePaths;
        public CACodeServerInit() {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void _MouseEnter(object sender, EventArgs e) {
            Label lab = (Label)sender;
            lab.ForeColor = Color.Red;
        }

        private void _MouseLeave(object sender, EventArgs e) {
            Label lab = (Label)sender;
            lab.ForeColor = Color.DodgerBlue;
        }

        private void lab_close_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam);

        private const int VM_NCLBUTTONDOWN = 0XA1;//定义鼠标左键按下
        private const int HTCAPTION = 2;
        /// <summary>
        /// 鼠标按下
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _MouseDown(object sender, MouseEventArgs e) {
            //为当前应用程序释放鼠标捕获
            ReleaseCapture();
            //发送消息 让系统误以为在标题栏上按下鼠标
            SendMessage((IntPtr)this.Handle, VM_NCLBUTTONDOWN, HTCAPTION, 0);
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cancel_Click(object sender, EventArgs e) {
            foreach (Control item in this.Controls) {
                if (item is TextBox) {
                    item.Text = "";
                }
                if (item is Panel) {
                    foreach (Control it in item.Controls) {
                        if (it is TextBox) {
                            it.Text = "";
                        }
                    }
                }
            }
        }

        private void btn_send_Click(object sender, EventArgs e) {
            string ips = this.tb_ip.Text;
            string[] vs = ips.Split('\n');
            string port = this.tb_port.Text;
            string pwd = this.tb_pwd.Text;
            string script = this.tb_script.Text;
            string initPort = this.tb_initPort.Text;
            string user = this.tb_user.Text;
            bool @checked = this.cb_kill.Checked;
            this.lb_errorCount.Text = "0";
            this.lb_successCount.Text = "0";
            this.lb_runCount.Text = "0";
            this.lb_count.Text = "0";
            this.lb_count.Text = vs.Length + "";
            foreach (var item in vs) {
                new Thread(() => {
                    string ip = item.Replace("\r", "");
                    Renci.SshNet.ConnectionInfo connectionInfo = SshUtil.getSsh(ip, Convert.ToInt32(port), user, pwd);
                    if (@checked) {
                        try {
                            string com = "netstat -lnp|grep " + initPort;
                            log("execute -> " + com);
                            string findPort = SshUtil.executeCommand(connectionInfo, com);
                            log("resutl -> " + findPort);
                            int index = findPort.LastIndexOf("/");
                            findPort = findPort.Substring(index - 10, 10).Trim();
                            findPort = Regex.Replace(findPort, "[a-zA-Z]", "");
                            string end = findPort.Substring(findPort.Length - 1);
                            Convert.ToInt32(end);
                            string kill = "kill -9 " + findPort;
                            log("execute -> " + kill);
                            string re = SshUtil.executeCommand(connectionInfo, kill);
                            log(re);
                            findPort = findPort.Substring(0, findPort.Length - 1);
                        } catch (Exception err) {
                            this.tb_errorIp.Text += item + "\r\n";
                            this.tb_errorMessage.Text += err + "\r\n";
                        }
                    }
                    log("execute -> " + script);
                    string result = SshUtil.executeCommand(connectionInfo, script);
                    if (!result.Equals("")) {
                        this.lb_successCount.Text = Convert.ToInt32(this.lb_successCount.Text) + 1 + "";
                        string[] sp = result.Split('&');
                        try {
                            this.tb_errorIp.Text += sp[0].Split(':')[1] + "\r\n";
                            this.tb_errorMessage.Text += result + "\r\n";
                        } catch (Exception) {
                        }
                    } else {
                        this.lb_errorCount.Text = Convert.ToInt32(this.lb_errorCount.Text) + 1 + "";
                    }
                    result = result.Replace("\n", "\r\n");
                    log("resutl -> " + result);
                    log("执行完成!");
                    this.lb_runCount.Text = Convert.ToInt32(this.lb_runCount.Text) + 1 + "";
                }).Start();
            }
        }

        private void log(string te) {
            this.tb_command.Text += te + "\r\n";
        }

        private void lb_upload_Click(object sender, EventArgs e) {
            this.tm_showUpload.Start();
        }

        private void tm_showUpload_Tick(object sender, EventArgs e) {
            this.pn_msg.Location = new Point(0, 0);
            this.pn_msg.Size = new Size(403, 570);
            this.pn_msg.BackColor = Color.White;
            foreach (Control item in this.pn_msg.Controls) {
                item.ForeColor = Color.Green;
            }
            if (this.pn_upload.Location.X > 409) {
                this.pn_upload.Location = new Point(this.pn_upload.Location.X - 30, 0);
            } else {
                this.tm_showUpload.Stop();
            }
        }

        private void label18_Click(object sender, EventArgs e) {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e) {
            this.pn_msg.Location = new Point(432, 96);
            this.pn_msg.Size = new Size(352, 451);
            this.pn_msg.BackColor = Color.DarkSlateGray;
            foreach (Control item in this.pn_msg.Controls) {
                item.ForeColor = Color.White;
            }
            if (this.pn_upload.Location.X < 796) {
                this.pn_upload.Location = new Point(this.pn_upload.Location.X + 30, 0);
            } else {
                this.timer1.Stop();
            }
        }

        private void tb_upload_filePath_DragEnter(object sender, DragEventArgs e) {
            this.filePaths = (string[])e.Data.GetData(DataFormats.FileDrop);
            this.tb_upload_filePath.BorderStyle = BorderStyle.FixedSingle;
            this.lb_upload_filePath.Text = filePaths[0] + "...";
        }

        private void tb_upload_filePath_DragLeave(object sender, EventArgs e) {
            this.tb_upload_filePath.BorderStyle = BorderStyle.None;
        }

        private void btn_upload_Click(object sender, EventArgs e) {
            this.btn_upload.Enabled = false;
            string ip = this.tb_upload_ip.Text;
            string port = this.tb_upload_port.Text;
            string pwd = this.tb_upload_pwd.Text;
            string serverPath = this.tb_upload_serverPath.Text;
            string user = this.tb_upload_user.Text;
            string[] up_ip = ip.Split('\n');

            this.lb_errorCount.Text = "0";
            this.lb_successCount.Text = "0";
            this.lb_runCount.Text = "0";
            this.lb_count.Text = "0";

            this.lb_count.Text = up_ip.Length + "";
            new Thread(() => {
                foreach (string upload_ip in up_ip) {
                    string _ip = upload_ip.Replace("\r", "");

                    foreach (string filePath in filePaths) {
                        try {

                            Renci.SshNet.ConnectionInfo connectionInfo = SshUtil.getSsh(_ip, Convert.ToInt32(port), user, pwd);

                            string fileName = filePath.Substring(filePath.LastIndexOf("\\")).Substring(1);
                            log("upload -> " + filePath);
                            log("ip -> " + _ip);
                            SshUtil.Upload(connectionInfo, filePath, fileName, serverPath);
                            log(_ip + " upload is ok");
                            this.btn_upload.Enabled = true;
                            this.lb_successCount.Text = Convert.ToInt32(this.lb_successCount.Text) + 1 + "";
                        } catch (Exception err) {
                            this.lb_errorCount.Text = Convert.ToInt32(this.lb_errorCount.Text) + 1 + "";
                            this.tb_errorIp.Text += _ip + "\r\n";
                            this.tb_errorMessage.Text += err + "\r\n";
                            log("upload error ip ->" + _ip);
                            log("upload error file ->:" + filePath);

                        }
                        this.lb_runCount.Text = Convert.ToInt32(this.lb_runCount.Text) + 1 + "";
                    }

                }
            }).Start();
        }

        private void label25_Click(object sender, EventArgs e) {
            foreach (Control item in this.pn_msg.Controls) {
                if (item is TextBox) {
                    item.Text = "";
                }
            }
        }
    }
}
