namespace CatAsService
{
    partial class BuscarRacasFavoritas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuscarRacasFavoritas));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            listBox1 = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Trebuchet MS", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(135, 24);
            label1.TabIndex = 0;
            label1.Text = "Meus Favoritos";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Trebuchet MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 42);
            label2.Name = "label2";
            label2.Size = new Size(289, 18);
            label2.TabIndex = 1;
            label2.Text = "Aqui você encontra a lista de gatinhos favoritos";
            // 
            // label3
            // 
            label3.BorderStyle = BorderStyle.Fixed3D;
            label3.Location = new Point(12, 75);
            label3.Name = "label3";
            label3.Size = new Size(401, 2);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(71, 111);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(273, 289);
            listBox1.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(302, 413);
            button1.Name = "button1";
            button1.Size = new Size(111, 25);
            button1.TabIndex = 4;
            button1.Text = "Excluir favorito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // BuscarRacasFavoritas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(425, 450);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "BuscarRacasFavoritas";
            Text = "Buscar Raças Favoritas";
            Load += BuscarRacasFavoritas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ListBox listBox1;
        private Button button1;
    }
}