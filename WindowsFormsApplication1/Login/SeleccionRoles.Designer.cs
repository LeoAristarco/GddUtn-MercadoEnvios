namespace WindowsFormsApplication1.Login
{
    partial class SeleccionRoles
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
            this.comboBox_Roles = new System.Windows.Forms.ComboBox();
            this.continuar_Boton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox_Roles);
            this.groupBox1.Controls.Add(this.continuar_Boton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(359, 111);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles disponibles";
            // 
            // comboBox_Roles
            // 
            this.comboBox_Roles.FormattingEnabled = true;
            this.comboBox_Roles.Location = new System.Drawing.Point(13, 25);
            this.comboBox_Roles.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_Roles.Name = "comboBox_Roles";
            this.comboBox_Roles.Size = new System.Drawing.Size(329, 24);
            this.comboBox_Roles.TabIndex = 0;
            // 
            // continuar_Boton
            // 
            this.continuar_Boton.Location = new System.Drawing.Point(185, 62);
            this.continuar_Boton.Margin = new System.Windows.Forms.Padding(4);
            this.continuar_Boton.Name = "continuar_Boton";
            this.continuar_Boton.Size = new System.Drawing.Size(160, 37);
            this.continuar_Boton.TabIndex = 1;
            this.continuar_Boton.Text = "Continuar >>";
            this.continuar_Boton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Por favor, escoja un rol:";
            // 
            // SeleccionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 137);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "SeleccionRoles";
            this.Text = "SeleccionRoles";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_Roles;
        private System.Windows.Forms.Button continuar_Boton;
        private System.Windows.Forms.Label label1;
    }
}