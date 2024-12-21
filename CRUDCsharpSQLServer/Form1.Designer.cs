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
            btnModificar = new Button();
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
            RegistroD = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroD).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnEliminar);
            groupBox1.Controls.Add(btnModificar);
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
            groupBox1.ForeColor = SystemColors.ControlText;
            groupBox1.Location = new Point(22, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(225, 285);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Alumnos";
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = SystemColors.ActiveCaption;
            btnEliminar.Location = new Point(116, 251);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 25);
            btnEliminar.TabIndex = 12;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            btnModificar.BackColor = SystemColors.ActiveCaption;
            btnModificar.Location = new Point(18, 251);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(92, 25);
            btnModificar.TabIndex = 11;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = false;
            btnModificar.Click += button2_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = SystemColors.ActiveCaption;
            btnGuardar.ForeColor = SystemColors.ControlText;
            btnGuardar.Location = new Point(18, 215);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(192, 30);
            btnGuardar.TabIndex = 10;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = false;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(71, 165);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(139, 23);
            txtEdad.TabIndex = 9;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(71, 130);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(139, 23);
            txtApellidos.TabIndex = 8;
            // 
            // txtNombres
            // 
            txtNombres.Location = new Point(71, 95);
            txtNombres.Name = "txtNombres";
            txtNombres.Size = new Size(139, 23);
            txtNombres.TabIndex = 7;
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(71, 60);
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(139, 23);
            txtDNI.TabIndex = 6;
            // 
            // txtID
            // 
            txtID.Location = new Point(71, 26);
            txtID.Name = "txtID";
            txtID.Size = new Size(139, 23);
            txtID.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 168);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Edad:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 133);
            label4.Name = "label4";
            label4.Size = new Size(59, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellidos:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 98);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 2;
            label3.Text = "Nombres:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 63);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 1;
            label2.Text = "DNI:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // RegistroD
            // 
            RegistroD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            RegistroD.Location = new Point(271, 25);
            RegistroD.Name = "RegistroD";
            RegistroD.Size = new Size(482, 272);
            RegistroD.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(777, 313);
            Controls.Add(RegistroD);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.ControlText;
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)RegistroD).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private DataGridView RegistroD;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtEdad;
        private TextBox txtApellidos;
        private TextBox txtNombres;
        private TextBox txtDNI;
        private TextBox txtID;
        private Button btnEliminar;
        private Button btnModificar;
        private Button btnGuardar;
    }
}
