namespace Shadowsocks.View
{
    partial class ConfigForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ServerGroupBox = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.RemarksTextBox = new System.Windows.Forms.TextBox();
            this.RemarksLabel = new System.Windows.Forms.Label();
            this.IPLabel = new System.Windows.Forms.Label();
            this.ServerPortLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.IPTextBox = new System.Windows.Forms.TextBox();
            this.ServerPortTextBox = new System.Windows.Forms.TextBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EncryptionLabel = new System.Windows.Forms.Label();
            this.EncryptionSelect = new System.Windows.Forms.ComboBox();
            this.OneTimeAuth = new System.Windows.Forms.CheckBox();
            this.ServersListBox = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.MyCancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ProxyPortTextBox = new System.Windows.Forms.TextBox();
            this.ProxyPortLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.MoveDownButton = new System.Windows.Forms.Button();
            this.MoveUpButton = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.BtnOK = new System.Windows.Forms.Button();
            this.BtnCanel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbUser = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel4.SuspendLayout();
            this.ServerGroupBox.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel2.AutoSize = true;
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.Location = new System.Drawing.Point(92, 234);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(0, 0);
            this.panel2.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel4.Controls.Add(this.DeleteButton, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 246);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel4.Size = new System.Drawing.Size(208, 41);
            this.tableLayoutPanel4.TabIndex = 8;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.DeleteButton.Location = new System.Drawing.Point(108, 8);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4, 8, 0, 4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(100, 29);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "&Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Visible = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.AddButton.Location = new System.Drawing.Point(0, 8);
            this.AddButton.Margin = new System.Windows.Forms.Padding(0, 8, 4, 4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(100, 29);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "&Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Visible = false;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ServerGroupBox
            // 
            this.ServerGroupBox.AutoSize = true;
            this.ServerGroupBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ServerGroupBox.Controls.Add(this.tableLayoutPanel1);
            this.ServerGroupBox.Location = new System.Drawing.Point(223, 0);
            this.ServerGroupBox.Margin = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.ServerGroupBox.Name = "ServerGroupBox";
            this.ServerGroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServerGroupBox.Size = new System.Drawing.Size(388, 246);
            this.ServerGroupBox.TabIndex = 0;
            this.ServerGroupBox.TabStop = false;
            this.ServerGroupBox.Text = "Server";
            this.ServerGroupBox.Visible = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.RemarksTextBox, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.RemarksLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.IPLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ServerPortLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.IPTextBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ServerPortTextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.PasswordTextBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.EncryptionLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.EncryptionSelect, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.OneTimeAuth, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 26);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(374, 198);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // RemarksTextBox
            // 
            this.RemarksTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.RemarksTextBox.Location = new System.Drawing.Point(111, 138);
            this.RemarksTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RemarksTextBox.MaxLength = 32;
            this.RemarksTextBox.Name = "RemarksTextBox";
            this.RemarksTextBox.Size = new System.Drawing.Size(255, 25);
            this.RemarksTextBox.TabIndex = 4;
            this.RemarksTextBox.WordWrap = false;
            // 
            // RemarksLabel
            // 
            this.RemarksLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RemarksLabel.AutoSize = true;
            this.RemarksLabel.Location = new System.Drawing.Point(40, 143);
            this.RemarksLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.RemarksLabel.Name = "RemarksLabel";
            this.RemarksLabel.Size = new System.Drawing.Size(63, 15);
            this.RemarksLabel.TabIndex = 9;
            this.RemarksLabel.Text = "Remarks";
            this.RemarksLabel.Visible = false;
            // 
            // IPLabel
            // 
            this.IPLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(24, 13);
            this.IPLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(79, 15);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "Server IP";
            this.IPLabel.Visible = false;
            // 
            // ServerPortLabel
            // 
            this.ServerPortLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ServerPortLabel.AutoSize = true;
            this.ServerPortLabel.Location = new System.Drawing.Point(8, 46);
            this.ServerPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ServerPortLabel.Name = "ServerPortLabel";
            this.ServerPortLabel.Size = new System.Drawing.Size(95, 15);
            this.ServerPortLabel.TabIndex = 1;
            this.ServerPortLabel.Text = "Server Port";
            this.ServerPortLabel.Visible = false;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(32, 79);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(71, 15);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Password";
            this.PasswordLabel.Visible = false;
            // 
            // IPTextBox
            // 
            this.IPTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.IPTextBox.Location = new System.Drawing.Point(111, 8);
            this.IPTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.IPTextBox.MaxLength = 512;
            this.IPTextBox.Name = "IPTextBox";
            this.IPTextBox.Size = new System.Drawing.Size(255, 25);
            this.IPTextBox.TabIndex = 0;
            this.IPTextBox.Visible = false;
            this.IPTextBox.WordWrap = false;
            // 
            // ServerPortTextBox
            // 
            this.ServerPortTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ServerPortTextBox.Location = new System.Drawing.Point(111, 41);
            this.ServerPortTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ServerPortTextBox.MaxLength = 10;
            this.ServerPortTextBox.Name = "ServerPortTextBox";
            this.ServerPortTextBox.Size = new System.Drawing.Size(255, 25);
            this.ServerPortTextBox.TabIndex = 1;
            this.ServerPortTextBox.WordWrap = false;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordTextBox.Location = new System.Drawing.Point(111, 74);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PasswordTextBox.MaxLength = 256;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(255, 25);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.WordWrap = false;
            // 
            // EncryptionLabel
            // 
            this.EncryptionLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.EncryptionLabel.AutoSize = true;
            this.EncryptionLabel.Location = new System.Drawing.Point(16, 111);
            this.EncryptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EncryptionLabel.Name = "EncryptionLabel";
            this.EncryptionLabel.Size = new System.Drawing.Size(87, 15);
            this.EncryptionLabel.TabIndex = 8;
            this.EncryptionLabel.Text = "Encryption";
            this.EncryptionLabel.Visible = false;
            // 
            // EncryptionSelect
            // 
            this.EncryptionSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EncryptionSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncryptionSelect.FormattingEnabled = true;
            this.EncryptionSelect.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.EncryptionSelect.ItemHeight = 15;
            this.EncryptionSelect.Items.AddRange(new object[] {
            "rc4-md5",
            "salsa20",
            "chacha20",
            "chacha20-ietf",
            "aes-256-cfb",
            "aes-192-cfb",
            "aes-128-cfb"});
            this.EncryptionSelect.Location = new System.Drawing.Point(111, 107);
            this.EncryptionSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.EncryptionSelect.Name = "EncryptionSelect";
            this.EncryptionSelect.Size = new System.Drawing.Size(255, 23);
            this.EncryptionSelect.TabIndex = 3;
            this.EncryptionSelect.Visible = false;
            this.EncryptionSelect.SelectedIndexChanged += new System.EventHandler(this.EncryptionSelect_SelectedIndexChanged);
            // 
            // OneTimeAuth
            // 
            this.OneTimeAuth.AutoSize = true;
            this.OneTimeAuth.Location = new System.Drawing.Point(111, 171);
            this.OneTimeAuth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OneTimeAuth.Name = "OneTimeAuth";
            this.OneTimeAuth.Size = new System.Drawing.Size(205, 19);
            this.OneTimeAuth.TabIndex = 5;
            this.OneTimeAuth.Text = "Onetime Authentication";
            this.OneTimeAuth.UseVisualStyleBackColor = true;
            this.OneTimeAuth.Visible = false;
            // 
            // ServersListBox
            // 
            this.ServersListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ServersListBox.FormattingEnabled = true;
            this.ServersListBox.IntegralHeight = false;
            this.ServersListBox.ItemHeight = 15;
            this.ServersListBox.Location = new System.Drawing.Point(15, 15);
            this.ServersListBox.Margin = new System.Windows.Forms.Padding(0);
            this.ServersListBox.MaximumSize = new System.Drawing.Size(354, 218);
            this.ServersListBox.Name = "ServersListBox";
            this.ServersListBox.Size = new System.Drawing.Size(354, 218);
            this.ServersListBox.TabIndex = 7;
            this.ServersListBox.SelectedIndexChanged += new System.EventHandler(this.ServersListBox_SelectedIndexChanged);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSize = true;
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Controls.Add(this.MyCancelButton, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.OKButton, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(411, 291);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 4, 0, 4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(200, 59);
            this.tableLayoutPanel3.TabIndex = 8;
            // 
            // MyCancelButton
            // 
            this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MyCancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MyCancelButton.Location = new System.Drawing.Point(106, 4);
            this.MyCancelButton.Margin = new System.Windows.Forms.Padding(4, 4, 0, 0);
            this.MyCancelButton.Name = "MyCancelButton";
            this.MyCancelButton.Size = new System.Drawing.Size(94, 55);
            this.MyCancelButton.TabIndex = 13;
            this.MyCancelButton.Text = "Cancel";
            this.MyCancelButton.UseVisualStyleBackColor = true;
            this.MyCancelButton.Visible = false;
            this.MyCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.OKButton.Location = new System.Drawing.Point(4, 4);
            this.OKButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 0);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(94, 55);
            this.OKButton.TabIndex = 12;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Visible = false;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.Controls.Add(this.ProxyPortTextBox, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.ProxyPortLabel, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(360, 246);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(251, 41);
            this.tableLayoutPanel5.TabIndex = 9;
            // 
            // ProxyPortTextBox
            // 
            this.ProxyPortTextBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.ProxyPortTextBox.Location = new System.Drawing.Point(103, 8);
            this.ProxyPortTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.ProxyPortTextBox.MaxLength = 10;
            this.ProxyPortTextBox.Name = "ProxyPortTextBox";
            this.ProxyPortTextBox.Size = new System.Drawing.Size(140, 25);
            this.ProxyPortTextBox.TabIndex = 6;
            this.ProxyPortTextBox.WordWrap = false;
            // 
            // ProxyPortLabel
            // 
            this.ProxyPortLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.ProxyPortLabel.AutoSize = true;
            this.ProxyPortLabel.Location = new System.Drawing.Point(8, 13);
            this.ProxyPortLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ProxyPortLabel.Name = "ProxyPortLabel";
            this.ProxyPortLabel.Size = new System.Drawing.Size(87, 15);
            this.ProxyPortLabel.TabIndex = 3;
            this.ProxyPortLabel.Text = "Proxy Port";
            this.ProxyPortLabel.Visible = false;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.AutoSize = true;
            this.tableLayoutPanel6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel6.Controls.Add(this.MoveDownButton, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.MoveUpButton, 0, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(0, 287);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel6.Size = new System.Drawing.Size(208, 41);
            this.tableLayoutPanel6.TabIndex = 10;
            // 
            // MoveDownButton
            // 
            this.MoveDownButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MoveDownButton.Location = new System.Drawing.Point(108, 8);
            this.MoveDownButton.Margin = new System.Windows.Forms.Padding(4, 8, 0, 4);
            this.MoveDownButton.Name = "MoveDownButton";
            this.MoveDownButton.Size = new System.Drawing.Size(100, 29);
            this.MoveDownButton.TabIndex = 11;
            this.MoveDownButton.Text = "Move D&own";
            this.MoveDownButton.UseVisualStyleBackColor = true;
            this.MoveDownButton.Visible = false;
            this.MoveDownButton.Click += new System.EventHandler(this.MoveDownButton_Click);
            // 
            // MoveUpButton
            // 
            this.MoveUpButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.MoveUpButton.Location = new System.Drawing.Point(0, 8);
            this.MoveUpButton.Margin = new System.Windows.Forms.Padding(0, 8, 4, 4);
            this.MoveUpButton.Name = "MoveUpButton";
            this.MoveUpButton.Size = new System.Drawing.Size(100, 29);
            this.MoveUpButton.TabIndex = 10;
            this.MoveUpButton.Text = "Move &Up";
            this.MoveUpButton.UseVisualStyleBackColor = true;
            this.MoveUpButton.Visible = false;
            this.MoveUpButton.Click += new System.EventHandler(this.MoveUpButton_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSize = true;
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.ServerGroupBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(568, 195);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(611, 354);
            this.tableLayoutPanel2.TabIndex = 7;
            this.tableLayoutPanel2.Visible = false;
            // 
            // BtnOK
            // 
            this.BtnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnOK.Location = new System.Drawing.Point(15, 255);
            this.BtnOK.Margin = new System.Windows.Forms.Padding(2);
            this.BtnOK.Name = "BtnOK";
            this.BtnOK.Size = new System.Drawing.Size(95, 40);
            this.BtnOK.TabIndex = 8;
            this.BtnOK.Text = "确 定";
            this.BtnOK.UseVisualStyleBackColor = true;
            this.BtnOK.Click += new System.EventHandler(this.BtnOK_Click);
            // 
            // BtnCanel
            // 
            this.BtnCanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCanel.Location = new System.Drawing.Point(274, 255);
            this.BtnCanel.Margin = new System.Windows.Forms.Padding(2);
            this.BtnCanel.Name = "BtnCanel";
            this.BtnCanel.Size = new System.Drawing.Size(95, 40);
            this.BtnCanel.TabIndex = 9;
            this.BtnCanel.Text = "注 销";
            this.BtnCanel.UseVisualStyleBackColor = true;
            this.BtnCanel.Click += new System.EventHandler(this.BtnCanel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 320);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "选择你需要的节点，点击确定即可使用！(＾－＾)V";
            // 
            // rbUser
            // 
            this.rbUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbUser.Location = new System.Drawing.Point(15, 361);
            this.rbUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbUser.Name = "rbUser";
            this.rbUser.ReadOnly = true;
            this.rbUser.Size = new System.Drawing.Size(354, 190);
            this.rbUser.TabIndex = 11;
            this.rbUser.Text = "";
            // 
            // ConfigForm
            // 
            this.AcceptButton = this.OKButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.CancelButton = this.MyCancelButton;
            this.ClientSize = new System.Drawing.Size(384, 566);
            this.Controls.Add(this.rbUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCanel);
            this.Controls.Add(this.BtnOK);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ServersListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigForm";
            this.Padding = new System.Windows.Forms.Padding(15, 15, 15, 11);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "选择服务器";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ConfigForm_FormClosed);
            this.Load += new System.EventHandler(this.ConfigForm_Load);
            this.Shown += new System.EventHandler(this.ConfigForm_Shown);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ServerGroupBox.ResumeLayout(false);
            this.ServerGroupBox.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.GroupBox ServerGroupBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox RemarksTextBox;
        private System.Windows.Forms.Label RemarksLabel;
        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label ServerPortLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox IPTextBox;
        private System.Windows.Forms.TextBox ServerPortTextBox;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Label EncryptionLabel;
        private System.Windows.Forms.ComboBox EncryptionSelect;
        private System.Windows.Forms.CheckBox OneTimeAuth;
        private System.Windows.Forms.ListBox ServersListBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button MyCancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TextBox ProxyPortTextBox;
        private System.Windows.Forms.Label ProxyPortLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.Button MoveDownButton;
        private System.Windows.Forms.Button MoveUpButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button BtnOK;
        private System.Windows.Forms.Button BtnCanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rbUser;
    }
}

