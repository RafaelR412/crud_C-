namespace CRUDCSharpSQLServer
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
            txtEdad = new TextBox();
            txtApellidos = new TextBox();
            txtNombres = new TextBox();
            txtDNI = new TextBox();
            txtID = new TextBox();
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
            groupBox1.Controls.Add(txtEdad);
            groupBox1.Controls.Add(txtApellidos);
            groupBox1.Controls.Add(txtNombres);
            groupBox1.Controls.Add(txtDNI);
            groupBox1.Controls.Add(txtID);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 23);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(236, 278);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Alumnos";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(125, 235);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(105, 24);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(6, 235);
            btnEditar.Name = "btnEditar";
            btnEditar.RightToLeft = RightToLeft.No;
            btnEditar.Size = new Size(113, 24);
            btnEditar.TabIndex = 11;
            btnEditar.Text = "Modificar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += button2_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(6, 199);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(224, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(82, 163);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(148, 23);
            txtEdad.TabIndex = 9;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(82, 130);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(148, 23);
            txtApellidos.TabIndex = 8;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(82, 97);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(148, 23);
            txtNombres.TabIndex = 7;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(82, 67);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(148, 23);
            txtDNI.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(82, 38);
            txtID.Name = "txtID";
            txtID.Size = new Size(148, 23);
            txtID.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 171);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 138);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 105);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombres:";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 76);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 46);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Location = new Point(254, 23);
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.Size = new Size(524, 278);
            dgvAlumnos.TabIndex = 1;
            dgvAlumnos.CellContentClick += dataGridView1_CellContentClick;
            dgvAlumnos.CellMouseClick += dgvAlumnos_CellMouseClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(787, 315);
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
        private TextBox txtDNI;
        private TextBox txtID;
        private TextBox txtEdad;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private Button btnEliminar;
        private Button btnEditar;
        private Button btnGuardar;
    }
}
