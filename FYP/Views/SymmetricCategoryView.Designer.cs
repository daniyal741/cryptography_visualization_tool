namespace FYP
{
    partial class SymmetricCategory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SymmetricCategory));
            this.labelHeading = new System.Windows.Forms.Label();
            this.btnClassical = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnSubstitution = new System.Windows.Forms.Button();
            this.btnTransposition = new System.Windows.Forms.Button();
            this.btnCaesarCipher = new System.Windows.Forms.Button();
            this.btnVigenere = new System.Windows.Forms.Button();
            this.btnOneTimePad = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.mainBar = new System.Windows.Forms.Panel();
            this.bar1 = new System.Windows.Forms.Panel();
            this.bar2 = new System.Windows.Forms.Panel();
            this.bar3 = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAES = new System.Windows.Forms.Button();
            this.btn3DES = new System.Windows.Forms.Button();
            this.btnDES = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelHeading
            // 
            this.labelHeading.AutoSize = true;
            this.labelHeading.BackColor = System.Drawing.Color.Transparent;
            this.labelHeading.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeading.ForeColor = System.Drawing.Color.Transparent;
            this.labelHeading.Location = new System.Drawing.Point(478, 62);
            this.labelHeading.Name = "labelHeading";
            this.labelHeading.Size = new System.Drawing.Size(261, 45);
            this.labelHeading.TabIndex = 4;
            this.labelHeading.Text = "Select Algorithm";
            // 
            // btnClassical
            // 
            this.btnClassical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnClassical.FlatAppearance.BorderSize = 0;
            this.btnClassical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassical.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClassical.ForeColor = System.Drawing.Color.White;
            this.btnClassical.Location = new System.Drawing.Point(193, 173);
            this.btnClassical.Name = "btnClassical";
            this.btnClassical.Size = new System.Drawing.Size(202, 59);
            this.btnClassical.TabIndex = 5;
            this.btnClassical.Text = "Classical";
            this.btnClassical.UseVisualStyleBackColor = false;
            this.btnClassical.Click += new System.EventHandler(this.btnClassical_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(829, 173);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(199, 59);
            this.button3.TabIndex = 7;
            this.button3.Text = "Advance";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnSubstitution
            // 
            this.btnSubstitution.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnSubstitution.FlatAppearance.BorderSize = 0;
            this.btnSubstitution.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubstitution.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubstitution.ForeColor = System.Drawing.Color.White;
            this.btnSubstitution.Location = new System.Drawing.Point(91, 286);
            this.btnSubstitution.Name = "btnSubstitution";
            this.btnSubstitution.Size = new System.Drawing.Size(172, 48);
            this.btnSubstitution.TabIndex = 8;
            this.btnSubstitution.Text = "Substitution";
            this.btnSubstitution.UseVisualStyleBackColor = false;
            this.btnSubstitution.Visible = false;
            this.btnSubstitution.Click += new System.EventHandler(this.btnSubstitution_Click);
            // 
            // btnTransposition
            // 
            this.btnTransposition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnTransposition.FlatAppearance.BorderSize = 0;
            this.btnTransposition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTransposition.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTransposition.ForeColor = System.Drawing.Color.White;
            this.btnTransposition.Location = new System.Drawing.Point(323, 286);
            this.btnTransposition.Name = "btnTransposition";
            this.btnTransposition.Size = new System.Drawing.Size(174, 48);
            this.btnTransposition.TabIndex = 9;
            this.btnTransposition.Text = "Transposition";
            this.btnTransposition.UseVisualStyleBackColor = false;
            this.btnTransposition.Visible = false;
            // 
            // btnCaesarCipher
            // 
            this.btnCaesarCipher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnCaesarCipher.FlatAppearance.BorderSize = 0;
            this.btnCaesarCipher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCaesarCipher.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaesarCipher.ForeColor = System.Drawing.Color.White;
            this.btnCaesarCipher.Location = new System.Drawing.Point(121, 356);
            this.btnCaesarCipher.Name = "btnCaesarCipher";
            this.btnCaesarCipher.Size = new System.Drawing.Size(142, 48);
            this.btnCaesarCipher.TabIndex = 10;
            this.btnCaesarCipher.Text = "Caesar Cipher";
            this.btnCaesarCipher.UseVisualStyleBackColor = false;
            this.btnCaesarCipher.Visible = false;
            this.btnCaesarCipher.Click += new System.EventHandler(this.btnCaesarCipher_Click);
            // 
            // btnVigenere
            // 
            this.btnVigenere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnVigenere.FlatAppearance.BorderSize = 0;
            this.btnVigenere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVigenere.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVigenere.ForeColor = System.Drawing.Color.White;
            this.btnVigenere.Location = new System.Drawing.Point(121, 430);
            this.btnVigenere.Name = "btnVigenere";
            this.btnVigenere.Size = new System.Drawing.Size(142, 48);
            this.btnVigenere.TabIndex = 11;
            this.btnVigenere.Text = "Vigenere";
            this.btnVigenere.UseVisualStyleBackColor = false;
            this.btnVigenere.Visible = false;
            this.btnVigenere.Click += new System.EventHandler(this.btnVigenere_Click);
            // 
            // btnOneTimePad
            // 
            this.btnOneTimePad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnOneTimePad.FlatAppearance.BorderSize = 0;
            this.btnOneTimePad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOneTimePad.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOneTimePad.ForeColor = System.Drawing.Color.White;
            this.btnOneTimePad.Location = new System.Drawing.Point(121, 503);
            this.btnOneTimePad.Name = "btnOneTimePad";
            this.btnOneTimePad.Size = new System.Drawing.Size(142, 48);
            this.btnOneTimePad.TabIndex = 12;
            this.btnOneTimePad.Text = "OneTime Pad";
            this.btnOneTimePad.UseVisualStyleBackColor = false;
            this.btnOneTimePad.Visible = false;
            this.btnOneTimePad.Click += new System.EventHandler(this.btnOneTimePad_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(355, 356);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 48);
            this.button5.TabIndex = 13;
            this.button5.Text = "Rail Fence";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(355, 430);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 64);
            this.button6.TabIndex = 14;
            this.button6.Text = "Row Transposition";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            // 
            // mainBar
            // 
            this.mainBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.mainBar.Location = new System.Drawing.Point(91, 356);
            this.mainBar.Name = "mainBar";
            this.mainBar.Size = new System.Drawing.Size(10, 195);
            this.mainBar.TabIndex = 16;
            this.mainBar.Visible = false;
            // 
            // bar1
            // 
            this.bar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.bar1.ForeColor = System.Drawing.Color.White;
            this.bar1.Location = new System.Drawing.Point(91, 377);
            this.bar1.Name = "bar1";
            this.bar1.Size = new System.Drawing.Size(30, 10);
            this.bar1.TabIndex = 17;
            this.bar1.Visible = false;
            // 
            // bar2
            // 
            this.bar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.bar2.ForeColor = System.Drawing.Color.White;
            this.bar2.Location = new System.Drawing.Point(91, 450);
            this.bar2.Name = "bar2";
            this.bar2.Size = new System.Drawing.Size(30, 10);
            this.bar2.TabIndex = 18;
            this.bar2.Visible = false;
            // 
            // bar3
            // 
            this.bar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.bar3.ForeColor = System.Drawing.Color.White;
            this.bar3.Location = new System.Drawing.Point(91, 522);
            this.bar3.Name = "bar3";
            this.bar3.Size = new System.Drawing.Size(30, 10);
            this.bar3.TabIndex = 19;
            this.bar3.Visible = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Transparent;
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(15)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 30);
            this.btnBack.TabIndex = 22;
            this.btnBack.UseVisualStyleBackColor = false;
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
            this.btnClose.TabIndex = 21;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel1.ForeColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(832, 522);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(30, 10);
            this.panel1.TabIndex = 29;
            this.panel1.Visible = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel2.ForeColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(832, 450);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(30, 10);
            this.panel2.TabIndex = 28;
            this.panel2.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel3.ForeColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(832, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(30, 10);
            this.panel3.TabIndex = 27;
            this.panel3.Visible = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.panel4.ForeColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(832, 356);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 195);
            this.panel4.TabIndex = 26;
            this.panel4.Visible = false;
            // 
            // btnAES
            // 
            this.btnAES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnAES.FlatAppearance.BorderSize = 0;
            this.btnAES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAES.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAES.ForeColor = System.Drawing.Color.White;
            this.btnAES.Location = new System.Drawing.Point(862, 503);
            this.btnAES.Name = "btnAES";
            this.btnAES.Size = new System.Drawing.Size(142, 48);
            this.btnAES.TabIndex = 25;
            this.btnAES.Text = "AES";
            this.btnAES.UseVisualStyleBackColor = false;
            this.btnAES.Visible = false;
            this.btnAES.Click += new System.EventHandler(this.btnAES_Click);
            // 
            // btn3DES
            // 
            this.btn3DES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btn3DES.FlatAppearance.BorderSize = 0;
            this.btn3DES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3DES.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3DES.ForeColor = System.Drawing.Color.White;
            this.btn3DES.Location = new System.Drawing.Point(862, 430);
            this.btn3DES.Name = "btn3DES";
            this.btn3DES.Size = new System.Drawing.Size(142, 48);
            this.btn3DES.TabIndex = 24;
            this.btn3DES.Text = "TripleDES";
            this.btn3DES.UseVisualStyleBackColor = false;
            this.btn3DES.Visible = false;
            this.btn3DES.Click += new System.EventHandler(this.btn3DES_Click);
            // 
            // btnDES
            // 
            this.btnDES.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(60)))));
            this.btnDES.FlatAppearance.BorderSize = 0;
            this.btnDES.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDES.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDES.ForeColor = System.Drawing.Color.White;
            this.btnDES.Location = new System.Drawing.Point(862, 356);
            this.btnDES.Name = "btnDES";
            this.btnDES.Size = new System.Drawing.Size(142, 48);
            this.btnDES.TabIndex = 23;
            this.btnDES.Text = "DES";
            this.btnDES.UseVisualStyleBackColor = false;
            this.btnDES.Visible = false;
            this.btnDES.Click += new System.EventHandler(this.btnDES_Click);
            // 
            // SymmetricCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnAES);
            this.Controls.Add(this.btn3DES);
            this.Controls.Add(this.btnDES);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.bar3);
            this.Controls.Add(this.bar2);
            this.Controls.Add(this.bar1);
            this.Controls.Add(this.mainBar);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnOneTimePad);
            this.Controls.Add(this.btnVigenere);
            this.Controls.Add(this.btnCaesarCipher);
            this.Controls.Add(this.btnTransposition);
            this.Controls.Add(this.btnSubstitution);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnClassical);
            this.Controls.Add(this.labelHeading);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(163)))), ((int)(((byte)(217)))));
            this.Name = "SymmetricCategory";
            this.Size = new System.Drawing.Size(1220, 760);
            this.Load += new System.EventHandler(this.SymmetricCategory_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelHeading;
        private System.Windows.Forms.Button btnClassical;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSubstitution;
        private System.Windows.Forms.Button btnTransposition;
        private System.Windows.Forms.Button btnCaesarCipher;
        private System.Windows.Forms.Button btnVigenere;
        private System.Windows.Forms.Button btnOneTimePad;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel mainBar;
        private System.Windows.Forms.Panel bar1;
        private System.Windows.Forms.Panel bar2;
        private System.Windows.Forms.Panel bar3;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnAES;
        private System.Windows.Forms.Button btn3DES;
        private System.Windows.Forms.Button btnDES;
    }
}
