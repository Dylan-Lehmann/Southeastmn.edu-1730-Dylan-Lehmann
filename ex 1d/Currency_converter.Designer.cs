namespace ex_1d
{
    partial class Currency_converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Currency_converter));
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            pictureBox5 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBoxMexAmt = new TextBox();
            textBoxMexRte = new TextBox();
            textBoxMexUsd = new TextBox();
            textBoxArgAmt = new TextBox();
            textBoxArgRte = new TextBox();
            textBoxArgUsd = new TextBox();
            textBoxJapUsd = new TextBox();
            textBoxJapRte = new TextBox();
            textBoxJapAmt = new TextBox();
            textBoxBrzUsd = new TextBox();
            textBoxBrzRte = new TextBox();
            textBoxBrzAmt = new TextBox();
            textBoxUsd = new TextBox();
            buttonReset = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(75, 7);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(128, 121);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(209, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(137, 129);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(343, 7);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(144, 128);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(472, 7);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(137, 127);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(75, 131);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 5;
            label1.Text = "Mexican Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(209, 131);
            label2.Name = "label2";
            label2.Size = new Size(120, 20);
            label2.TabIndex = 6;
            label2.Text = "Argentinian Peso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(343, 131);
            label3.Name = "label3";
            label3.Size = new Size(99, 20);
            label3.TabIndex = 7;
            label3.Text = "Brazilian Real";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(472, 131);
            label4.Name = "label4";
            label4.Size = new Size(96, 20);
            label4.TabIndex = 8;
            label4.Text = "Japanese Yen";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(631, 7);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(132, 122);
            pictureBox5.TabIndex = 9;
            pictureBox5.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(631, 131);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 10;
            label5.Text = "U.S Dollar";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 173);
            label6.Name = "label6";
            label6.Size = new Size(65, 20);
            label6.TabIndex = 11;
            label6.Text = "Amount:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 212);
            label7.Name = "label7";
            label7.Size = new Size(42, 20);
            label7.TabIndex = 12;
            label7.Text = "Rate:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(35, 250);
            label8.Name = "label8";
            label8.Size = new Size(38, 20);
            label8.TabIndex = 13;
            label8.Text = "$US:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.Location = new Point(606, 250);
            label9.Name = "label9";
            label9.Size = new Size(22, 23);
            label9.TabIndex = 14;
            label9.Text = "=";
            // 
            // textBoxMexAmt
            // 
            textBoxMexAmt.Location = new Point(78, 170);
            textBoxMexAmt.Name = "textBoxMexAmt";
            textBoxMexAmt.Size = new Size(125, 27);
            textBoxMexAmt.TabIndex = 15;
            textBoxMexAmt.Text = "0.00";
            textBoxMexAmt.TextChanged += TextMexicoChanged;
            // 
            // textBoxMexRte
            // 
            textBoxMexRte.Location = new Point(78, 212);
            textBoxMexRte.Name = "textBoxMexRte";
            textBoxMexRte.Size = new Size(125, 27);
            textBoxMexRte.TabIndex = 16;
            textBoxMexRte.Text = "0.05432634";
            textBoxMexRte.TextChanged += TextMexicoChanged;
            // 
            // textBoxMexUsd
            // 
            textBoxMexUsd.Location = new Point(78, 250);
            textBoxMexUsd.Name = "textBoxMexUsd";
            textBoxMexUsd.ReadOnly = true;
            textBoxMexUsd.Size = new Size(125, 27);
            textBoxMexUsd.TabIndex = 17;
            textBoxMexUsd.Text = "0.00";
            // 
            // textBoxArgAmt
            // 
            textBoxArgAmt.Location = new Point(209, 170);
            textBoxArgAmt.Name = "textBoxArgAmt";
            textBoxArgAmt.Size = new Size(125, 27);
            textBoxArgAmt.TabIndex = 18;
            textBoxArgAmt.Text = "0.00";
            textBoxArgAmt.TextChanged += TextArgChanged;
            // 
            // textBoxArgRte
            // 
            textBoxArgRte.Location = new Point(209, 212);
            textBoxArgRte.Name = "textBoxArgRte";
            textBoxArgRte.Size = new Size(125, 27);
            textBoxArgRte.TabIndex = 19;
            textBoxArgRte.Text = "0.00067810043 ";
            textBoxArgRte.TextChanged += TextArgChanged;
            // 
            // textBoxArgUsd
            // 
            textBoxArgUsd.Location = new Point(209, 250);
            textBoxArgUsd.Name = "textBoxArgUsd";
            textBoxArgUsd.ReadOnly = true;
            textBoxArgUsd.Size = new Size(125, 27);
            textBoxArgUsd.TabIndex = 20;
            textBoxArgUsd.Text = "0.00";
            // 
            // textBoxJapUsd
            // 
            textBoxJapUsd.Location = new Point(474, 250);
            textBoxJapUsd.Name = "textBoxJapUsd";
            textBoxJapUsd.ReadOnly = true;
            textBoxJapUsd.Size = new Size(125, 27);
            textBoxJapUsd.TabIndex = 26;
            textBoxJapUsd.Text = "0.00";
            // 
            // textBoxJapRte
            // 
            textBoxJapRte.Location = new Point(474, 212);
            textBoxJapRte.Name = "textBoxJapRte";
            textBoxJapRte.Size = new Size(125, 27);
            textBoxJapRte.TabIndex = 25;
            textBoxJapRte.Text = "0.0067579979";
            // 
            // textBoxJapAmt
            // 
            textBoxJapAmt.Location = new Point(474, 170);
            textBoxJapAmt.Name = "textBoxJapAmt";
            textBoxJapAmt.Size = new Size(125, 27);
            textBoxJapAmt.TabIndex = 24;
            textBoxJapAmt.Text = "0.00";
            textBoxJapAmt.TextChanged += TextJapanChanged;
            // 
            // textBoxBrzUsd
            // 
            textBoxBrzUsd.Location = new Point(343, 250);
            textBoxBrzUsd.Name = "textBoxBrzUsd";
            textBoxBrzUsd.ReadOnly = true;
            textBoxBrzUsd.Size = new Size(125, 27);
            textBoxBrzUsd.TabIndex = 23;
            textBoxBrzUsd.Text = "0.00";
            // 
            // textBoxBrzRte
            // 
            textBoxBrzRte.Location = new Point(343, 212);
            textBoxBrzRte.Name = "textBoxBrzRte";
            textBoxBrzRte.Size = new Size(125, 27);
            textBoxBrzRte.TabIndex = 22;
            textBoxBrzRte.Text = "0.18793103";
            textBoxBrzRte.TextChanged += TextBrazilChanged;
            // 
            // textBoxBrzAmt
            // 
            textBoxBrzAmt.Location = new Point(343, 170);
            textBoxBrzAmt.Name = "textBoxBrzAmt";
            textBoxBrzAmt.Size = new Size(125, 27);
            textBoxBrzAmt.TabIndex = 21;
            textBoxBrzAmt.Text = "0.00";
            textBoxBrzAmt.TextChanged += TextBrazilChanged;
            // 
            // textBoxUsd
            // 
            textBoxUsd.Location = new Point(631, 250);
            textBoxUsd.Name = "textBoxUsd";
            textBoxUsd.Size = new Size(125, 27);
            textBoxUsd.TabIndex = 27;
            textBoxUsd.Text = "0.00";
            // 
            // buttonReset
            // 
            buttonReset.Location = new Point(235, 283);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(94, 29);
            buttonReset.TabIndex = 28;
            buttonReset.Text = "Reset";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // button1
            // 
            button1.Location = new Point(343, 283);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 29;
            button1.Text = "Exit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Currency_converter
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(775, 321);
            Controls.Add(button1);
            Controls.Add(buttonReset);
            Controls.Add(textBoxUsd);
            Controls.Add(textBoxJapUsd);
            Controls.Add(textBoxJapRte);
            Controls.Add(textBoxJapAmt);
            Controls.Add(textBoxBrzUsd);
            Controls.Add(textBoxBrzRte);
            Controls.Add(textBoxBrzAmt);
            Controls.Add(textBoxArgUsd);
            Controls.Add(textBoxArgRte);
            Controls.Add(textBoxArgAmt);
            Controls.Add(textBoxMexUsd);
            Controls.Add(textBoxMexRte);
            Controls.Add(textBoxMexAmt);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(pictureBox5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Name = "Currency_converter";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Currency_converter";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox5;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBoxMexAmt;
        private TextBox textBoxMexRte;
        private TextBox textBoxMexUsd;
        private TextBox textBoxArgAmt;
        private TextBox textBoxArgRte;
        private TextBox textBoxArgUsd;
        private TextBox textBoxJapUsd;
        private TextBox textBoxJapRte;
        private TextBox textBoxJapAmt;
        private TextBox textBoxBrzUsd;
        private TextBox textBoxBrzRte;
        private TextBox textBoxBrzAmt;
        private TextBox textBoxUsd;
        private Button buttonReset;
        private Button button1;
    }
}