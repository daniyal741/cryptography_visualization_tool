namespace FYP
{
    partial class DemoMultiplicativeCaesarDecrypt
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoMultiplicativeCaesarDecrypt));
            this.encrypt_value = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBackToMain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.arrow2Box = new FYP.SyncRichTextBox();
            this.CiphervalueBox = new FYP.SyncRichTextBox();
            this.EqualBox = new FYP.SyncRichTextBox();
            this.KeyBox = new FYP.SyncRichTextBox();
            this.PlusBox = new FYP.SyncRichTextBox();
            this.PlainvalueBox = new FYP.SyncRichTextBox();
            this.arrow1Box = new FYP.SyncRichTextBox();
            this.PlaintextBox = new FYP.SyncRichTextBox();
            this.CiphertextBox = new FYP.SyncRichTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Stop = new System.Windows.Forms.Button();
            this.Resume = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // encrypt_value
            // 
            this.encrypt_value.AutoSize = true;
            this.encrypt_value.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.encrypt_value.ForeColor = System.Drawing.Color.White;
            this.encrypt_value.Location = new System.Drawing.Point(370, 26);
            this.encrypt_value.Name = "encrypt_value";
            this.encrypt_value.Size = new System.Drawing.Size(20, 25);
            this.encrypt_value.TabIndex = 47;
            this.encrypt_value.Text = "*";
            this.encrypt_value.Click += new System.EventHandler(this.encrypt_value_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(19, 10);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(15)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.DodgerBlue;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 103);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnBackToMain
            // 
            this.btnBackToMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnBackToMain.FlatAppearance.BorderSize = 0;
            this.btnBackToMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBackToMain.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToMain.ForeColor = System.Drawing.Color.White;
            this.btnBackToMain.Location = new System.Drawing.Point(657, 640);
            this.btnBackToMain.Name = "btnBackToMain";
            this.btnBackToMain.Size = new System.Drawing.Size(199, 63);
            this.btnBackToMain.TabIndex = 46;
            this.btnBackToMain.Text = "Back to main";
            this.btnBackToMain.UseVisualStyleBackColor = false;
            this.btnBackToMain.Click += new System.EventHandler(this.btnBackToMain_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(83, 96);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 110);
            this.panel2.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label6.Location = new System.Drawing.Point(564, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "CipherValue";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label5.Location = new System.Drawing.Point(350, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "K_Inverse";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label4.Location = new System.Drawing.Point(233, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "PlainValue";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label2.Location = new System.Drawing.Point(760, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "PlainCharacter";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnStart.FlatAppearance.BorderSize = 0;
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(385, 640);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(199, 63);
            this.btnStart.TabIndex = 45;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(15)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(0, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 30);
            this.btnBack.TabIndex = 44;
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
            this.btnClose.Location = new System.Drawing.Point(1191, -2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(28, 29);
            this.btnClose.TabIndex = 43;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(88, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 20);
            this.label8.TabIndex = 42;
            this.label8.Text = "Note2 : Third  Row represent Cipher Characters";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 213);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(308, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "Note1 : First Row represent Plain Characters";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(81, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 25);
            this.label7.TabIndex = 40;
            this.label7.Text = "Caesar Cipher Shifting Table :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label1.Location = new System.Drawing.Point(52, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "CipherCharacter";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.arrow2Box);
            this.panel1.Controls.Add(this.CiphervalueBox);
            this.panel1.Controls.Add(this.EqualBox);
            this.panel1.Controls.Add(this.KeyBox);
            this.panel1.Controls.Add(this.PlusBox);
            this.panel1.Controls.Add(this.PlainvalueBox);
            this.panel1.Controls.Add(this.arrow1Box);
            this.panel1.Controls.Add(this.PlaintextBox);
            this.panel1.Controls.Add(this.CiphertextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(86, 283);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1013, 328);
            this.panel1.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.label9.Location = new System.Drawing.Point(469, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 25);
            this.label9.TabIndex = 23;
            this.label9.Text = "Mod";
            // 
            // arrow2Box
            // 
            this.arrow2Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrow2Box.Buddies = null;
            this.arrow2Box.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrow2Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.arrow2Box.Location = new System.Drawing.Point(704, 72);
            this.arrow2Box.Name = "arrow2Box";
            this.arrow2Box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.arrow2Box.Size = new System.Drawing.Size(73, 203);
            this.arrow2Box.TabIndex = 22;
            this.arrow2Box.Text = "";
            // 
            // CiphervalueBox
            // 
            this.CiphervalueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CiphervalueBox.Buddies = null;
            this.CiphervalueBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiphervalueBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.CiphervalueBox.Location = new System.Drawing.Point(618, 72);
            this.CiphervalueBox.Name = "CiphervalueBox";
            this.CiphervalueBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.CiphervalueBox.Size = new System.Drawing.Size(72, 203);
            this.CiphervalueBox.TabIndex = 21;
            this.CiphervalueBox.Text = "";
            // 
            // EqualBox
            // 
            this.EqualBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EqualBox.Buddies = null;
            this.EqualBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EqualBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.EqualBox.Location = new System.Drawing.Point(546, 72);
            this.EqualBox.Name = "EqualBox";
            this.EqualBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.EqualBox.Size = new System.Drawing.Size(48, 203);
            this.EqualBox.TabIndex = 20;
            this.EqualBox.Text = "";
            // 
            // KeyBox
            // 
            this.KeyBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.KeyBox.Buddies = null;
            this.KeyBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.KeyBox.Location = new System.Drawing.Point(443, 72);
            this.KeyBox.Name = "KeyBox";
            this.KeyBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.KeyBox.Size = new System.Drawing.Size(88, 203);
            this.KeyBox.TabIndex = 19;
            this.KeyBox.Text = "";
            // 
            // PlusBox
            // 
            this.PlusBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlusBox.Buddies = null;
            this.PlusBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlusBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.PlusBox.Location = new System.Drawing.Point(379, 72);
            this.PlusBox.Name = "PlusBox";
            this.PlusBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PlusBox.Size = new System.Drawing.Size(65, 203);
            this.PlusBox.TabIndex = 18;
            this.PlusBox.Text = "";
            // 
            // PlainvalueBox
            // 
            this.PlainvalueBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlainvalueBox.Buddies = null;
            this.PlainvalueBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlainvalueBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.PlainvalueBox.Location = new System.Drawing.Point(274, 72);
            this.PlainvalueBox.Name = "PlainvalueBox";
            this.PlainvalueBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PlainvalueBox.Size = new System.Drawing.Size(105, 203);
            this.PlainvalueBox.TabIndex = 17;
            this.PlainvalueBox.Text = "";
            // 
            // arrow1Box
            // 
            this.arrow1Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.arrow1Box.Buddies = null;
            this.arrow1Box.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.arrow1Box.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.arrow1Box.Location = new System.Drawing.Point(187, 72);
            this.arrow1Box.Name = "arrow1Box";
            this.arrow1Box.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.arrow1Box.Size = new System.Drawing.Size(74, 203);
            this.arrow1Box.TabIndex = 16;
            this.arrow1Box.Text = "";
            // 
            // PlaintextBox
            // 
            this.PlaintextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PlaintextBox.Buddies = null;
            this.PlaintextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlaintextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.PlaintextBox.Location = new System.Drawing.Point(96, 72);
            this.PlaintextBox.Name = "PlaintextBox";
            this.PlaintextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.PlaintextBox.Size = new System.Drawing.Size(72, 203);
            this.PlaintextBox.TabIndex = 15;
            this.PlaintextBox.Text = "";
            // 
            // CiphertextBox
            // 
            this.CiphertextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CiphertextBox.Buddies = null;
            this.CiphertextBox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CiphertextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.CiphertextBox.Location = new System.Drawing.Point(819, 72);
            this.CiphertextBox.Name = "CiphertextBox";
            this.CiphertextBox.Size = new System.Drawing.Size(69, 203);
            this.CiphertextBox.TabIndex = 14;
            this.CiphertextBox.Text = "";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(966, 71);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 25);
            this.label10.TabIndex = 48;
            this.label10.Text = "DECRYPTION";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Help;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1161, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 49;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Stop
            // 
            this.Stop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Stop.FlatAppearance.BorderSize = 0;
            this.Stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop.ForeColor = System.Drawing.Color.White;
            this.Stop.Location = new System.Drawing.Point(385, 640);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(199, 63);
            this.Stop.TabIndex = 50;
            this.Stop.Text = "Pause";
            this.Stop.UseVisualStyleBackColor = false;
            this.Stop.Click += new System.EventHandler(this.button1_Click);
            // 
            // Resume
            // 
            this.Resume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.Resume.FlatAppearance.BorderSize = 0;
            this.Resume.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Resume.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Resume.ForeColor = System.Drawing.Color.White;
            this.Resume.Location = new System.Drawing.Point(385, 640);
            this.Resume.Name = "Resume";
            this.Resume.Size = new System.Drawing.Size(199, 63);
            this.Resume.TabIndex = 51;
            this.Resume.Text = "Resume";
            this.Resume.UseVisualStyleBackColor = false;
            this.Resume.Click += new System.EventHandler(this.Resume_Click);
            // 
            // DemoMultiplicativeCaesarDecrypt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.encrypt_value);
            this.Controls.Add(this.btnBackToMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.Resume);
            this.Controls.Add(this.Stop);
            this.Name = "DemoMultiplicativeCaesarDecrypt";
            this.Size = new System.Drawing.Size(1220, 760);
            this.Load += new System.EventHandler(this.DemoMultiplicativeCaesarDecrypt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label encrypt_value;
        private System.Windows.Forms.DataGridView dataGridView1;
        private SyncRichTextBox arrow2Box;
        private SyncRichTextBox CiphervalueBox;
        private SyncRichTextBox EqualBox;
        private SyncRichTextBox KeyBox;
        private SyncRichTextBox PlusBox;
        private SyncRichTextBox PlainvalueBox;
        private SyncRichTextBox arrow1Box;
        private SyncRichTextBox PlaintextBox;
        private SyncRichTextBox CiphertextBox;
        private System.Windows.Forms.Button btnBackToMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Resume;
    }
}
