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

namespace Shadowsocks.View
{
    public partial class LoginForm : Form
    {
        private ShadowsocksController controller;
        public LoginForm(ShadowsocksController controller)
        {
            this.controller = controller;
            InitializeComponent();
            this.FormClosed += LoginForm_FormClosed;
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            controller.Stop();
            Application.Exit();
        }
    }
}
