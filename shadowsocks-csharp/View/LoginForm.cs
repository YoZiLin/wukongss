using Shadowsocks.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Shadowsocks.Model;

namespace Shadowsocks.View
{
    public partial class LoginForm : Form
    {
        private ShadowsocksController controller;
        private Configuration _modifiedConfiguration;
        public bool IsLoginAction = false;
        public LoginForm(ShadowsocksController controller)
        {
            this.Dock = DockStyle.Fill;
            this.StartPosition = FormStartPosition.CenterParent;
            this.controller = controller;
            InitializeComponent();

            _modifiedConfiguration = controller.GetConfigurationCopy();

            this.FormClosed += LoginForm_FormClosed;

            methodList.SelectedIndex = 0;
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

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string pwd = txtPwd.Text.Trim();
            if (string.IsNullOrEmpty(pwd))
            {
                MessageBox.Show("连接密码不能为空！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            int port = 0;
            if (!int.TryParse(txtPort.Text.Trim(), out port) || port == 0)
            {
                MessageBox.Show("请正确填写端口号！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            LoginButton.Enabled = false;
            string mgs = string.Empty;
            var nodes = LoginHelp.LoginAction(pwd, port.ToString(), ref mgs);
            if (nodes.Count > 0)
            {
                _modifiedConfiguration.userMetod = methodList.SelectedItem.ToString();
                _modifiedConfiguration.userPort = port.ToString();
                _modifiedConfiguration.userPassword = pwd;
                _modifiedConfiguration.configs = new List<Server>();
                foreach (var item in nodes)
                {
                    Server server = new Server()
                    {
                        password = pwd,
                        server_port = port,
                        method = methodList.SelectedItem.ToString(),
                        server = item.server,
                        remarks = item.remark
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
                MessageBox.Show(mgs, "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
        }
    }
}
