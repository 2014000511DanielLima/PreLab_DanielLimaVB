namespace PreLaboratorio_DanielLima_VB12
{
    partial class Credito
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Credito));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label1.Location = new Point(236, 19);
            label1.Name = "label1";
            label1.Size = new Size(317, 39);
            label1.TabIndex = 0;
            label1.Text = "PRE - LABORATORIO";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label2.Location = new Point(88, 75);
            label2.Name = "label2";
            label2.Size = new Size(573, 39);
            label2.TabIndex = 1;
            label2.Text = "DANIEL ESTUARDO LIMA HERNANDEZ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label3.Location = new Point(157, 133);
            label3.Name = "label3";
            label3.Size = new Size(438, 39);
            label3.TabIndex = 2;
            label3.Text = "V BACHILLERATO SECCION B";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label4.Location = new Point(637, 402);
            label4.Name = "label4";
            label4.Size = new Size(151, 39);
            label4.TabIndex = 3;
            label4.Text = "CLAVE 12";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 16.2F, FontStyle.Bold);
            label5.Location = new Point(12, 402);
            label5.Name = "label5";
            label5.Size = new Size(181, 39);
            label5.TabIndex = 4;
            label5.Text = "28/04/2025";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(336, 205);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(150, 200);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // Credito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Credito";
            Text = "Credito";
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
        private PictureBox pictureBox1;
    }
}