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
            this.nick_TextBox = new System.Windows.Forms.TextBox();
            this.RegistrarUsuario_Button = new System.Windows.Forms.Button();
            this.Password_Label = new System.Windows.Forms.Label();
            this.Login_Button = new System.Windows.Forms.Button();
            this.pass_TextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Username_Label);
            this.groupBox1.Controls.Add(this.nick_TextBox);
            this.groupBox1.Controls.Add(this.RegistrarUsuario_Button);
            this.groupBox1.Controls.Add(this.Password_Label);
            this.groupBox1.Controls.Add(this.Login_Button);
            this.groupBox1.Controls.Add(this.pass_TextBox);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 175);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso al sistema";
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
            // nick_TextBox
            // 
            this.nick_TextBox.Location = new System.Drawing.Point(13, 45);
            this.nick_TextBox.Name = "nick_TextBox";
            this.nick_TextBox.Size = new System.Drawing.Size(220, 20);
            this.nick_TextBox.TabIndex = 0;
            // 
            // RegistrarUsuario_Button
            // 
            this.RegistrarUsuario_Button.Location = new System.Drawing.Point(13, 125);
            this.RegistrarUsuario_Button.Name = "RegistrarUsuario_Button";
            this.RegistrarUsuario_Button.Size = new System.Drawing.Size(105, 38);
            this.RegistrarUsuario_Button.TabIndex = 3;
            this.RegistrarUsuario_Button.Text = "Registrarme";
            this.RegistrarUsuario_Button.UseVisualStyleBackColor = true;
            // 
            // Password_Label
            // 
            this.Password_Label.AutoSize = true;
            this.Password_Label.Location = new System.Drawing.Point(10, 75);
            this.Password_Label.Name = "Password_Label";
            this.Password_Label.Size = new System.Drawing.Size(61, 13);
            this.Password_Label.TabIndex = 1;
            this.Password_Label.Text = "Contraseña";
            // 
            // Login_Button
            // 
            this.Login_Button.Location = new System.Drawing.Point(129, 125);
            this.Login_Button.Name = "Login_Button";
            this.Login_Button.Size = new System.Drawing.Size(105, 38);
            this.Login_Button.TabIndex = 2;
            this.Login_Button.Text = "Ingresar";
            this.Login_Button.UseVisualStyleBackColor = true;
            this.Login_Button.Click += new System.EventHandler(this.Login_Button_Click);
            // 
            // pass_TextBox
            // 
            this.pass_TextBox.Location = new System.Drawing.Point(13, 95);
            this.pass_TextBox.Name = "pass_TextBox";
            this.pass_TextBox.Size = new System.Drawing.Size(220, 20);
            this.pass_TextBox.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 196);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.TextBox nick_TextBox;
        private System.Windows.Forms.Button RegistrarUsuario_Button;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.Button Login_Button;
        private System.Windows.Forms.TextBox pass_TextBox;
    }
}