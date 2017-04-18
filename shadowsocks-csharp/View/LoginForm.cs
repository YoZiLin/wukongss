using Shadowsocks.Controller;
using Shadowsocks.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shadowsocks.View
{
    public partial class LoginForm : Form
    {
        private ShadowsocksController controller;
        private Configuration _modifiedConfiguration;
        public bool IsLoginAction = false;

        public LoginForm(ShadowsocksController controller, bool isCanelUse = false)
        {
            InitializeComponent();
            this.controller = controller;
            _modifiedConfiguration = controller.GetConfigurationCopy();

            if (isCanelUse)
            {
                this.FormClosed += LoginForm_FormClosed;
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!IsLoginAction)
            {
                Application.Exit();
            }
            else
            {
                ConfigForm configForm = new ConfigForm(controller);
                configForm.Show();
                Program.MenuController._notifyIcon.Visible = true;
            }
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                int port = 0;
                if (!int.TryParse(txtPort.Text.Trim(), out port) || port == 0)
                {
                    MessageBox.Show("请正确填写端口号！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                string pwd = txtPwd.Text.Trim();
                if (string.IsNullOrEmpty(pwd))
                {
                    MessageBox.Show("连接密码不能为空！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    return;
                }
                LoginButton.Enabled = false;
                string mgs = string.Empty;
                string encryption = string.Empty;
                var nodes = LoginHelp.LoginAction(pwd, port.ToString(), ref mgs, ref encryption);
                if (nodes.Count > 0)
                {
                    _modifiedConfiguration.userMetod = encryption;
                    _modifiedConfiguration.userPort = port.ToString();
                    _modifiedConfiguration.userPassword = pwd;
                    _modifiedConfiguration.configs = new List<Server>();
                    foreach (var item in nodes)
                    {
                        Server server = new Server()
                        {
                            password = pwd,
                            server_port = port,
                            method = encryption,
                            server = item.server,
                            remarks = item.name
                        };
                        _modifiedConfiguration.configs.Add(server);
                    }
                    controller.SaveConfiguration(_modifiedConfiguration);
                    IsLoginAction = true;
                    this.Close();
                }
                else
                {
                    LoginButton.Enabled = true;
                    MessageBox.Show(mgs, "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logging.Error(ex);
                LoginButton.Enabled = true;
                MessageBox.Show("系统异常，请联系管理员！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RegButton_Click(object sender, EventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.ShowDialog();
        }
    }
}
