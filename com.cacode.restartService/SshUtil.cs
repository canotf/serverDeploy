using Renci.SshNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace com.cacode.restartService {
    public class SshUtil {

        /// <summary>
        /// 获取一个ssh连接器
        /// </summary>
        /// <param name="ip">ip地址</param>
        /// <param name="port">端口</param>
        /// <param name="user">登录名</param>
        /// <param name="pwd">密码</param>
        /// <returns></returns>
        public static ConnectionInfo getSsh(string ip, int port, string user, string pwd) {
            return new ConnectionInfo(ip, port, user, new AuthenticationMethod[]{
                new PasswordAuthenticationMethod(user,pwd),
             }
         );
        }

        /// <summary>
        /// 执行 command
        /// <param name="connection">ssh链接</param>
        /// <param name="command">执行的命令</param>
        /// </summary>
        public static string executeCommand(ConnectionInfo connection, string command) {
            SshClient sshClient = new SshClient(connection);
            try {
                sshClient.Connect();
            } catch (Exception err) {
                return $"error ip is:{connection.Host}&error message is:{err.Message}";
            }
            string result = null;
            using (SshCommand sshCommand = sshClient.CreateCommand(command)) {
                result = sshCommand.Execute();
            }
            sshClient.Disconnect();
            return result;
        }
        /// <summary>
        /// 上传文件
        /// </summary>
        public static void Upload(ConnectionInfo connection, string filePath, string fileName, string serverInitPath = "/home/project/") {
            using (var sftp = new SftpClient(connection)) {
                sftp.Connect();
                sftp.ChangeDirectory(serverInitPath);
                using (var uplfileStream = System.IO.File.OpenRead(filePath)) {
                    sftp.UploadFile(uplfileStream, fileName, true);
                }
                sftp.Disconnect();
            }
        }
    }
}
