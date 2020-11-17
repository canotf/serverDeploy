namespace com.cacode.restartService {
    partial class CACodeServerInit {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CACodeServerInit));
            this.lab_close = new System.Windows.Forms.Label();
            this.tb_ip = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_port = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_pwd = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_script = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_kill = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_send = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_initPort = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_command = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pn_upload = new System.Windows.Forms.Panel();
            this.lb_upload_filePath = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btn_upload = new System.Windows.Forms.Button();
            this.tb_upload_filePath = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tb_upload_serverPath = new System.Windows.Forms.TextBox();
            this.tb_upload_pwd = new System.Windows.Forms.TextBox();
            this.tb_upload_user = new System.Windows.Forms.TextBox();
            this.tb_upload_port = new System.Windows.Forms.TextBox();
            this.tb_upload_ip = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.lb_upload = new System.Windows.Forms.Label();
            this.tm_showUpload = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_errorCount = new System.Windows.Forms.Label();
            this.lb_successCount = new System.Windows.Forms.Label();
            this.lb_runCount = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lb_count = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tb_errorIp = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.tb_errorMessage = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pn_msg = new System.Windows.Forms.Panel();
            this.label25 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pn_upload.SuspendLayout();
            this.tb_upload_filePath.SuspendLayout();
            this.panel1.SuspendLayout();
            this.pn_msg.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_close
            // 
            this.lab_close.AutoSize = true;
            this.lab_close.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lab_close.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lab_close.Location = new System.Drawing.Point(-1, 2);
            this.lab_close.Name = "lab_close";
            this.lab_close.Size = new System.Drawing.Size(18, 20);
            this.lab_close.TabIndex = 0;
            this.lab_close.Text = "X";
            this.lab_close.Click += new System.EventHandler(this.lab_close_Click);
            this.lab_close.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.lab_close.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // tb_ip
            // 
            this.tb_ip.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_ip.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_ip.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_ip.ForeColor = System.Drawing.Color.Lime;
            this.tb_ip.Location = new System.Drawing.Point(73, 123);
            this.tb_ip.MaxLength = 0;
            this.tb_ip.Multiline = true;
            this.tb_ip.Name = "tb_ip";
            this.tb_ip.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.tb_ip.Size = new System.Drawing.Size(353, 92);
            this.tb_ip.TabIndex = 1;
            this.toolTip1.SetToolTip(this.tb_ip, "ip address");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(50, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "ip";
            // 
            // tb_port
            // 
            this.tb_port.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_port.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_port.ForeColor = System.Drawing.Color.Lime;
            this.tb_port.Location = new System.Drawing.Point(73, 236);
            this.tb_port.Name = "tb_port";
            this.tb_port.Size = new System.Drawing.Size(353, 25);
            this.tb_port.TabIndex = 2;
            this.tb_port.Text = "22";
            this.toolTip1.SetToolTip(this.tb_port, "default using 22");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(11, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "ssh port";
            // 
            // tb_user
            // 
            this.tb_user.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_user.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_user.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_user.ForeColor = System.Drawing.Color.Lime;
            this.tb_user.Location = new System.Drawing.Point(73, 278);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(353, 25);
            this.tb_user.TabIndex = 3;
            this.tb_user.Text = "root";
            this.toolTip1.SetToolTip(this.tb_user, "login user");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(35, 278);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "user";
            // 
            // tb_pwd
            // 
            this.tb_pwd.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_pwd.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_pwd.ForeColor = System.Drawing.Color.Lime;
            this.tb_pwd.Location = new System.Drawing.Point(73, 320);
            this.tb_pwd.Name = "tb_pwd";
            this.tb_pwd.Size = new System.Drawing.Size(353, 25);
            this.tb_pwd.TabIndex = 4;
            this.tb_pwd.Text = "Abc123456***";
            this.toolTip1.SetToolTip(this.tb_pwd, "login pasword");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(3, 320);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 2;
            this.label4.Text = "password";
            // 
            // tb_script
            // 
            this.tb_script.BackColor = System.Drawing.Color.Black;
            this.tb_script.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_script.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_script.ForeColor = System.Drawing.Color.Lime;
            this.tb_script.Location = new System.Drawing.Point(73, 401);
            this.tb_script.Multiline = true;
            this.tb_script.Name = "tb_script";
            this.tb_script.Size = new System.Drawing.Size(353, 140);
            this.tb_script.TabIndex = 5;
            this.tb_script.Text = "nohup java -jar vpn-0.0.2.jar &";
            this.toolTip1.SetToolTip(this.tb_script, "command");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(-1, 402);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 19);
            this.label6.TabIndex = 2;
            this.label6.Text = "command";
            // 
            // cb_kill
            // 
            this.cb_kill.AutoSize = true;
            this.cb_kill.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cb_kill.Location = new System.Drawing.Point(73, 550);
            this.cb_kill.Name = "cb_kill";
            this.cb_kill.Size = new System.Drawing.Size(70, 23);
            this.cb_kill.TabIndex = 6;
            this.cb_kill.Text = "yes/no";
            this.toolTip1.SetToolTip(this.cb_kill, "kill deploy port");
            this.cb_kill.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(32, 551);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 19);
            this.label7.TabIndex = 2;
            this.label7.Text = "kill";
            // 
            // btn_send
            // 
            this.btn_send.BackColor = System.Drawing.Color.Green;
            this.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_send.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btn_send.ForeColor = System.Drawing.Color.White;
            this.btn_send.Location = new System.Drawing.Point(273, 603);
            this.btn_send.Name = "btn_send";
            this.btn_send.Size = new System.Drawing.Size(80, 31);
            this.btn_send.TabIndex = 7;
            this.btn_send.Text = "run";
            this.btn_send.UseVisualStyleBackColor = false;
            this.btn_send.Click += new System.EventHandler(this.btn_send_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.Gray;
            this.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_cancel.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btn_cancel.ForeColor = System.Drawing.Color.White;
            this.btn_cancel.Location = new System.Drawing.Point(465, 603);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(80, 31);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "clear";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::com.cacode.restartService.Properties.Resources.iconMain;
            this.pictureBox1.Location = new System.Drawing.Point(256, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(91, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label5.Location = new System.Drawing.Point(342, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(225, 27);
            this.label5.TabIndex = 6;
            this.label5.Text = "CACode server deploy";
            // 
            // tb_initPort
            // 
            this.tb_initPort.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tb_initPort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tb_initPort.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_initPort.ForeColor = System.Drawing.Color.Lime;
            this.tb_initPort.Location = new System.Drawing.Point(73, 362);
            this.tb_initPort.Name = "tb_initPort";
            this.tb_initPort.Size = new System.Drawing.Size(353, 25);
            this.tb_initPort.TabIndex = 4;
            this.toolTip1.SetToolTip(this.tb_initPort, "deploy port");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(35, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "port";
            // 
            // tb_command
            // 
            this.tb_command.BackColor = System.Drawing.Color.Black;
            this.tb_command.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_command.Font = new System.Drawing.Font("Comic Sans MS", 9F);
            this.tb_command.ForeColor = System.Drawing.Color.White;
            this.tb_command.Location = new System.Drawing.Point(18, 23);
            this.tb_command.Multiline = true;
            this.tb_command.Name = "tb_command";
            this.tb_command.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_command.Size = new System.Drawing.Size(346, 178);
            this.tb_command.TabIndex = 9;
            this.toolTip1.SetToolTip(this.tb_command, "server run command for now");
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(139, 4);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = "command views";
            // 
            // pn_upload
            // 
            this.pn_upload.BackColor = System.Drawing.Color.White;
            this.pn_upload.Controls.Add(this.lb_upload_filePath);
            this.pn_upload.Controls.Add(this.label18);
            this.pn_upload.Controls.Add(this.btn_upload);
            this.pn_upload.Controls.Add(this.tb_upload_filePath);
            this.pn_upload.Controls.Add(this.label15);
            this.pn_upload.Controls.Add(this.label17);
            this.pn_upload.Controls.Add(this.label11);
            this.pn_upload.Controls.Add(this.label12);
            this.pn_upload.Controls.Add(this.label13);
            this.pn_upload.Controls.Add(this.label14);
            this.pn_upload.Controls.Add(this.tb_upload_serverPath);
            this.pn_upload.Controls.Add(this.tb_upload_pwd);
            this.pn_upload.Controls.Add(this.tb_upload_user);
            this.pn_upload.Controls.Add(this.tb_upload_port);
            this.pn_upload.Controls.Add(this.tb_upload_ip);
            this.pn_upload.Controls.Add(this.label10);
            this.pn_upload.Location = new System.Drawing.Point(796, 0);
            this.pn_upload.Name = "pn_upload";
            this.pn_upload.Size = new System.Drawing.Size(387, 570);
            this.pn_upload.TabIndex = 11;
            // 
            // lb_upload_filePath
            // 
            this.lb_upload_filePath.AutoSize = true;
            this.lb_upload_filePath.BackColor = System.Drawing.Color.Transparent;
            this.lb_upload_filePath.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.lb_upload_filePath.ForeColor = System.Drawing.Color.Black;
            this.lb_upload_filePath.Location = new System.Drawing.Point(37, 418);
            this.lb_upload_filePath.Name = "lb_upload_filePath";
            this.lb_upload_filePath.Size = new System.Drawing.Size(13, 20);
            this.lb_upload_filePath.TabIndex = 0;
            this.lb_upload_filePath.Text = " ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label18.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label18.Location = new System.Drawing.Point(3, 4);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(27, 27);
            this.label18.TabIndex = 17;
            this.label18.Text = ">";
            this.toolTip1.SetToolTip(this.label18, "hide upload window");
            this.label18.Click += new System.EventHandler(this.label18_Click);
            this.label18.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.label18.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.Color.Green;
            this.btn_upload.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_upload.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btn_upload.ForeColor = System.Drawing.Color.White;
            this.btn_upload.Location = new System.Drawing.Point(157, 504);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(80, 31);
            this.btn_upload.TabIndex = 16;
            this.btn_upload.Text = "UPLOAD";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // tb_upload_filePath
            // 
            this.tb_upload_filePath.AllowDrop = true;
            this.tb_upload_filePath.BackColor = System.Drawing.Color.White;
            this.tb_upload_filePath.Controls.Add(this.label16);
            this.tb_upload_filePath.Location = new System.Drawing.Point(103, 371);
            this.tb_upload_filePath.Name = "tb_upload_filePath";
            this.tb_upload_filePath.Size = new System.Drawing.Size(217, 120);
            this.tb_upload_filePath.TabIndex = 15;
            this.toolTip1.SetToolTip(this.tb_upload_filePath, "upload file path");
            this.tb_upload_filePath.DragEnter += new System.Windows.Forms.DragEventHandler(this.tb_upload_filePath_DragEnter);
            this.tb_upload_filePath.DragLeave += new System.EventHandler(this.tb_upload_filePath_DragLeave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.label16.ForeColor = System.Drawing.Color.Black;
            this.label16.Location = new System.Drawing.Point(80, 48);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 20);
            this.label16.TabIndex = 0;
            this.label16.Text = "THAT";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(63, 371);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 19);
            this.label15.TabIndex = 8;
            this.label15.Text = "FILE";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label17.ForeColor = System.Drawing.Color.Black;
            this.label17.Location = new System.Drawing.Point(45, 323);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 19);
            this.label17.TabIndex = 8;
            this.label17.Text = "LOCAL";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(13, 272);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 19);
            this.label11.TabIndex = 8;
            this.label11.Text = "PASSWORD";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(22, 218);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 19);
            this.label12.TabIndex = 9;
            this.label12.Text = "ACCOUNT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(54, 167);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 19);
            this.label13.TabIndex = 10;
            this.label13.Text = "PORT";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(76, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 19);
            this.label14.TabIndex = 11;
            this.label14.Text = "IP";
            // 
            // tb_upload_serverPath
            // 
            this.tb_upload_serverPath.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_upload_serverPath.Location = new System.Drawing.Point(103, 320);
            this.tb_upload_serverPath.Name = "tb_upload_serverPath";
            this.tb_upload_serverPath.Size = new System.Drawing.Size(217, 25);
            this.tb_upload_serverPath.TabIndex = 14;
            this.tb_upload_serverPath.Text = "/home/project/";
            this.toolTip1.SetToolTip(this.tb_upload_serverPath, "ftp upload address");
            // 
            // tb_upload_pwd
            // 
            this.tb_upload_pwd.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_upload_pwd.Location = new System.Drawing.Point(103, 269);
            this.tb_upload_pwd.Name = "tb_upload_pwd";
            this.tb_upload_pwd.Size = new System.Drawing.Size(217, 25);
            this.tb_upload_pwd.TabIndex = 14;
            this.tb_upload_pwd.Text = "Abc123456***";
            this.toolTip1.SetToolTip(this.tb_upload_pwd, "ftp password");
            // 
            // tb_upload_user
            // 
            this.tb_upload_user.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_upload_user.Location = new System.Drawing.Point(103, 218);
            this.tb_upload_user.Name = "tb_upload_user";
            this.tb_upload_user.Size = new System.Drawing.Size(217, 25);
            this.tb_upload_user.TabIndex = 13;
            this.tb_upload_user.Text = "root";
            this.toolTip1.SetToolTip(this.tb_upload_user, "ftp user");
            // 
            // tb_upload_port
            // 
            this.tb_upload_port.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_upload_port.Location = new System.Drawing.Point(103, 167);
            this.tb_upload_port.Name = "tb_upload_port";
            this.tb_upload_port.Size = new System.Drawing.Size(217, 25);
            this.tb_upload_port.TabIndex = 12;
            this.tb_upload_port.Text = "22";
            this.toolTip1.SetToolTip(this.tb_upload_port, "ftp port");
            // 
            // tb_upload_ip
            // 
            this.tb_upload_ip.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_upload_ip.Location = new System.Drawing.Point(103, 59);
            this.tb_upload_ip.Multiline = true;
            this.tb_upload_ip.Name = "tb_upload_ip";
            this.tb_upload_ip.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_upload_ip.Size = new System.Drawing.Size(217, 82);
            this.tb_upload_ip.TabIndex = 7;
            this.toolTip1.SetToolTip(this.tb_upload_ip, "upload servers ip");
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 15F);
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(128, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(138, 27);
            this.label10.TabIndex = 6;
            this.label10.Text = "FILE UPLOAD";
            // 
            // lb_upload
            // 
            this.lb_upload.AutoSize = true;
            this.lb_upload.BackColor = System.Drawing.Color.Transparent;
            this.lb_upload.Font = new System.Drawing.Font("微软雅黑", 20F);
            this.lb_upload.ForeColor = System.Drawing.Color.DodgerBlue;
            this.lb_upload.Location = new System.Drawing.Point(761, 2);
            this.lb_upload.Name = "lb_upload";
            this.lb_upload.Size = new System.Drawing.Size(35, 35);
            this.lb_upload.TabIndex = 12;
            this.lb_upload.Text = "<";
            this.toolTip1.SetToolTip(this.lb_upload, "show upload window");
            this.lb_upload.Click += new System.EventHandler(this.lb_upload_Click);
            this.lb_upload.MouseEnter += new System.EventHandler(this._MouseEnter);
            this.lb_upload.MouseLeave += new System.EventHandler(this._MouseLeave);
            // 
            // tm_showUpload
            // 
            this.tm_showUpload.Interval = 10;
            this.tm_showUpload.Tick += new System.EventHandler(this.tm_showUpload_Tick);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lb_errorCount);
            this.panel1.Controls.Add(this.lb_successCount);
            this.panel1.Controls.Add(this.lb_runCount);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.lb_count);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.panel1.Location = new System.Drawing.Point(73, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(136, 105);
            this.panel1.TabIndex = 13;
            // 
            // lb_errorCount
            // 
            this.lb_errorCount.AutoSize = true;
            this.lb_errorCount.ForeColor = System.Drawing.Color.Lime;
            this.lb_errorCount.Location = new System.Drawing.Point(92, 68);
            this.lb_errorCount.Name = "lb_errorCount";
            this.lb_errorCount.Size = new System.Drawing.Size(15, 17);
            this.lb_errorCount.TabIndex = 0;
            this.lb_errorCount.Text = "0";
            // 
            // lb_successCount
            // 
            this.lb_successCount.AutoSize = true;
            this.lb_successCount.ForeColor = System.Drawing.Color.Lime;
            this.lb_successCount.Location = new System.Drawing.Point(92, 48);
            this.lb_successCount.Name = "lb_successCount";
            this.lb_successCount.Size = new System.Drawing.Size(15, 17);
            this.lb_successCount.TabIndex = 0;
            this.lb_successCount.Text = "0";
            // 
            // lb_runCount
            // 
            this.lb_runCount.AutoSize = true;
            this.lb_runCount.ForeColor = System.Drawing.Color.Lime;
            this.lb_runCount.Location = new System.Drawing.Point(92, 28);
            this.lb_runCount.Name = "lb_runCount";
            this.lb_runCount.Size = new System.Drawing.Size(15, 17);
            this.lb_runCount.TabIndex = 0;
            this.lb_runCount.Text = "0";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(4, 68);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(66, 17);
            this.label23.TabIndex = 0;
            this.label23.Text = "error sum";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(4, 48);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(80, 17);
            this.label21.TabIndex = 0;
            this.label21.Text = "success sum";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(4, 28);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(55, 17);
            this.label20.TabIndex = 0;
            this.label20.Text = "run sum";
            // 
            // lb_count
            // 
            this.lb_count.AutoSize = true;
            this.lb_count.ForeColor = System.Drawing.Color.Lime;
            this.lb_count.Location = new System.Drawing.Point(92, 8);
            this.lb_count.Name = "lb_count";
            this.lb_count.Size = new System.Drawing.Size(15, 17);
            this.lb_count.TabIndex = 0;
            this.lb_count.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(4, 8);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 17);
            this.label19.TabIndex = 0;
            this.label19.Text = "count";
            // 
            // tb_errorIp
            // 
            this.tb_errorIp.BackColor = System.Drawing.Color.Black;
            this.tb_errorIp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_errorIp.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_errorIp.ForeColor = System.Drawing.Color.White;
            this.tb_errorIp.Location = new System.Drawing.Point(18, 227);
            this.tb_errorIp.MaxLength = 0;
            this.tb_errorIp.Multiline = true;
            this.tb_errorIp.Name = "tb_errorIp";
            this.tb_errorIp.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_errorIp.Size = new System.Drawing.Size(346, 92);
            this.tb_errorIp.TabIndex = 14;
            this.toolTip1.SetToolTip(this.tb_errorIp, "error server ip");
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(145, 205);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(89, 17);
            this.label22.TabIndex = 15;
            this.label22.Text = "error address";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(169, 325);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(40, 17);
            this.label24.TabIndex = 17;
            this.label24.Text = "result";
            // 
            // tb_errorMessage
            // 
            this.tb_errorMessage.BackColor = System.Drawing.Color.Black;
            this.tb_errorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_errorMessage.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tb_errorMessage.ForeColor = System.Drawing.Color.White;
            this.tb_errorMessage.Location = new System.Drawing.Point(18, 347);
            this.tb_errorMessage.MaxLength = 0;
            this.tb_errorMessage.Multiline = true;
            this.tb_errorMessage.Name = "tb_errorMessage";
            this.tb_errorMessage.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_errorMessage.Size = new System.Drawing.Size(346, 92);
            this.tb_errorMessage.TabIndex = 16;
            this.toolTip1.SetToolTip(this.tb_errorMessage, "result");
            // 
            // pn_msg
            // 
            this.pn_msg.Controls.Add(this.label25);
            this.pn_msg.Controls.Add(this.tb_command);
            this.pn_msg.Controls.Add(this.label9);
            this.pn_msg.Controls.Add(this.label24);
            this.pn_msg.Controls.Add(this.tb_errorIp);
            this.pn_msg.Controls.Add(this.tb_errorMessage);
            this.pn_msg.Controls.Add(this.label22);
            this.pn_msg.Location = new System.Drawing.Point(432, 96);
            this.pn_msg.Name = "pn_msg";
            this.pn_msg.Size = new System.Drawing.Size(352, 451);
            this.pn_msg.TabIndex = 18;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label25.Location = new System.Drawing.Point(14, 4);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(38, 19);
            this.label25.TabIndex = 19;
            this.label25.Text = "clear";
            this.label25.Click += new System.EventHandler(this.label25_Click);
            // 
            // CACodeServerInit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(796, 646);
            this.Controls.Add(this.pn_msg);
            this.Controls.Add(this.pn_upload);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_send);
            this.Controls.Add(this.cb_kill);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_script);
            this.Controls.Add(this.tb_initPort);
            this.Controls.Add(this.tb_pwd);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.tb_port);
            this.Controls.Add(this.tb_ip);
            this.Controls.Add(this.lab_close);
            this.Controls.Add(this.lb_upload);
            this.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CACodeServerInit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CACODE SERVER INIT";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this._MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pn_upload.ResumeLayout(false);
            this.pn_upload.PerformLayout();
            this.tb_upload_filePath.ResumeLayout(false);
            this.tb_upload_filePath.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_msg.ResumeLayout(false);
            this.pn_msg.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_close;
        private System.Windows.Forms.TextBox tb_ip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_port;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_pwd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_script;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cb_kill;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_send;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_initPort;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_command;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pn_upload;
        private System.Windows.Forms.Label lb_upload;
        private System.Windows.Forms.Timer tm_showUpload;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tb_upload_pwd;
        private System.Windows.Forms.TextBox tb_upload_user;
        private System.Windows.Forms.TextBox tb_upload_port;
        private System.Windows.Forms.TextBox tb_upload_ip;
        private System.Windows.Forms.Panel tb_upload_filePath;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lb_upload_filePath;
        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tb_upload_serverPath;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_runCount;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lb_count;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lb_successCount;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lb_errorCount;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tb_errorIp;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tb_errorMessage;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Panel pn_msg;
        private System.Windows.Forms.Label label25;
    }
}

