namespace WindowsFormsApplication1.ABM_Visibilidad
{
    partial class ABMVisibilidad
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
            this.volverButton = new System.Windows.Forms.Button();
            this.tablaVisibilidad = new System.Windows.Forms.DataGridView();
            this.modificarButton = new System.Windows.Forms.Button();
            this.nuevaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tablaVisibilidad)).BeginInit();
            this.SuspendLayout();
            // 
            // volverButton
            // 
            this.volverButton.Location = new System.Drawing.Point(552, 196);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(75, 38);
            this.volverButton.TabIndex = 8;
            this.volverButton.Text = "< < Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            this.volverButton.Click += new System.EventHandler(this.volverButton_Click);
            // 
            // tablaVisibilidad
            // 
            this.tablaVisibilidad.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaVisibilidad.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaVisibilidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaVisibilidad.GridColor = System.Drawing.SystemColors.Window;
            this.tablaVisibilidad.Location = new System.Drawing.Point(10, 49);
            this.tablaVisibilidad.MultiSelect = false;
            this.tablaVisibilidad.Name = "tablaVisibilidad";
            this.tablaVisibilidad.ReadOnly = true;
            this.tablaVisibilidad.RowHeadersVisible = false;
            this.tablaVisibilidad.Size = new System.Drawing.Size(617, 121);
            this.tablaVisibilidad.TabIndex = 7;
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(91, 11);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(75, 23);
            this.modificarButton.TabIndex = 6;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            this.modificarButton.Click += new System.EventHandler(this.modificarButton_Click);
            // 
            // nuevaButton
            // 
            this.nuevaButton.Location = new System.Drawing.Point(10, 11);
            this.nuevaButton.Name = "nuevaButton";
            this.nuevaButton.Size = new System.Drawing.Size(75, 23);
            this.nuevaButton.TabIndex = 5;
            this.nuevaButton.Text = "Nueva";
            this.nuevaButton.UseVisualStyleBackColor = true;
            this.nuevaButton.Click += new System.EventHandler(this.nuevaButton_Click);
            // 
            // ABMVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 246);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.tablaVisibilidad);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.nuevaButton);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ABMVisibilidad";
            this.Text = "ABMVisibilidad";
            this.Load += new System.EventHandler(this.ABMVisibilidad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablaVisibilidad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.DataGridView tablaVisibilidad;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button nuevaButton;
    }
}