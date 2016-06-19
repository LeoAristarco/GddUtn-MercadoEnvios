namespace WindowsFormsApplication1.Login
{
    partial class SeleccionFuncionalidades
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
            this.cbFuncionalidades = new System.Windows.Forms.ComboBox();
            this.continuar = new System.Windows.Forms.Button();
            this.volver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbFuncionalidades);
            this.groupBox1.Controls.Add(this.continuar);
            this.groupBox1.Controls.Add(this.volver);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(269, 90);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Qué desea hacer?";
            // 
            // cbFuncionalidades
            // 
            this.cbFuncionalidades.FormattingEnabled = true;
            this.cbFuncionalidades.Location = new System.Drawing.Point(10, 20);
            this.cbFuncionalidades.Name = "cbFuncionalidades";
            this.cbFuncionalidades.Size = new System.Drawing.Size(248, 21);
            this.cbFuncionalidades.TabIndex = 0;
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(139, 50);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(120, 30);
            this.continuar.TabIndex = 1;
            this.continuar.Text = "Continuar >>";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // volver
            // 
            this.volver.Location = new System.Drawing.Point(10, 50);
            this.volver.Name = "volver";
            this.volver.Size = new System.Drawing.Size(120, 30);
            this.volver.TabIndex = 2;
            this.volver.Text = "<< Volver";
            this.volver.UseVisualStyleBackColor = true;
            // 
            // SeleccionFuncionalidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 115);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "SeleccionFuncionalidades";
            this.Text = "SeleccionFuncionalidades";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbFuncionalidades;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.Button volver;
    }
}