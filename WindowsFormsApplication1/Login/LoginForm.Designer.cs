namespace WindowsFormsApplication1.Login
{
    partial class LoginForm
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
            this.Username_TextBox = new System.Windows.Forms.TextBox();
            this.RegistrarUsuario_Button = new System.Windows.Forms.Button();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.Password_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Username_Label);
            this.groupBox1.Controls.Add(this.Username_TextBox);
            this.groupBox1.Controls.Add(this.RegistrarUsuario_Button);
            this.groupBox1.Controls.Add(this.Password_Label);
            this.groupBox1.Controls.Add(this.Login_Button);
            this.groupBox1.Controls.Add(this.Password_TextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(328, 215);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso al sistema";
            // 
            // Username_Label
            // 
            this.Username_Label.AutoSize = true;
            this.Username_Label.Location = new System.Drawing.Point(13, 31);
            this.Username_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Username_Label.Name = "Username_Label";
            this.Username_Label.Size = new System.Drawing.Size(129, 17);
            this.Username_Label.TabIndex = 0;
            this.Username_Label.Text = "Nombre de usuario";
            // 
            // Username_TextBox
            // 
            this.Username_TextBox.Location = new System.Drawing.Point(17, 55);
            this.Username_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Username_TextBox.Name = "Username_TextBox";
            this.Username_TextBox.Size = new System.Drawing.Size(292, 22);
            this.Username_TextBox.TabIndex = 0;
            // 
            // RegistrarUsuario_Button
            // 
            this.RegistrarUsuario_Button.Location = new System.Drawing.Point(17, 154);
            this.RegistrarUsuario_Button.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrarUsuario_Button.Name = "RegistrarUsuario_Button";
            this.RegistrarUsuario_Button.Size = new System.Drawing.Size(140, 47);
            this.RegistrarUsuario_Button.TabIndex = 3;
            this.RegistrarUsuario_Button.Text = "Registrarme";
            this.RegistrarUsuario_Button.UseVisualStyleBackColor = true;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(13, 92);
            this.Password_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(81, 17);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Contraseña";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(172, 154);
            this.Login_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(140, 47);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "Ingresar";
            this.Login_Button.UseVisualStyleBackColor = true;
            // 
            // Password_TextBox
            // 
            this.Password_TextBox.Location = new System.Drawing.Point(17, 117);
            this.Password_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Password_TextBox.Name = "Password_TextBox";
            this.Password_TextBox.Size = new System.Drawing.Size(292, 22);
            this.Password_TextBox.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 241);
            this.Controls.Add(this.groupBox1);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.TextBox Username_TextBox;
        private System.Windows.Forms.Button RegistrarUsuario_Button;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.TextBox Password_TextBox;
    }
}