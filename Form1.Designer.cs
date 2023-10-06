namespace Agenda_G2_2024_I
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
            txtbNombre = new TextBox();
            label2 = new Label();
            txtbTelefono = new TextBox();
            label3 = new Label();
            txtbEdad = new TextBox();
            label4 = new Label();
            txtbDireccion = new TextBox();
            btnSiguiente = new Button();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 85);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtbNombre
            // 
            txtbNombre.Location = new Point(156, 83);
            txtbNombre.Name = "txtbNombre";
            txtbNombre.Size = new Size(268, 23);
            txtbNombre.TabIndex = 1;
            txtbNombre.KeyPress += txtbNombre_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 149);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 0;
            label2.Text = "Teléfono";
            // 
            // txtbTelefono
            // 
            txtbTelefono.Location = new Point(156, 147);
            txtbTelefono.Name = "txtbTelefono";
            txtbTelefono.Size = new Size(268, 23);
            txtbTelefono.TabIndex = 1;
            txtbTelefono.KeyPress += txtbNombre_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 215);
            label3.Name = "label3";
            label3.Size = new Size(33, 15);
            label3.TabIndex = 0;
            label3.Text = "Edad";
            // 
            // txtbEdad
            // 
            txtbEdad.Location = new Point(156, 213);
            txtbEdad.Name = "txtbEdad";
            txtbEdad.Size = new Size(268, 23);
            txtbEdad.TabIndex = 1;
            txtbEdad.KeyPress += txtbNombre_KeyPress;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 274);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 0;
            label4.Text = "Dirección";
            // 
            // txtbDireccion
            // 
            txtbDireccion.Location = new Point(156, 272);
            txtbDireccion.Name = "txtbDireccion";
            txtbDireccion.Size = new Size(268, 23);
            txtbDireccion.TabIndex = 1;
            txtbDireccion.KeyPress += txtbNombre_KeyPress;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(315, 349);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(75, 48);
            btnSiguiente.TabIndex = 3;
            btnSiguiente.Text = "Siguientes";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(169, 349);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(75, 48);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 425);
            Controls.Add(btnGuardar);
            Controls.Add(btnSiguiente);
            Controls.Add(txtbDireccion);
            Controls.Add(label4);
            Controls.Add(txtbEdad);
            Controls.Add(label3);
            Controls.Add(txtbTelefono);
            Controls.Add(label2);
            Controls.Add(txtbNombre);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtbNombre;
        private Label label2;
        private TextBox txtbTelefono;
        private Label label3;
        private TextBox txtbEdad;
        private Label label4;
        private TextBox txtbDireccion;
        private Button btnSiguiente;
        private Button btnGuardar;
    }
}