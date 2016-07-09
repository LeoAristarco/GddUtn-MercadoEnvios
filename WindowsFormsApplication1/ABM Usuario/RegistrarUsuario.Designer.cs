namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class RegistrarUsuario
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
            this.Password_Label = new System.Windows.Forms.Label();
            this.pass = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Username_Label);
            this.groupBox1.Controls.Add(this.nick);
            this.groupBox1.Controls.Add(this.RegistrarUsuario_Button);
            this.groupBox1.Controls.Add(this.Password_Label);
            this.groupBox1.Controls.Add(this.pass);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(328, 215);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registrar un usuario";
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
            // nick
            // 
            this.nick.Location = new System.Drawing.Point(17, 55);
            this.nick.Margin = new System.Windows.Forms.Padding(4);
            this.nick.Name = "nick";
            this.nick.Size = new System.Drawing.Size(292, 22);
            this.nick.TabIndex = 0;
            // 
            // RegistrarUsuario_Button
            // 
            this.RegistrarUsuario_Button.Location = new System.Drawing.Point(169, 160);
            this.RegistrarUsuario_Button.Margin = new System.Windows.Forms.Padding(4);
            this.RegistrarUsuario_Button.Name = "RegistrarUsuario_Button";
            this.RegistrarUsuario_Button.Size = new System.Drawing.Size(140, 47);
            this.RegistrarUsuario_Button.TabIndex = 3;
            this.RegistrarUsuario_Button.Text = "Registrar";
            this.RegistrarUsuario_Button.UseVisualStyleBackColor = true;
            this.RegistrarUsuario_Button.Click += new System.EventHandler(this.RegistrarUsuario_Button_Click);
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
            // pass
            // 
            this.pass.Location = new System.Drawing.Point(17, 117);
            this.pass.Margin = new System.Windows.Forms.Padding(4);
            this.pass.Name = "pass";
            this.pass.PasswordChar = '*';
            this.pass.Size = new System.Drawing.Size(292, 22);
            this.pass.TabIndex = 1;
            // 
            // RegistrarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 238);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegistrarUsuario";
            this.Text = "RegistrarUsuario";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RegistrarUsuario_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Username_Label;
        private System.Windows.Forms.TextBox nick;
        private System.Windows.Forms.Button RegistrarUsuario_Button;
        private System.Windows.Forms.Label Password_Label;
        private System.Windows.Forms.TextBox pass;
    }
}