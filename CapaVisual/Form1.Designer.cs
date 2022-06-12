namespace CapaVisual
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TextBoxId = new System.Windows.Forms.TextBox();
            this.TextBoxNombre = new System.Windows.Forms.TextBox();
            this.TextBoxApellido = new System.Windows.Forms.TextBox();
            this.TextBoxTelefono = new System.Windows.Forms.TextBox();
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.BotonGuardar = new System.Windows.Forms.Button();
            this.DataGridPersonas = new System.Windows.Forms.DataGridView();
            this.BotonListar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Apellido";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Telefono";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(68, 222);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email";
            // 
            // TextBoxId
            // 
            this.TextBoxId.Location = new System.Drawing.Point(152, 48);
            this.TextBoxId.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxId.Name = "TextBoxId";
            this.TextBoxId.Size = new System.Drawing.Size(180, 29);
            this.TextBoxId.TabIndex = 5;
            // 
            // TextBoxNombre
            // 
            this.TextBoxNombre.Location = new System.Drawing.Point(152, 90);
            this.TextBoxNombre.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxNombre.Name = "TextBoxNombre";
            this.TextBoxNombre.Size = new System.Drawing.Size(180, 29);
            this.TextBoxNombre.TabIndex = 6;
            // 
            // TextBoxApellido
            // 
            this.TextBoxApellido.Location = new System.Drawing.Point(152, 133);
            this.TextBoxApellido.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxApellido.Name = "TextBoxApellido";
            this.TextBoxApellido.Size = new System.Drawing.Size(180, 29);
            this.TextBoxApellido.TabIndex = 7;
            // 
            // TextBoxTelefono
            // 
            this.TextBoxTelefono.Location = new System.Drawing.Point(152, 174);
            this.TextBoxTelefono.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxTelefono.Name = "TextBoxTelefono";
            this.TextBoxTelefono.Size = new System.Drawing.Size(180, 29);
            this.TextBoxTelefono.TabIndex = 8;
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Location = new System.Drawing.Point(152, 216);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(180, 29);
            this.TextBoxEmail.TabIndex = 9;
            // 
            // BotonGuardar
            // 
            this.BotonGuardar.Location = new System.Drawing.Point(152, 266);
            this.BotonGuardar.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.BotonGuardar.Name = "BotonGuardar";
            this.BotonGuardar.Size = new System.Drawing.Size(183, 42);
            this.BotonGuardar.TabIndex = 10;
            this.BotonGuardar.Text = "Guardar";
            this.BotonGuardar.UseVisualStyleBackColor = true;
            this.BotonGuardar.Click += new System.EventHandler(this.BotonGuardar_Click);
            // 
            // DataGridPersonas
            // 
            this.DataGridPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridPersonas.Location = new System.Drawing.Point(389, 48);
            this.DataGridPersonas.Name = "DataGridPersonas";
            this.DataGridPersonas.RowTemplate.Height = 31;
            this.DataGridPersonas.Size = new System.Drawing.Size(658, 260);
            this.DataGridPersonas.TabIndex = 11;
            // 
            // BotonListar
            // 
            this.BotonListar.Location = new System.Drawing.Point(811, 314);
            this.BotonListar.Name = "BotonListar";
            this.BotonListar.Size = new System.Drawing.Size(236, 46);
            this.BotonListar.TabIndex = 12;
            this.BotonListar.Text = "Listar";
            this.BotonListar.UseVisualStyleBackColor = true;
            this.BotonListar.Click += new System.EventHandler(this.BotonListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1093, 391);
            this.Controls.Add(this.BotonListar);
            this.Controls.Add(this.DataGridPersonas);
            this.Controls.Add(this.BotonGuardar);
            this.Controls.Add(this.TextBoxEmail);
            this.Controls.Add(this.TextBoxTelefono);
            this.Controls.Add(this.TextBoxApellido);
            this.Controls.Add(this.TextBoxNombre);
            this.Controls.Add(this.TextBoxId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TextBoxId;
        private System.Windows.Forms.TextBox TextBoxNombre;
        private System.Windows.Forms.TextBox TextBoxApellido;
        private System.Windows.Forms.TextBox TextBoxTelefono;
        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.Button BotonGuardar;
        private System.Windows.Forms.DataGridView DataGridPersonas;
        private System.Windows.Forms.Button BotonListar;
    }
}

