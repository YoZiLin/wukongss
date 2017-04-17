namespace Shadowsocks.View
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtPort = new System.Windows.Forms.TextBox();
            this.methodList = new System.Windows.Forms.ComboBox();
            this.RegButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "连接密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "连接端口：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "加密方式：";
            // 
            // LoginButton
            // 
            this.LoginButton.Location = new System.Drawing.Point(64, 175);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(80, 23);
            this.LoginButton.TabIndex = 3;
            this.LoginButton.Text = "登 录";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(130, 40);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(106, 21);
            this.txtPwd.TabIndex = 4;
            // 
            // txtPort
            // 
            this.txtPort.Location = new System.Drawing.Point(130, 80);
            this.txtPort.Name = "txtPort";
            this.txtPort.Size = new System.Drawing.Size(106, 21);
            this.txtPort.TabIndex = 5;
            // 
            // methodList
            // 
            this.methodList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodList.FormattingEnabled = true;
            this.methodList.Items.AddRange(new object[] {
            "rc4-md5",
            "salsa20",
            "chacha20",
            "chacha20-ietf",
            "aes-256-cfb",
            "aes-192-cfb",
            "aes-128-cfb",
            "aes-256-ctr",
            "aes-192-ctr",
            "aes-128-ctr",
            "bf-cfb",
            "camellia-128-cfb",
            "camellia-192-cfb",
            "camellia-256-cfb",
            "aes-128-gcm",
            "aes-192-gcm",
            "aes-256-gcm",
            "chacha20-ietf-poly1305"});
            this.methodList.Location = new System.Drawing.Point(130, 114);
            this.methodList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.methodList.Name = "methodList";
            this.methodList.Size = new System.Drawing.Size(106, 20);
            this.methodList.TabIndex = 6;
            // 
            // RegButton
            // 
            this.RegButton.Location = new System.Drawing.Point(156, 175);
            this.RegButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RegButton.Name = "RegButton";
            this.RegButton.Size = new System.Drawing.Size(80, 23);
            this.RegButton.TabIndex = 7;
            this.RegButton.Text = "注 册";
            this.RegButton.UseVisualStyleBackColor = true;
            this.RegButton.Click += new System.EventHandler(this.RegButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(303, 262);
            this.Controls.Add(this.RegButton);
            this.Controls.Add(this.methodList);
            this.Controls.Add(this.txtPort);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WuKongSS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtPort;
        private System.Windows.Forms.ComboBox methodList;
        private System.Windows.Forms.Button RegButton;
    }
}