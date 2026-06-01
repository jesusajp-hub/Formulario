namespace Formulario
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            pictureBox1 = new PictureBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            comboBox1 = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            comboBox2 = new ComboBox();
            label13 = new Label();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label14 = new Label();
            textBox6 = new TextBox();
            label15 = new Label();
            textBox7 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 42);
            label1.Name = "label1";
            label1.Size = new Size(104, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo de usuario";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descarga;
            pictureBox1.Location = new Point(30, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(204, 235);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(407, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(309, 85);
            label2.Name = "label2";
            label2.Size = new Size(92, 15);
            label2.TabIndex = 3;
            label2.Text = "Nivel de usuario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(498, 125);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 5;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(407, 68);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(101, 19);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "Administrador";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += this.radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(407, 93);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(65, 19);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "Usuario";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(334, 125);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 8;
            label3.Text = "Contraseña";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(408, 125);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(408, 154);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(280, 157);
            label5.Name = "label5";
            label5.Size = new Size(122, 15);
            label5.TabIndex = 11;
            label5.Text = "Confirmar contraseña";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(498, 154);
            label6.Name = "label6";
            label6.Size = new Size(0, 15);
            label6.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 278);
            label7.Name = "label7";
            label7.Size = new Size(51, 15);
            label7.TabIndex = 13;
            label7.Text = "Nombre";
            label7.Click += label7_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 316);
            label8.Name = "label8";
            label8.Size = new Size(51, 15);
            label8.TabIndex = 14;
            label8.Text = "Apellido";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(69, 275);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(509, 23);
            textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(69, 313);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(509, 23);
            textBox5.TabIndex = 16;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 342);
            label9.Name = "label9";
            label9.Size = new Size(46, 15);
            label9.TabIndex = 17;
            label9.Text = "Tipo de";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(5, 357);
            label10.Name = "label10";
            label10.Size = new Size(70, 15);
            label10.TabIndex = 18;
            label10.Text = "Documento";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(81, 342);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 19;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(244, 345);
            label11.Name = "label11";
            label11.Size = new Size(40, 15);
            label11.TabIndex = 20;
            label11.Text = "N° de ";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(244, 360);
            label12.Name = "label12";
            label12.Size = new Size(70, 15);
            label12.TabIndex = 21;
            label12.Text = "Documento";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(320, 345);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 22;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(31, 391);
            label13.Name = "label13";
            label13.Size = new Size(32, 15);
            label13.TabIndex = 23;
            label13.Text = "Sexo";
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(79, 389);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(80, 19);
            radioButton3.TabIndex = 24;
            radioButton3.TabStop = true;
            radioButton3.Text = "Masculino";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(190, 388);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(78, 19);
            radioButton4.TabIndex = 25;
            radioButton4.TabStop = true;
            radioButton4.Text = "Femenino";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(12, 439);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 26;
            label14.Text = "Telefono";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(69, 436);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 27;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(18, 476);
            label15.Name = "label15";
            label15.Size = new Size(41, 15);
            label15.TabIndex = 28;
            label15.Text = "E-Mail";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(69, 473);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(509, 23);
            textBox7.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 666);
            Controls.Add(textBox7);
            Controls.Add(label15);
            Controls.Add(textBox6);
            Controls.Add(label14);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(label13);
            Controls.Add(comboBox2);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(comboBox1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += this.Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label4;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox4;
        private TextBox textBox5;
        private Label label9;
        private Label label10;
        private ComboBox comboBox1;
        private Label label11;
        private Label label12;
        private ComboBox comboBox2;
        private Label label13;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label14;
        private TextBox textBox6;
        private Label label15;
        private TextBox textBox7;
    }
}
