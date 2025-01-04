namespace CRUDCsharpSQLServer
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
            groupBox1 = new GroupBox();
            btnEliminar = new Button();
            btnEditar = new Button();
            btnGuardar = new Button();
            txtNombres = new TextBox();
            txtEdad = new TextBox();
            txtApellidos = new TextBox();
            txtDNI = new TextBox();
            TxtID = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dgvAlumnos = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnEditar);
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(TxtID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(217, 283);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Alumnos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(107, 244);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(91, 24);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "ELIMINAR";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(6, 244);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(95, 24);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "MODIFICAR";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(6, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(192, 23);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += button1_Click;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(88, 107);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(110, 23);
            txtNombres.TabIndex = 9;
            txtNombres.TextChanged += textBox5_TextChanged;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(88, 186);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(110, 23);
            txtEdad.TabIndex = 8;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(88, 146);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(110, 23);
            txtApellidos.TabIndex = 7;
            txtApellidos.TextChanged += textBox3_TextChanged;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(88, 70);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(110, 23);
            txtDNI.TabIndex = 6;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(88, 31);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(110, 23);
            TxtID.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 186);
            label5.Name = "label5";
            label5.Size = new Size(33, 15);
            label5.TabIndex = 4;
            label5.Text = "Edad";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 146);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellidos";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 107);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombres";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 70);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 31);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 0;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(255, 12);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(466, 283);
            dgvAlumnos.TabIndex = 1;
            dgvAlumnos.CellContentClick += dgvAlumnos_CellContentClick;
            dgvAlumnos.CellMouseClick += dgvAlumnos_CellMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(760, 336);
            Controls.Add(dgvAlumnos);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView dgvAlumnos;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEdad;
        private TextBox txtApellidos;
        private TextBox txtDNI;
        private TextBox TxtID;
        private TextBox txtNombres;
        private Button btnGuardar;
        private Button btnEliminar;
        private Button btnEditar;
    }
}
