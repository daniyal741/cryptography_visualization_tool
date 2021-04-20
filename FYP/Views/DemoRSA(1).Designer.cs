namespace FYP
{
    partial class DemoRSA_1_
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoRSA_1_));
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.publicKey = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.privateKey = new System.Windows.Forms.Label();
            this.pause = new System.Windows.Forms.Button();
            this.Resume = new System.Windows.Forms.Button();
            this.left1 = new System.Windows.Forms.PictureBox();
            this.left2 = new System.Windows.Forms.PictureBox();
            this.setPublic = new System.Windows.Forms.Label();
            this.setPrivate = new System.Windows.Forms.Label();
            this.Encryp = new System.Windows.Forms.Label();
            this.enterNum = new System.Windows.Forms.Label();
            this.value_M = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.formulaencryp = new System.Windows.Forms.Label();
            this.powere = new System.Windows.Forms.Label();
            this.down1 = new System.Windows.Forms.PictureBox();
            this.down2 = new System.Windows.Forms.PictureBox();
            this.encryptvlaue = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.powere1 = new System.Windows.Forms.Label();
            this.calpowerd = new System.Windows.Forms.Label();
            this.calculatedecrypt = new System.Windows.Forms.Label();
            this.lastdown = new System.Windows.Forms.PictureBox();
            this.powerd = new System.Windows.Forms.Label();
            this.formuladecrypt = new System.Windows.Forms.Label();
            this.Decrypt = new System.Windows.Forms.Label();
            this.Reload = new System.Windows.Forms.Button();
            this.CipherText = new System.Windows.Forms.Label();
            this.PlainTextt = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.setPlain = new System.Windows.Forms.Label();
            this.setcipher = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.left1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.left2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.down2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastdown)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(15)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(0, -1);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 30);
            this.btnBack.TabIndex = 50;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnClose.BackgroundImage")));
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(15)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Location = new System.Drawing.Point(1192, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.TabIndex = 51;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // publicKey
            // 
            this.publicKey.AutoSize = true;
            this.publicKey.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.publicKey.ForeColor = System.Drawing.Color.White;
            this.publicKey.Location = new System.Drawing.Point(455, 92);
            this.publicKey.Name = "publicKey";
            this.publicKey.Size = new System.Drawing.Size(177, 28);
            this.publicKey.TabIndex = 52;
            this.publicKey.Text = "Public key = {e,n}";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(463, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 30);
            this.label3.TabIndex = 96;
            this.label3.Text = "RSA (Rivest-Shamir-Adleman)\r\n";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // privateKey
            // 
            this.privateKey.AutoSize = true;
            this.privateKey.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.privateKey.ForeColor = System.Drawing.Color.White;
            this.privateKey.Location = new System.Drawing.Point(445, 149);
            this.privateKey.Name = "privateKey";
            this.privateKey.Size = new System.Drawing.Size(187, 28);
            this.privateKey.TabIndex = 97;
            this.privateKey.Text = "Private key = {d,n}";
            // 
            // pause
            // 
            this.pause.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pause.FlatAppearance.BorderSize = 0;
            this.pause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pause.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pause.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.pause.Image = ((System.Drawing.Image)(resources.GetObject("pause.Image")));
            this.pause.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pause.Location = new System.Drawing.Point(548, 698);
            this.pause.Name = "pause";
            this.pause.Size = new System.Drawing.Size(159, 48);
            this.pause.TabIndex = 168;
            this.pause.Text = "Pause";
            this.pause.UseVisualStyleBackColor = false;
            this.pause.Click += new System.EventHandler(this.pause_Click);
            // 
            // Resume
            // 
            this.Resume.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Resume.FlatAppearance.BorderSize = 0;
            this.Resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resume.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resume.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.Resume.Image = ((System.Drawing.Image)(resources.GetObject("Resume.Image")));
            this.Resume.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Resume.Location = new System.Drawing.Point(548, 698);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(159, 48);
            this.Resume.TabIndex = 167;
            this.Resume.Text = "  Resume";
            this.Resume.UseVisualStyleBackColor = false;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // left1
            // 
            this.left1.Image = ((System.Drawing.Image)(resources.GetObject("left1.Image")));
            this.left1.Location = new System.Drawing.Point(639, 77);
            this.left1.Name = "left1";
            this.left1.Size = new System.Drawing.Size(72, 58);
            this.left1.TabIndex = 169;
            this.left1.TabStop = false;
            // 
            // left2
            // 
            this.left2.Image = ((System.Drawing.Image)(resources.GetObject("left2.Image")));
            this.left2.Location = new System.Drawing.Point(638, 134);
            this.left2.Name = "left2";
            this.left2.Size = new System.Drawing.Size(72, 58);
            this.left2.TabIndex = 170;
            this.left2.TabStop = false;
            // 
            // setPublic
            // 
            this.setPublic.AutoSize = true;
            this.setPublic.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPublic.ForeColor = System.Drawing.Color.White;
            this.setPublic.Location = new System.Drawing.Point(717, 92);
            this.setPublic.Name = "setPublic";
            this.setPublic.Size = new System.Drawing.Size(21, 28);
            this.setPublic.TabIndex = 171;
            this.setPublic.Text = "*";
            // 
            // setPrivate
            // 
            this.setPrivate.AutoSize = true;
            this.setPrivate.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPrivate.ForeColor = System.Drawing.Color.White;
            this.setPrivate.Location = new System.Drawing.Point(717, 149);
            this.setPrivate.Name = "setPrivate";
            this.setPrivate.Size = new System.Drawing.Size(21, 28);
            this.setPrivate.TabIndex = 172;
            this.setPrivate.Text = "*";
            // 
            // Encryp
            // 
            this.Encryp.AutoSize = true;
            this.Encryp.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Encryp.ForeColor = System.Drawing.Color.Red;
            this.Encryp.Location = new System.Drawing.Point(179, 258);
            this.Encryp.Name = "Encryp";
            this.Encryp.Size = new System.Drawing.Size(191, 30);
            this.Encryp.TabIndex = 173;
            this.Encryp.Text = "ENCRYPTION --->";
            // 
            // enterNum
            // 
            this.enterNum.AutoSize = true;
            this.enterNum.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterNum.ForeColor = System.Drawing.Color.White;
            this.enterNum.Location = new System.Drawing.Point(240, 334);
            this.enterNum.Name = "enterNum";
            this.enterNum.Size = new System.Drawing.Size(322, 25);
            this.enterNum.TabIndex = 174;
            this.enterNum.Text = "Enter Number For Encryption M = ";
            // 
            // value_M
            // 
            this.value_M.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_M.Location = new System.Drawing.Point(562, 330);
            this.value_M.Multiline = true;
            this.value_M.Name = "value_M";
            this.value_M.Size = new System.Drawing.Size(159, 39);
            this.value_M.TabIndex = 175;
            // 
            // Calculate
            // 
            this.Calculate.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Calculate.FlatAppearance.BorderSize = 0;
            this.Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Calculate.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.Calculate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Calculate.Location = new System.Drawing.Point(738, 326);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(148, 43);
            this.Calculate.TabIndex = 176;
            this.Calculate.Text = "Calculate";
            this.Calculate.UseVisualStyleBackColor = false;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // formulaencryp
            // 
            this.formulaencryp.AutoSize = true;
            this.formulaencryp.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formulaencryp.ForeColor = System.Drawing.Color.White;
            this.formulaencryp.Location = new System.Drawing.Point(366, 262);
            this.formulaencryp.Name = "formulaencryp";
            this.formulaencryp.Size = new System.Drawing.Size(138, 25);
            this.formulaencryp.TabIndex = 177;
            this.formulaencryp.Text = "C = M   mod n";
            // 
            // powere
            // 
            this.powere.AutoSize = true;
            this.powere.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powere.ForeColor = System.Drawing.Color.White;
            this.powere.Location = new System.Drawing.Point(419, 249);
            this.powere.Name = "powere";
            this.powere.Size = new System.Drawing.Size(19, 21);
            this.powere.TabIndex = 178;
            this.powere.Text = "e";
            this.powere.Click += new System.EventHandler(this.powere_Click);
            // 
            // down1
            // 
            this.down1.Image = ((System.Drawing.Image)(resources.GetObject("down1.Image")));
            this.down1.Location = new System.Drawing.Point(451, 290);
            this.down1.Name = "down1";
            this.down1.Size = new System.Drawing.Size(37, 40);
            this.down1.TabIndex = 179;
            this.down1.TabStop = false;
            // 
            // down2
            // 
            this.down2.Image = ((System.Drawing.Image)(resources.GetObject("down2.Image")));
            this.down2.Location = new System.Drawing.Point(793, 375);
            this.down2.Name = "down2";
            this.down2.Size = new System.Drawing.Size(37, 40);
            this.down2.TabIndex = 180;
            this.down2.TabStop = false;
            // 
            // encryptvlaue
            // 
            this.encryptvlaue.AutoSize = true;
            this.encryptvlaue.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encryptvlaue.ForeColor = System.Drawing.Color.White;
            this.encryptvlaue.Location = new System.Drawing.Point(748, 427);
            this.encryptvlaue.Name = "encryptvlaue";
            this.encryptvlaue.Size = new System.Drawing.Size(138, 25);
            this.encryptvlaue.TabIndex = 181;
            this.encryptvlaue.Text = "C = M   mod n";
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // powere1
            // 
            this.powere1.AutoSize = true;
            this.powere1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powere1.ForeColor = System.Drawing.Color.White;
            this.powere1.Location = new System.Drawing.Point(802, 413);
            this.powere1.Name = "powere1";
            this.powere1.Size = new System.Drawing.Size(19, 21);
            this.powere1.TabIndex = 182;
            this.powere1.Text = "e";
            // 
            // calpowerd
            // 
            this.calpowerd.AutoSize = true;
            this.calpowerd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calpowerd.ForeColor = System.Drawing.Color.White;
            this.calpowerd.Location = new System.Drawing.Point(585, 586);
            this.calpowerd.Name = "calpowerd";
            this.calpowerd.Size = new System.Drawing.Size(19, 21);
            this.calpowerd.TabIndex = 192;
            this.calpowerd.Text = "e";
            // 
            // calculatedecrypt
            // 
            this.calculatedecrypt.AutoSize = true;
            this.calculatedecrypt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculatedecrypt.ForeColor = System.Drawing.Color.White;
            this.calculatedecrypt.Location = new System.Drawing.Point(531, 600);
            this.calculatedecrypt.Name = "calculatedecrypt";
            this.calculatedecrypt.Size = new System.Drawing.Size(138, 25);
            this.calculatedecrypt.TabIndex = 191;
            this.calculatedecrypt.Text = "C = M   mod n";
            // 
            // lastdown
            // 
            this.lastdown.Image = ((System.Drawing.Image)(resources.GetObject("lastdown.Image")));
            this.lastdown.Location = new System.Drawing.Point(453, 545);
            this.lastdown.Name = "lastdown";
            this.lastdown.Size = new System.Drawing.Size(37, 40);
            this.lastdown.TabIndex = 189;
            this.lastdown.TabStop = false;
            // 
            // powerd
            // 
            this.powerd.AutoSize = true;
            this.powerd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.powerd.ForeColor = System.Drawing.Color.White;
            this.powerd.Location = new System.Drawing.Point(421, 502);
            this.powerd.Name = "powerd";
            this.powerd.Size = new System.Drawing.Size(20, 21);
            this.powerd.TabIndex = 188;
            this.powerd.Text = "d";
            // 
            // formuladecrypt
            // 
            this.formuladecrypt.AutoSize = true;
            this.formuladecrypt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formuladecrypt.ForeColor = System.Drawing.Color.White;
            this.formuladecrypt.Location = new System.Drawing.Point(368, 517);
            this.formuladecrypt.Name = "formuladecrypt";
            this.formuladecrypt.Size = new System.Drawing.Size(138, 25);
            this.formuladecrypt.TabIndex = 187;
            this.formuladecrypt.Text = "M = C   mod n";
            // 
            // Decrypt
            // 
            this.Decrypt.AutoSize = true;
            this.Decrypt.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Decrypt.ForeColor = System.Drawing.Color.Blue;
            this.Decrypt.Location = new System.Drawing.Point(181, 513);
            this.Decrypt.Name = "Decrypt";
            this.Decrypt.Size = new System.Drawing.Size(189, 30);
            this.Decrypt.TabIndex = 183;
            this.Decrypt.Text = "DECRYPTION --->";
            // 
            // Reload
            // 
            this.Reload.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Reload.FlatAppearance.BorderSize = 0;
            this.Reload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Reload.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reload.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.Reload.Image = ((System.Drawing.Image)(resources.GetObject("Reload.Image")));
            this.Reload.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Reload.Location = new System.Drawing.Point(548, 698);
            this.Reload.Name = "Reload";
            this.Reload.Size = new System.Drawing.Size(159, 48);
            this.Reload.TabIndex = 193;
            this.Reload.Text = "Reload";
            this.Reload.UseVisualStyleBackColor = false;
            this.Reload.Click += new System.EventHandler(this.Reload_Click);
            // 
            // CipherText
            // 
            this.CipherText.AutoSize = true;
            this.CipherText.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CipherText.ForeColor = System.Drawing.Color.White;
            this.CipherText.Location = new System.Drawing.Point(606, 427);
            this.CipherText.Name = "CipherText";
            this.CipherText.Size = new System.Drawing.Size(146, 25);
            this.CipherText.TabIndex = 194;
            this.CipherText.Text = "Cipher Text -->";
            // 
            // PlainTextt
            // 
            this.PlainTextt.AutoSize = true;
            this.PlainTextt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainTextt.ForeColor = System.Drawing.Color.White;
            this.PlainTextt.Location = new System.Drawing.Point(407, 600);
            this.PlainTextt.Name = "PlainTextt";
            this.PlainTextt.Size = new System.Drawing.Size(132, 25);
            this.PlainTextt.TabIndex = 195;
            this.PlainTextt.Text = "Plain Text -->";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(244)))));
            this.panel1.Controls.Add(this.setPlain);
            this.panel1.Controls.Add(this.setcipher);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(1060, 528);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(160, 91);
            this.panel1.TabIndex = 196;
            // 
            // setPlain
            // 
            this.setPlain.AutoSize = true;
            this.setPlain.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setPlain.Location = new System.Drawing.Point(118, 55);
            this.setPlain.Name = "setPlain";
            this.setPlain.Size = new System.Drawing.Size(17, 21);
            this.setPlain.TabIndex = 4;
            this.setPlain.Text = "*";
            // 
            // setcipher
            // 
            this.setcipher.AutoSize = true;
            this.setcipher.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setcipher.Location = new System.Drawing.Point(117, 13);
            this.setcipher.Name = "setcipher";
            this.setcipher.Size = new System.Drawing.Size(17, 21);
            this.setcipher.TabIndex = 3;
            this.setcipher.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Plain Text = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cipher Text = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(-19, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 65);
            this.label1.TabIndex = 0;
            this.label1.Text = "L\r\ne\r\na\r\nr\r\nn";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(100)))), ((int)(((byte)(244)))));
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label9);
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(1010, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(99, 113);
            this.panel2.TabIndex = 197;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 18);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 63);
            this.label8.TabIndex = 1;
            this.label8.Text = "Section\r\nEncryption\r\nDecryption \r\n";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label9.Location = new System.Drawing.Point(-19, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(13, 65);
            this.label9.TabIndex = 0;
            this.label9.Text = "L\r\ne\r\na\r\nr\r\nn";
            // 
            // DemoRSA_1_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.calpowerd);
            this.Controls.Add(this.calculatedecrypt);
            this.Controls.Add(this.lastdown);
            this.Controls.Add(this.powerd);
            this.Controls.Add(this.formuladecrypt);
            this.Controls.Add(this.Decrypt);
            this.Controls.Add(this.powere1);
            this.Controls.Add(this.encryptvlaue);
            this.Controls.Add(this.down2);
            this.Controls.Add(this.down1);
            this.Controls.Add(this.powere);
            this.Controls.Add(this.formulaencryp);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.value_M);
            this.Controls.Add(this.Encryp);
            this.Controls.Add(this.setPrivate);
            this.Controls.Add(this.setPublic);
            this.Controls.Add(this.left2);
            this.Controls.Add(this.left1);
            this.Controls.Add(this.pause);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.privateKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.publicKey);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.enterNum);
            this.Controls.Add(this.Reload);
            this.Controls.Add(this.CipherText);
            this.Controls.Add(this.PlainTextt);
            this.Name = "DemoRSA_1_";
            this.Size = new System.Drawing.Size(1220, 760);
            this.Load += new System.EventHandler(this.DemoRSA_1__Load);
            ((System.ComponentModel.ISupportInitialize)(this.left1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.left2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.down2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastdown)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label publicKey;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label privateKey;
        private System.Windows.Forms.Button pause;
        private System.Windows.Forms.Button Resume;
        private System.Windows.Forms.PictureBox left1;
        private System.Windows.Forms.PictureBox left2;
        private System.Windows.Forms.Label setPublic;
        private System.Windows.Forms.Label setPrivate;
        private System.Windows.Forms.Label Encryp;
        private System.Windows.Forms.Label enterNum;
        private System.Windows.Forms.TextBox value_M;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.Label formulaencryp;
        private System.Windows.Forms.Label powere;
        private System.Windows.Forms.PictureBox down1;
        private System.Windows.Forms.PictureBox down2;
        private System.Windows.Forms.Label encryptvlaue;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label powere1;
        private System.Windows.Forms.Label calpowerd;
        private System.Windows.Forms.Label calculatedecrypt;
        private System.Windows.Forms.PictureBox lastdown;
        private System.Windows.Forms.Label powerd;
        private System.Windows.Forms.Label formuladecrypt;
        private System.Windows.Forms.Label Decrypt;
        private System.Windows.Forms.Button Reload;
        private System.Windows.Forms.Label CipherText;
        private System.Windows.Forms.Label PlainTextt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label setPlain;
        private System.Windows.Forms.Label setcipher;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
