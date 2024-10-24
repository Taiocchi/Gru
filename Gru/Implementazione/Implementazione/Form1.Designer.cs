namespace Implementazione
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
            Alza = new Button();
            Abbassa = new Button();
            Posizione_Sicurezza = new Button();
            label1 = new Label();
            label2 = new Label();
            Applica = new Button();
            Altezza_Minima = new TextBox();
            Altezza_Massima = new TextBox();
            Braccio = new PictureBox();
            Gancio = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)Braccio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Gancio).BeginInit();
            SuspendLayout();
            // 
            // Alza
            // 
            Alza.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Alza.Location = new Point(70, 368);
            Alza.Name = "Alza";
            Alza.Size = new Size(73, 102);
            Alza.TabIndex = 0;
            Alza.Text = "⇧";
            Alza.UseVisualStyleBackColor = true;
            Alza.Click += Alza_Click;
            // 
            // Abbassa
            // 
            Abbassa.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Abbassa.Location = new Point(70, 501);
            Abbassa.Name = "Abbassa";
            Abbassa.Size = new Size(73, 102);
            Abbassa.TabIndex = 1;
            Abbassa.Text = "⇩";
            Abbassa.UseVisualStyleBackColor = true;
            Abbassa.Click += Abbassa_Click;
            // 
            // Posizione_Sicurezza
            // 
            Posizione_Sicurezza.BackColor = Color.Red;
            Posizione_Sicurezza.Font = new Font("Segoe UI", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Posizione_Sicurezza.Location = new Point(211, 441);
            Posizione_Sicurezza.Name = "Posizione_Sicurezza";
            Posizione_Sicurezza.Size = new Size(151, 76);
            Posizione_Sicurezza.TabIndex = 2;
            Posizione_Sicurezza.Text = "STOP";
            Posizione_Sicurezza.UseVisualStyleBackColor = false;
            Posizione_Sicurezza.Click += Posizione_Sicurezza_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(52, 47);
            label1.Name = "label1";
            label1.Size = new Size(252, 30);
            label1.TabIndex = 3;
            label1.Text = "Altezza_Minima (280-530)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(52, 157);
            label2.Name = "label2";
            label2.Size = new Size(264, 30);
            label2.TabIndex = 4;
            label2.Text = "Altezza_Massima (280-530)";
            // 
            // Applica
            // 
            Applica.BackColor = Color.LawnGreen;
            Applica.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Applica.Location = new Point(354, 109);
            Applica.Name = "Applica";
            Applica.Size = new Size(119, 43);
            Applica.TabIndex = 5;
            Applica.Text = "APPLICA";
            Applica.UseVisualStyleBackColor = false;
            Applica.Click += Applica_Click;
            // 
            // Altezza_Minima
            // 
            Altezza_Minima.Location = new Point(52, 80);
            Altezza_Minima.Name = "Altezza_Minima";
            Altezza_Minima.Size = new Size(252, 23);
            Altezza_Minima.TabIndex = 6;
            // 
            // Altezza_Massima
            // 
            Altezza_Massima.Location = new Point(52, 190);
            Altezza_Massima.Name = "Altezza_Massima";
            Altezza_Massima.Size = new Size(252, 23);
            Altezza_Massima.TabIndex = 7;
            // 
            // Braccio
            // 
            Braccio.Image = Properties.Resources.images;
            Braccio.Location = new Point(711, 105);
            Braccio.Name = "Braccio";
            Braccio.Size = new Size(371, 388);
            Braccio.TabIndex = 8;
            Braccio.TabStop = false;
            // 
            // Gancio
            // 
            Gancio.Image = Properties.Resources.image_2;
            Gancio.Location = new Point(952, 170);
            Gancio.Name = "Gancio";
            Gancio.Size = new Size(100, 50);
            Gancio.TabIndex = 9;
            Gancio.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 661);
            Controls.Add(Gancio);
            Controls.Add(Braccio);
            Controls.Add(Altezza_Massima);
            Controls.Add(Altezza_Minima);
            Controls.Add(Applica);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Posizione_Sicurezza);
            Controls.Add(Abbassa);
            Controls.Add(Alza);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)Braccio).EndInit();
            ((System.ComponentModel.ISupportInitialize)Gancio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Alza;
        private Button Abbassa;
        private Button Posizione_Sicurezza;
        private Label label1;
        private Label label2;
        private Button Applica;
        private TextBox Altezza_Minima;
        private TextBox Altezza_Massima;
        private PictureBox Braccio;
        private PictureBox Gancio;
    }
}
