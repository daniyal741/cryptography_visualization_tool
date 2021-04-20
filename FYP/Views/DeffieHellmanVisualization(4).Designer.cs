namespace FYP
{
    partial class DeffieHellmanVisualization_4_
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DeffieHellmanVisualization_4_));
            this.formula2 = new System.Windows.Forms.Label();
            this.formula = new System.Windows.Forms.Label();
            this.ycal = new System.Windows.Forms.TextBox();
            this.xcal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.YkeybOX = new System.Windows.Forms.TextBox();
            this.Xkey = new System.Windows.Forms.Label();
            this.Xkeybox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.q_number = new System.Windows.Forms.TextBox();
            this.p_number = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.forward = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.send = new System.Windows.Forms.Label();
            this.recieve = new System.Windows.Forms.Label();
            this.one = new System.Windows.Forms.Label();
            this.two = new System.Windows.Forms.Label();
            this.three = new System.Windows.Forms.Label();
            this.four = new System.Windows.Forms.Label();
            this.five = new System.Windows.Forms.Label();
            this.six = new System.Windows.Forms.Label();
            this.seven = new System.Windows.Forms.Label();
            this.rone = new System.Windows.Forms.Label();
            this.rtwo = new System.Windows.Forms.Label();
            this.rthree = new System.Windows.Forms.Label();
            this.rfour = new System.Windows.Forms.Label();
            this.rfive = new System.Windows.Forms.Label();
            this.rsix = new System.Windows.Forms.Label();
            this.rseven = new System.Windows.Forms.Label();
            this.exhchanged_label = new System.Windows.Forms.Label();
            this.backward = new System.Windows.Forms.Label();
            this.backwardPic = new System.Windows.Forms.PictureBox();
            this.arrowdown1 = new System.Windows.Forms.PictureBox();
            this.arowdown = new System.Windows.Forms.PictureBox();
            this.first = new System.Windows.Forms.PictureBox();
            this.second = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.forwardPic = new System.Windows.Forms.PictureBox();
            this.stop = new System.Windows.Forms.Button();
            this.start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.backwardPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowdown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.arowdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.first)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardPic)).BeginInit();
            this.SuspendLayout();
            // 
            // formula2
            // 
            this.formula2.AutoSize = true;
            this.formula2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formula2.ForeColor = System.Drawing.Color.White;
            this.formula2.Location = new System.Drawing.Point(897, 421);
            this.formula2.Name = "formula2";
            this.formula2.Size = new System.Drawing.Size(224, 30);
            this.formula2.TabIndex = 143;
            this.formula2.Text = "B = Q pow(Y)  Mod P\r\n";
            // 
            // formula
            // 
            this.formula.AutoSize = true;
            this.formula.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formula.ForeColor = System.Drawing.Color.White;
            this.formula.Location = new System.Drawing.Point(108, 421);
            this.formula.Name = "formula";
            this.formula.Size = new System.Drawing.Size(225, 30);
            this.formula.TabIndex = 141;
            this.formula.Text = "A = Q pow(x)  Mod P\r\n";
            this.formula.Click += new System.EventHandler(this.label7_Click);
            // 
            // ycal
            // 
            this.ycal.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ycal.Location = new System.Drawing.Point(754, 530);
            this.ycal.Multiline = true;
            this.ycal.Name = "ycal";
            this.ycal.ReadOnly = true;
            this.ycal.Size = new System.Drawing.Size(393, 73);
            this.ycal.TabIndex = 140;
            this.ycal.TextChanged += new System.EventHandler(this.ycal_TextChanged);
            // 
            // xcal
            // 
            this.xcal.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xcal.Location = new System.Drawing.Point(89, 530);
            this.xcal.Multiline = true;
            this.xcal.Name = "xcal";
            this.xcal.ReadOnly = true;
            this.xcal.Size = new System.Drawing.Size(401, 73);
            this.xcal.TabIndex = 139;
            this.xcal.TextChanged += new System.EventHandler(this.xcal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(868, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 50);
            this.label6.TabIndex = 136;
            this.label6.Text = "Private Key.\r\n              Y=";
            // 
            // YkeybOX
            // 
            this.YkeybOX.Enabled = false;
            this.YkeybOX.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YkeybOX.Location = new System.Drawing.Point(979, 304);
            this.YkeybOX.Multiline = true;
            this.YkeybOX.Name = "YkeybOX";
            this.YkeybOX.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.YkeybOX.Size = new System.Drawing.Size(69, 40);
            this.YkeybOX.TabIndex = 135;
            // 
            // Xkey
            // 
            this.Xkey.AutoSize = true;
            this.Xkey.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xkey.ForeColor = System.Drawing.Color.White;
            this.Xkey.Location = new System.Drawing.Point(93, 302);
            this.Xkey.Name = "Xkey";
            this.Xkey.Size = new System.Drawing.Size(115, 50);
            this.Xkey.TabIndex = 134;
            this.Xkey.Text = "Private Key.\r\n              X =";
            // 
            // Xkeybox
            // 
            this.Xkeybox.Enabled = false;
            this.Xkeybox.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Xkeybox.Location = new System.Drawing.Point(204, 302);
            this.Xkeybox.Multiline = true;
            this.Xkeybox.Name = "Xkeybox";
            this.Xkeybox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Xkeybox.Size = new System.Drawing.Size(69, 43);
            this.Xkeybox.TabIndex = 133;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(984, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 25);
            this.label3.TabIndex = 130;
            this.label3.Text = "BoB";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(197, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 25);
            this.label2.TabIndex = 129;
            this.label2.Text = "Alexa";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(656, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 30);
            this.label5.TabIndex = 124;
            this.label5.Text = "Q -->";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(382, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 30);
            this.label4.TabIndex = 123;
            this.label4.Text = "P -->";
            // 
            // q_number
            // 
            this.q_number.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.q_number.Location = new System.Drawing.Point(735, 177);
            this.q_number.Multiline = true;
            this.q_number.Name = "q_number";
            this.q_number.ReadOnly = true;
            this.q_number.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.q_number.Size = new System.Drawing.Size(117, 43);
            this.q_number.TabIndex = 122;
            // 
            // p_number
            // 
            this.p_number.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p_number.Location = new System.Drawing.Point(451, 177);
            this.p_number.Multiline = true;
            this.p_number.Name = "p_number";
            this.p_number.ReadOnly = true;
            this.p_number.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.p_number.Size = new System.Drawing.Size(127, 43);
            this.p_number.TabIndex = 121;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(369, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 30);
            this.label1.TabIndex = 120;
            this.label1.Text = "Here we have to generate two numbers P  and  Q.\r\n";
            // 
            // forward
            // 
            this.forward.AutoSize = true;
            this.forward.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forward.ForeColor = System.Drawing.Color.White;
            this.forward.Location = new System.Drawing.Point(513, 505);
            this.forward.Name = "forward";
            this.forward.Size = new System.Drawing.Size(86, 25);
            this.forward.TabIndex = 148;
            this.forward.Text = "Sending";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // send
            // 
            this.send.AutoSize = true;
            this.send.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.Location = new System.Drawing.Point(640, 505);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(21, 25);
            this.send.TabIndex = 152;
            this.send.Text = "*";
            // 
            // recieve
            // 
            this.recieve.AutoSize = true;
            this.recieve.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recieve.ForeColor = System.Drawing.Color.White;
            this.recieve.Location = new System.Drawing.Point(584, 603);
            this.recieve.Name = "recieve";
            this.recieve.Size = new System.Drawing.Size(21, 25);
            this.recieve.TabIndex = 153;
            this.recieve.Text = "*";
            // 
            // one
            // 
            this.one.AutoSize = true;
            this.one.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.one.ForeColor = System.Drawing.Color.Red;
            this.one.Location = new System.Drawing.Point(414, 491);
            this.one.Name = "one";
            this.one.Size = new System.Drawing.Size(26, 32);
            this.one.TabIndex = 156;
            this.one.Text = "*";
            // 
            // two
            // 
            this.two.AutoSize = true;
            this.two.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.two.ForeColor = System.Drawing.Color.Red;
            this.two.Location = new System.Drawing.Point(481, 462);
            this.two.Name = "two";
            this.two.Size = new System.Drawing.Size(26, 32);
            this.two.TabIndex = 157;
            this.two.Text = "*";
            // 
            // three
            // 
            this.three.AutoSize = true;
            this.three.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.three.ForeColor = System.Drawing.Color.Red;
            this.three.Location = new System.Drawing.Point(532, 440);
            this.three.Name = "three";
            this.three.Size = new System.Drawing.Size(26, 32);
            this.three.TabIndex = 158;
            this.three.Text = "*";
            // 
            // four
            // 
            this.four.AutoSize = true;
            this.four.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.four.ForeColor = System.Drawing.Color.Red;
            this.four.Location = new System.Drawing.Point(596, 430);
            this.four.Name = "four";
            this.four.Size = new System.Drawing.Size(26, 32);
            this.four.TabIndex = 159;
            this.four.Text = "*";
            // 
            // five
            // 
            this.five.AutoSize = true;
            this.five.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.five.ForeColor = System.Drawing.Color.Red;
            this.five.Location = new System.Drawing.Point(664, 440);
            this.five.Name = "five";
            this.five.Size = new System.Drawing.Size(26, 32);
            this.five.TabIndex = 160;
            this.five.Text = "*";
            // 
            // six
            // 
            this.six.AutoSize = true;
            this.six.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.six.ForeColor = System.Drawing.Color.Red;
            this.six.Location = new System.Drawing.Point(729, 462);
            this.six.Name = "six";
            this.six.Size = new System.Drawing.Size(26, 32);
            this.six.TabIndex = 161;
            this.six.Text = "*";
            // 
            // seven
            // 
            this.seven.AutoSize = true;
            this.seven.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seven.ForeColor = System.Drawing.Color.Red;
            this.seven.Location = new System.Drawing.Point(784, 491);
            this.seven.Name = "seven";
            this.seven.Size = new System.Drawing.Size(26, 32);
            this.seven.TabIndex = 162;
            this.seven.Text = "*";
            // 
            // rone
            // 
            this.rone.AutoSize = true;
            this.rone.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rone.ForeColor = System.Drawing.Color.Blue;
            this.rone.Location = new System.Drawing.Point(784, 606);
            this.rone.Name = "rone";
            this.rone.Size = new System.Drawing.Size(26, 32);
            this.rone.TabIndex = 163;
            this.rone.Text = "*";
            // 
            // rtwo
            // 
            this.rtwo.AutoSize = true;
            this.rtwo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtwo.ForeColor = System.Drawing.Color.Blue;
            this.rtwo.Location = new System.Drawing.Point(729, 638);
            this.rtwo.Name = "rtwo";
            this.rtwo.Size = new System.Drawing.Size(26, 32);
            this.rtwo.TabIndex = 164;
            this.rtwo.Text = "*";
            // 
            // rthree
            // 
            this.rthree.AutoSize = true;
            this.rthree.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rthree.ForeColor = System.Drawing.Color.Blue;
            this.rthree.Location = new System.Drawing.Point(664, 650);
            this.rthree.Name = "rthree";
            this.rthree.Size = new System.Drawing.Size(26, 32);
            this.rthree.TabIndex = 165;
            this.rthree.Text = "*";
            // 
            // rfour
            // 
            this.rfour.AutoSize = true;
            this.rfour.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfour.ForeColor = System.Drawing.Color.Blue;
            this.rfour.Location = new System.Drawing.Point(596, 658);
            this.rfour.Name = "rfour";
            this.rfour.Size = new System.Drawing.Size(26, 32);
            this.rfour.TabIndex = 166;
            this.rfour.Text = "*";
            // 
            // rfive
            // 
            this.rfive.AutoSize = true;
            this.rfive.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rfive.ForeColor = System.Drawing.Color.Blue;
            this.rfive.Location = new System.Drawing.Point(532, 650);
            this.rfive.Name = "rfive";
            this.rfive.Size = new System.Drawing.Size(26, 32);
            this.rfive.TabIndex = 167;
            this.rfive.Text = "*";
            // 
            // rsix
            // 
            this.rsix.AutoSize = true;
            this.rsix.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsix.ForeColor = System.Drawing.Color.Blue;
            this.rsix.Location = new System.Drawing.Point(481, 638);
            this.rsix.Name = "rsix";
            this.rsix.Size = new System.Drawing.Size(26, 32);
            this.rsix.TabIndex = 168;
            this.rsix.Text = "*";
            // 
            // rseven
            // 
            this.rseven.AutoSize = true;
            this.rseven.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rseven.ForeColor = System.Drawing.Color.Blue;
            this.rseven.Location = new System.Drawing.Point(419, 603);
            this.rseven.Name = "rseven";
            this.rseven.Size = new System.Drawing.Size(26, 32);
            this.rseven.TabIndex = 169;
            this.rseven.Text = "*";
            // 
            // exhchanged_label
            // 
            this.exhchanged_label.AutoSize = true;
            this.exhchanged_label.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exhchanged_label.ForeColor = System.Drawing.Color.White;
            this.exhchanged_label.Location = new System.Drawing.Point(482, 373);
            this.exhchanged_label.Name = "exhchanged_label";
            this.exhchanged_label.Size = new System.Drawing.Size(278, 30);
            this.exhchanged_label.TabIndex = 174;
            this.exhchanged_label.Text = "Public Keys Are Exchanged";
            // 
            // backward
            // 
            this.backward.AutoSize = true;
            this.backward.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backward.ForeColor = System.Drawing.Color.White;
            this.backward.Location = new System.Drawing.Point(652, 603);
            this.backward.Name = "backward";
            this.backward.Size = new System.Drawing.Size(86, 25);
            this.backward.TabIndex = 175;
            this.backward.Text = "Sending";
            this.backward.Click += new System.EventHandler(this.backward_Click);
            // 
            // backwardPic
            // 
            this.backwardPic.Image = ((System.Drawing.Image)(resources.GetObject("backwardPic.Image")));
            this.backwardPic.Location = new System.Drawing.Point(522, 561);
            this.backwardPic.Name = "backwardPic";
            this.backwardPic.Size = new System.Drawing.Size(220, 74);
            this.backwardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.backwardPic.TabIndex = 147;
            this.backwardPic.TabStop = false;
            // 
            // arrowdown1
            // 
            this.arrowdown1.Image = ((System.Drawing.Image)(resources.GetObject("arrowdown1.Image")));
            this.arrowdown1.Location = new System.Drawing.Point(985, 462);
            this.arrowdown1.Name = "arrowdown1";
            this.arrowdown1.Size = new System.Drawing.Size(69, 68);
            this.arrowdown1.TabIndex = 144;
            this.arrowdown1.TabStop = false;
            // 
            // arowdown
            // 
            this.arowdown.Image = ((System.Drawing.Image)(resources.GetObject("arowdown.Image")));
            this.arowdown.Location = new System.Drawing.Point(204, 462);
            this.arowdown.Name = "arowdown";
            this.arowdown.Size = new System.Drawing.Size(58, 68);
            this.arowdown.TabIndex = 142;
            this.arowdown.TabStop = false;
            // 
            // first
            // 
            this.first.Image = ((System.Drawing.Image)(resources.GetObject("first.Image")));
            this.first.Location = new System.Drawing.Point(204, 350);
            this.first.Name = "first";
            this.first.Size = new System.Drawing.Size(69, 68);
            this.first.TabIndex = 138;
            this.first.TabStop = false;
            // 
            // second
            // 
            this.second.Image = ((System.Drawing.Image)(resources.GetObject("second.Image")));
            this.second.Location = new System.Drawing.Point(985, 350);
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(69, 65);
            this.second.TabIndex = 137;
            this.second.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(980, 224);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(69, 71);
            this.pictureBox4.TabIndex = 132;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(204, 224);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(69, 71);
            this.pictureBox3.TabIndex = 131;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(947, 82);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 134);
            this.pictureBox2.TabIndex = 128;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(169, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 136);
            this.pictureBox1.TabIndex = 127;
            this.pictureBox1.TabStop = false;
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
            this.btnClose.TabIndex = 119;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBack.BackgroundImage")));
            this.btnBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(215)))), ((int)(((byte)(15)))));
            this.btnBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(160)))), ((int)(((byte)(174)))));
            this.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBack.Location = new System.Drawing.Point(3, 3);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(28, 30);
            this.btnBack.TabIndex = 118;
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // forwardPic
            // 
            this.forwardPic.Image = ((System.Drawing.Image)(resources.GetObject("forwardPic.Image")));
            this.forwardPic.Location = new System.Drawing.Point(518, 504);
            this.forwardPic.Name = "forwardPic";
            this.forwardPic.Size = new System.Drawing.Size(220, 69);
            this.forwardPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.forwardPic.TabIndex = 146;
            this.forwardPic.TabStop = false;
            // 
            // stop
            // 
            this.stop.BackColor = System.Drawing.Color.WhiteSmoke;
            this.stop.FlatAppearance.BorderSize = 0;
            this.stop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stop.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stop.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.stop.Image = ((System.Drawing.Image)(resources.GetObject("stop.Image")));
            this.stop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.stop.Location = new System.Drawing.Point(538, 697);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(159, 48);
            this.stop.TabIndex = 155;
            this.stop.Text = "Pause";
            this.stop.UseVisualStyleBackColor = false;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // start
            // 
            this.start.BackColor = System.Drawing.Color.WhiteSmoke;
            this.start.FlatAppearance.BorderSize = 0;
            this.start.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(45)))), ((int)(((byte)(49)))));
            this.start.Image = ((System.Drawing.Image)(resources.GetObject("start.Image")));
            this.start.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.start.Location = new System.Drawing.Point(538, 697);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(159, 48);
            this.start.TabIndex = 154;
            this.start.Text = "  Resume";
            this.start.UseVisualStyleBackColor = false;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // DeffieHellmanVisualization_4_
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.backward);
            this.Controls.Add(this.exhchanged_label);
            this.Controls.Add(this.rseven);
            this.Controls.Add(this.rsix);
            this.Controls.Add(this.rfive);
            this.Controls.Add(this.rfour);
            this.Controls.Add(this.rthree);
            this.Controls.Add(this.rtwo);
            this.Controls.Add(this.rone);
            this.Controls.Add(this.seven);
            this.Controls.Add(this.six);
            this.Controls.Add(this.five);
            this.Controls.Add(this.four);
            this.Controls.Add(this.three);
            this.Controls.Add(this.two);
            this.Controls.Add(this.one);
            this.Controls.Add(this.recieve);
            this.Controls.Add(this.send);
            this.Controls.Add(this.forward);
            this.Controls.Add(this.backwardPic);
            this.Controls.Add(this.arrowdown1);
            this.Controls.Add(this.formula2);
            this.Controls.Add(this.arowdown);
            this.Controls.Add(this.formula);
            this.Controls.Add(this.ycal);
            this.Controls.Add(this.xcal);
            this.Controls.Add(this.first);
            this.Controls.Add(this.second);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.YkeybOX);
            this.Controls.Add(this.Xkey);
            this.Controls.Add(this.Xkeybox);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.q_number);
            this.Controls.Add(this.p_number);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.forwardPic);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.start);
            this.Name = "DeffieHellmanVisualization_4_";
            this.Size = new System.Drawing.Size(1220, 760);
            this.Load += new System.EventHandler(this.DeffieHellmanVisualization_4__Load);
            ((System.ComponentModel.ISupportInitialize)(this.backwardPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arrowdown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.arowdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.first)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.second)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.forwardPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox arrowdown1;
        private System.Windows.Forms.Label formula2;
        private System.Windows.Forms.PictureBox arowdown;
        private System.Windows.Forms.Label formula;
        private System.Windows.Forms.TextBox ycal;
        private System.Windows.Forms.TextBox xcal;
        private System.Windows.Forms.PictureBox first;
        private System.Windows.Forms.PictureBox second;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox YkeybOX;
        private System.Windows.Forms.Label Xkey;
        private System.Windows.Forms.TextBox Xkeybox;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox q_number;
        private System.Windows.Forms.TextBox p_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.PictureBox forwardPic;
        private System.Windows.Forms.PictureBox backwardPic;
        private System.Windows.Forms.Label forward;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label send;
        private System.Windows.Forms.Label recieve;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label one;
        private System.Windows.Forms.Label two;
        private System.Windows.Forms.Label three;
        private System.Windows.Forms.Label four;
        private System.Windows.Forms.Label five;
        private System.Windows.Forms.Label six;
        private System.Windows.Forms.Label seven;
        private System.Windows.Forms.Label rone;
        private System.Windows.Forms.Label rtwo;
        private System.Windows.Forms.Label rthree;
        private System.Windows.Forms.Label rfour;
        private System.Windows.Forms.Label rfive;
        private System.Windows.Forms.Label rsix;
        private System.Windows.Forms.Label rseven;
        private System.Windows.Forms.Label exhchanged_label;
        private System.Windows.Forms.Label backward;
    }
}
