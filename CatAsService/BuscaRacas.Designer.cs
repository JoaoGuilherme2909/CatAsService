namespace CatAsService
{
    partial class BuscaRacas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscaRacas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox1 = new PictureBox();
            comboBox1 = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 12);
            label1.Name = "label1";
            label1.Size = new Size(232, 24);
            label1.TabIndex = 0;
            label1.Text = "Encontre sua raça favorita";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(31, 46);
            label2.Name = "label2";
            label2.Size = new Size(463, 36);
            label2.TabIndex = 1;
            label2.Text = "Utilize a caixa de seleção para obter informações sobre determinado gatinho \r\ne descobrir qual a sua raça favorita.\r\n";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(12, 91);
            label3.Name = "label3";
            label3.Size = new Size(589, 2);
            label3.TabIndex = 2;
            label3.Text = "label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 114);
            label4.Name = "label4";
            label4.Size = new Size(77, 15);
            label4.TabIndex = 3;
            label4.Text = "Raça do Gato";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 153);
            label5.Name = "label5";
            label5.Size = new Size(87, 15);
            label5.TabIndex = 4;
            label5.Text = "Temperamento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 182);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 5;
            label6.Text = "Origem";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 213);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 6;
            label7.Text = "Descrição";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Location = new Point(3, 261);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(396, 243);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "pelo curto inglês", "Maine coon" });
            comboBox1.Location = new Point(108, 111);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(137, 23);
            comboBox1.TabIndex = 8;
            comboBox1.Text = "Selecione uma raça";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(108, 153);
            label8.Name = "label8";
            label8.Size = new Size(59, 15);
            label8.TabIndex = 9;
            label8.Text = "Resultado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(108, 182);
            label9.Name = "label9";
            label9.Size = new Size(59, 15);
            label9.TabIndex = 10;
            label9.Text = "Resultado";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.FlatStyle = FlatStyle.System;
            label10.Location = new Point(108, 213);
            label10.MaximumSize = new Size(550, 0);
            label10.Name = "label10";
            label10.Size = new Size(59, 45);
            label10.TabIndex = 11;
            label10.Text = "Resultado\r\n\r\n";
            // 
            // button1
            // 
            button1.Location = new Point(351, 510);
            button1.Name = "button1";
            button1.Size = new Size(122, 22);
            button1.TabIndex = 12;
            button1.Text = "Buscar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(479, 510);
            button2.Name = "button2";
            button2.Size = new Size(122, 22);
            button2.TabIndex = 13;
            button2.Text = "Favoritar";
            button2.UseVisualStyleBackColor = true;
            // 
            // BuscaRacas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 544);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(comboBox1);
            Controls.Add(pictureBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BuscaRacas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Raças";
            Load += BuscaRacas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label8;
        private Label label9;
        private Label label10;
        private Button button1;
        private Button button2;
    }
}