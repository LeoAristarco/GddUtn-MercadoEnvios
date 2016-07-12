namespace WindowsFormsApplication1.Login
{
    partial class CambiarPassword
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nuevaPass2 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.nuevaPass1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.passVieja = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.nuevaPass2);
            this.groupBox3.Location = new System.Drawing.Point(13, 173);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(288, 64);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Confirmar nueva contraseña";
            // 
            // nuevaPass2
            // 
            this.nuevaPass2.Location = new System.Drawing.Point(13, 25);
            this.nuevaPass2.Margin = new System.Windows.Forms.Padding(4);
            this.nuevaPass2.Name = "nuevaPass2";
            this.nuevaPass2.Size = new System.Drawing.Size(260, 22);
            this.nuevaPass2.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nuevaPass1);
            this.groupBox2.Location = new System.Drawing.Point(13, 93);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(288, 64);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Nueva contraseña";
            // 
            // nuevaPass1
            // 
            this.nuevaPass1.Location = new System.Drawing.Point(13, 25);
            this.nuevaPass1.Margin = new System.Windows.Forms.Padding(4);
            this.nuevaPass1.Name = "nuevaPass1";
            this.nuevaPass1.Size = new System.Drawing.Size(260, 22);
            this.nuevaPass1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.passVieja);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(288, 64);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Contraseña vieja";
            // 
            // passVieja
            // 
            this.passVieja.Location = new System.Drawing.Point(13, 25);
            this.passVieja.Margin = new System.Windows.Forms.Padding(4);
            this.passVieja.Multiline = true;
            this.passVieja.Name = "passVieja";
            this.passVieja.Size = new System.Drawing.Size(260, 24);
            this.passVieja.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 251);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 37);
            this.button1.TabIndex = 8;
            this.button1.Text = "Continuar >>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CambiarPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 300);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "CambiarPassword";
            this.Text = "CambiarPassword";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CambiarPassword_FormClosing);
            this.Load += new System.EventHandler(this.CambiarPassword_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox nuevaPass2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nuevaPass1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox passVieja;
        private System.Windows.Forms.Button button1;
    }
}