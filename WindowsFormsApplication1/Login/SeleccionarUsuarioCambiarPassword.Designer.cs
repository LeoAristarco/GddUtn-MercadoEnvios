namespace WindowsFormsApplication1.Login
{
    partial class SeleccionarUsuarioCambiarPassword
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Username_Label = new System.Windows.Forms.Label();
            this.nick = new System.Windows.Forms.TextBox();
            this.RegistrarUsuario_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Username_Label);
            this.groupBox1.Controls.Add(this.nick);
            this.groupBox1.Controls.Add(this.RegistrarUsuario_Button);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 138);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccionar usuario";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(10, 25);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(96, 13);
            this.Username_Label.TabIndex = 0;
            this.Username_Label.Text = "Nombre de usuario";
            // 
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(13, 45);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(220, 20);
            this.nick.TabIndex = 0;
            // 
            // RegistrarUsuario_Button
            // 
            this.RegistrarUsuario_Button.Location = new System.Drawing.Point(127, 82);
            this.RegistrarUsuario_Button.Name = "RegistrarUsuario_Button";
            this.RegistrarUsuario_Button.Size = new System.Drawing.Size(105, 38);
            this.RegistrarUsuario_Button.TabIndex = 3;
            this.RegistrarUsuario_Button.Text = "Cambiar Password";
            this.RegistrarUsuario_Button.UseVisualStyleBackColor = true;
            this.RegistrarUsuario_Button.Click += new System.EventHandler(this.RegistrarUsuario_Button_Click);
            // 
            // SeleccionarUsuarioCambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 162);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SeleccionarUsuarioCambiarPassword";
            this.Text = "SeleccionarUsuarioCambiarPassword";
            this.Load += new System.EventHandler(this.SeleccionarUsuarioCambiarPassword_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.Button RegistrarUsuario_Button;
    }
}