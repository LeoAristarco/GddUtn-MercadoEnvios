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
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Roles disponibles";
            // 
            // comboBox_Roles
            // 
            this.comboBox_Roles.FormattingEnabled = true;
            this.comboBox_Roles.Location = new System.Drawing.Point(10, 20);
            this.comboBox_Roles.Name = "comboBox_Roles";
            this.comboBox_Roles.Size = new System.Drawing.Size(248, 21);
            this.comboBox_Roles.TabIndex = 0;
            // 
            // continuar_Boton
            // 
            this.continuar_Boton.Location = new System.Drawing.Point(139, 50);
            this.continuar_Boton.Name = "continuar_Boton";
            this.continuar_Boton.Size = new System.Drawing.Size(120, 30);
            this.continuar_Boton.TabIndex = 1;
            this.continuar_Boton.Text = "Continuar >>";
            this.continuar_Boton.UseVisualStyleBackColor = true;
            this.continuar_Boton.Click += new System.EventHandler(this.continuar_Boton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Por favor, escoja un rol:";
            // 
            // SeleccionRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 110);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SeleccionRoles";
            this.Text = "SeleccionRoles";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SeleccionRoles_FormClosed);
            this.Load += new System.EventHandler(this.SeleccionRoles_Load);
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