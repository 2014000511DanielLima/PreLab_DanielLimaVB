namespace PreLaboratorio_DanielLima_VB12
{
    partial class CRUD
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
            dataGridView1 = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            grado = new DataGridViewTextBoxColumn();
            seccion = new DataGridViewTextBoxColumn();
            nacimiento = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            direccion = new DataGridViewTextBoxColumn();
            matricula = new DataGridViewTextBoxColumn();
            correo = new DataGridViewTextBoxColumn();
            semestre = new DataGridViewTextBoxColumn();
            promedio = new DataGridViewTextBoxColumn();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label10 = new Label();
            label11 = new Label();
            textBox10 = new TextBox();
            textBox11 = new TextBox();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { codigo, nombre, apellido, grado, seccion, nacimiento, telefono, direccion, matricula, correo, semestre, promedio });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1547, 188);
            dataGridView1.TabIndex = 0;
            // 
            // codigo
            // 
            codigo.HeaderText = "Codigo";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            apellido.Width = 125;
            // 
            // grado
            // 
            grado.HeaderText = "Grado";
            grado.MinimumWidth = 6;
            grado.Name = "grado";
            grado.Width = 125;
            // 
            // seccion
            // 
            seccion.HeaderText = "Seccion";
            seccion.MinimumWidth = 6;
            seccion.Name = "seccion";
            seccion.Width = 125;
            // 
            // nacimiento
            // 
            nacimiento.HeaderText = "Nacimiento";
            nacimiento.MinimumWidth = 6;
            nacimiento.Name = "nacimiento";
            nacimiento.Width = 125;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.Width = 125;
            // 
            // direccion
            // 
            direccion.HeaderText = "Direccion";
            direccion.MinimumWidth = 6;
            direccion.Name = "direccion";
            direccion.Width = 125;
            // 
            // matricula
            // 
            matricula.HeaderText = "Matricula";
            matricula.MinimumWidth = 6;
            matricula.Name = "matricula";
            matricula.Width = 125;
            // 
            // correo
            // 
            correo.HeaderText = "Correo Electronico";
            correo.MinimumWidth = 6;
            correo.Name = "correo";
            correo.Width = 125;
            // 
            // semestre
            // 
            semestre.HeaderText = "Semestre";
            semestre.MinimumWidth = 6;
            semestre.Name = "semestre";
            semestre.Width = 125;
            // 
            // promedio
            // 
            promedio.HeaderText = "Promedio";
            promedio.MinimumWidth = 6;
            promedio.Name = "promedio";
            promedio.Width = 125;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button1.Location = new Point(21, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 1;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button2.Location = new Point(143, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 2;
            button2.Text = "Editar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Arial", 10.8F, FontStyle.Bold | FontStyle.Italic);
            button3.Location = new Point(267, 409);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 3;
            button3.Text = "Agregar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label1.Location = new Point(36, 240);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label2.Location = new Point(36, 289);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 5;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label3.Location = new Point(36, 343);
            label3.Name = "label3";
            label3.Size = new Size(63, 21);
            label3.TabIndex = 6;
            label3.Text = "Grado";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(121, 237);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(121, 286);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 8;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(121, 336);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 27);
            textBox3.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label4.Location = new Point(317, 237);
            label4.Name = "label4";
            label4.Size = new Size(80, 21);
            label4.TabIndex = 10;
            label4.Text = "Seccion";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label5.Location = new Point(317, 286);
            label5.Name = "label5";
            label5.Size = new Size(109, 21);
            label5.TabIndex = 11;
            label5.Text = "Nacimiento";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label6.Location = new Point(317, 343);
            label6.Name = "label6";
            label6.Size = new Size(86, 21);
            label6.TabIndex = 12;
            label6.Text = "Telefono";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(417, 237);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(163, 27);
            textBox4.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(417, 286);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(163, 27);
            textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(417, 336);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(163, 27);
            textBox6.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label7.Location = new Point(629, 240);
            label7.Name = "label7";
            label7.Size = new Size(93, 21);
            label7.TabIndex = 16;
            label7.Text = "Direccion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label8.Location = new Point(629, 286);
            label8.Name = "label8";
            label8.Size = new Size(89, 21);
            label8.TabIndex = 17;
            label8.Text = "Matricula";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label9.Location = new Point(629, 339);
            label9.Name = "label9";
            label9.Size = new Size(174, 21);
            label9.TabIndex = 18;
            label9.Text = "Correo Electronico";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(815, 235);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(164, 27);
            textBox7.TabIndex = 19;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(815, 280);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(164, 27);
            textBox8.TabIndex = 20;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(815, 338);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(164, 27);
            textBox9.TabIndex = 21;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label10.Location = new Point(1060, 260);
            label10.Name = "label10";
            label10.Size = new Size(95, 21);
            label10.TabIndex = 22;
            label10.Text = "Semestre";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 10.8F, FontStyle.Bold);
            label11.Location = new Point(1060, 324);
            label11.Name = "label11";
            label11.Size = new Size(95, 21);
            label11.TabIndex = 23;
            label11.Text = "Promedio";
            // 
            // textBox10
            // 
            textBox10.Location = new Point(1171, 260);
            textBox10.Name = "textBox10";
            textBox10.Size = new Size(158, 27);
            textBox10.TabIndex = 24;
            // 
            // textBox11
            // 
            textBox11.Location = new Point(1171, 317);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(158, 27);
            textBox11.TabIndex = 25;
            // 
            // button4
            // 
            button4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(403, 410);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 26;
            button4.Text = "Salir";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // CRUD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1571, 450);
            Controls.Add(button4);
            Controls.Add(textBox11);
            Controls.Add(textBox10);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "CRUD";
            Text = "CRUD";
            Load += CRUD_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn grado;
        private DataGridViewTextBoxColumn seccion;
        private DataGridViewTextBoxColumn nacimiento;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn direccion;
        private DataGridViewTextBoxColumn matricula;
        private DataGridViewTextBoxColumn correo;
        private DataGridViewTextBoxColumn semestre;
        private DataGridViewTextBoxColumn promedio;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox9;
        private Label label10;
        private Label label11;
        private TextBox textBox10;
        private TextBox textBox11;
        private Button button4;
    }
}