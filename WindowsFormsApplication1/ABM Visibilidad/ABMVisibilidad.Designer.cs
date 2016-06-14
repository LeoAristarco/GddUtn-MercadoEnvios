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
            this.dgvVisibilidades = new System.Windows.Forms.DataGridView();
            this.modificarButton = new System.Windows.Forms.Button();
            this.nuevaButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisibilidades)).BeginInit();
            this.SuspendLayout();
            // 
            // volverButton
            // 
            this.volverButton.Location = new System.Drawing.Point(736, 241);
            this.volverButton.Margin = new System.Windows.Forms.Padding(4);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(100, 47);
            this.volverButton.TabIndex = 8;
            this.volverButton.Text = "< < Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            // 
            // dgvVisibilidades
            // 
            this.dgvVisibilidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVisibilidades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvVisibilidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVisibilidades.GridColor = System.Drawing.SystemColors.Window;
            this.dgvVisibilidades.Location = new System.Drawing.Point(13, 60);
            this.dgvVisibilidades.Margin = new System.Windows.Forms.Padding(4);
            this.dgvVisibilidades.MultiSelect = false;
            this.dgvVisibilidades.Name = "dgvVisibilidades";
            this.dgvVisibilidades.ReadOnly = true;
            this.dgvVisibilidades.RowHeadersVisible = false;
            this.dgvVisibilidades.Size = new System.Drawing.Size(823, 149);
            this.dgvVisibilidades.TabIndex = 7;
            // 
            // modificarButton
            // 
            this.modificarButton.Location = new System.Drawing.Point(121, 13);
            this.modificarButton.Margin = new System.Windows.Forms.Padding(4);
            this.modificarButton.Name = "modificarButton";
            this.modificarButton.Size = new System.Drawing.Size(100, 28);
            this.modificarButton.TabIndex = 6;
            this.modificarButton.Text = "Modificar";
            this.modificarButton.UseVisualStyleBackColor = true;
            // 
            // nuevaButton
            // 
            this.nuevaButton.Location = new System.Drawing.Point(13, 13);
            this.nuevaButton.Margin = new System.Windows.Forms.Padding(4);
            this.nuevaButton.Name = "nuevaButton";
            this.nuevaButton.Size = new System.Drawing.Size(100, 28);
            this.nuevaButton.TabIndex = 5;
            this.nuevaButton.Text = "Nueva";
            this.nuevaButton.UseVisualStyleBackColor = true;
            // 
            // ABMVisibilidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 303);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.dgvVisibilidades);
            this.Controls.Add(this.modificarButton);
            this.Controls.Add(this.nuevaButton);
            this.Name = "ABMVisibilidad";
            this.Text = "ABMVisibilidad";
            ((System.ComponentModel.ISupportInitialize)(this.dgvVisibilidades)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.DataGridView dgvVisibilidades;
        private System.Windows.Forms.Button modificarButton;
        private System.Windows.Forms.Button nuevaButton;
    }
}