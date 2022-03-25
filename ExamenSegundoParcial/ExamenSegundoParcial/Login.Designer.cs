namespace ExamenSegundoParcial
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancelarbutton2 = new System.Windows.Forms.Button();
            this.Aceptarbutton1 = new System.Windows.Forms.Button();
            this.ClavetextBox2 = new System.Windows.Forms.TextBox();
            this.UsuariotextBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 95);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Clave:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Usuario:";
            // 
            // Cancelarbutton2
            // 
            this.Cancelarbutton2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelarbutton2.Location = new System.Drawing.Point(240, 125);
            this.Cancelarbutton2.Margin = new System.Windows.Forms.Padding(4);
            this.Cancelarbutton2.Name = "Cancelarbutton2";
            this.Cancelarbutton2.Size = new System.Drawing.Size(99, 38);
            this.Cancelarbutton2.TabIndex = 9;
            this.Cancelarbutton2.Text = "Cancelar";
            this.Cancelarbutton2.UseVisualStyleBackColor = true;
            // 
            // Aceptarbutton1
            // 
            this.Aceptarbutton1.Location = new System.Drawing.Point(126, 125);
            this.Aceptarbutton1.Margin = new System.Windows.Forms.Padding(4);
            this.Aceptarbutton1.Name = "Aceptarbutton1";
            this.Aceptarbutton1.Size = new System.Drawing.Size(99, 38);
            this.Aceptarbutton1.TabIndex = 8;
            this.Aceptarbutton1.Text = "Aceptar";
            this.Aceptarbutton1.UseVisualStyleBackColor = true;
            this.Aceptarbutton1.Click += new System.EventHandler(this.Aceptarbutton1_Click);
            // 
            // ClavetextBox2
            // 
            this.ClavetextBox2.Location = new System.Drawing.Point(126, 95);
            this.ClavetextBox2.Margin = new System.Windows.Forms.Padding(4);
            this.ClavetextBox2.Name = "ClavetextBox2";
            this.ClavetextBox2.PasswordChar = '*';
            this.ClavetextBox2.Size = new System.Drawing.Size(213, 20);
            this.ClavetextBox2.TabIndex = 7;
            // 
            // UsuariotextBox1
            // 
            this.UsuariotextBox1.Location = new System.Drawing.Point(126, 52);
            this.UsuariotextBox1.Margin = new System.Windows.Forms.Padding(4);
            this.UsuariotextBox1.Name = "UsuariotextBox1";
            this.UsuariotextBox1.Size = new System.Drawing.Size(213, 20);
            this.UsuariotextBox1.TabIndex = 6;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 243);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancelarbutton2);
            this.Controls.Add(this.Aceptarbutton1);
            this.Controls.Add(this.ClavetextBox2);
            this.Controls.Add(this.UsuariotextBox1);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Cancelarbutton2;
        private System.Windows.Forms.Button Aceptarbutton1;
        private System.Windows.Forms.TextBox ClavetextBox2;
        private System.Windows.Forms.TextBox UsuariotextBox1;
    }
}

