namespace WindowsFormsApplication1.ABM_Usuario
{
    partial class ElegirTipoUsuario
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
            this.tiposDeUsuario = new System.Windows.Forms.ComboBox();
            this.continuar_Boton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tiposDeUsuario);
            this.groupBox1.Controls.Add(this.continuar_Boton);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(359, 111);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipos de usuario disponibles";
            // 
            // tiposDeUsuario
            // 
            this.tiposDeUsuario.FormattingEnabled = true;
            this.tiposDeUsuario.Location = new System.Drawing.Point(13, 25);
            this.tiposDeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.tiposDeUsuario.Name = "tiposDeUsuario";
            this.tiposDeUsuario.Size = new System.Drawing.Size(329, 24);
            this.tiposDeUsuario.TabIndex = 0;
            this.tiposDeUsuario.SelectedIndexChanged += new System.EventHandler(this.tiposDeUsuario_SelectedIndexChanged);
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
            this.continuar_Boton.Click += new System.EventHandler(this.continuar_Boton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Por favor, escoja un rol:";
            // 
            // ElegirTipoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 139);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "ElegirTipoUsuario";
            this.Text = "ElegirTipoUsuario";
            this.Load += new System.EventHandler(this.ElegirTipoUsuario_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox tiposDeUsuario;
        private System.Windows.Forms.Button continuar_Boton;
        private System.Windows.Forms.Label label1;
    }
}