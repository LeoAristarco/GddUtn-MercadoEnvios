namespace WindowsFormsApplication1.ABM_Rol
{
    partial class ABMRol
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
            this.btnAsignarRoles = new System.Windows.Forms.Button();
            this.Nuevo_Button = new System.Windows.Forms.Button();
            this.tablaRoles = new System.Windows.Forms.DataGridView();
            this.Modificar_Button = new System.Windows.Forms.Button();
            this.Volver_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablaRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAsignarRoles);
            this.groupBox1.Controls.Add(this.Nuevo_Button);
            this.groupBox1.Controls.Add(this.tablaRoles);
            this.groupBox1.Controls.Add(this.Modificar_Button);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(547, 340);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de Roles";
            // 
            // btnAsignarRoles
            // 
            this.btnAsignarRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRoles.Location = new System.Drawing.Point(411, 23);
            this.btnAsignarRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAsignarRoles.Name = "btnAsignarRoles";
            this.btnAsignarRoles.Size = new System.Drawing.Size(128, 28);
            this.btnAsignarRoles.TabIndex = 4;
            this.btnAsignarRoles.Text = "Asignar roles";
            this.btnAsignarRoles.UseVisualStyleBackColor = true;
            this.btnAsignarRoles.Click += new System.EventHandler(this.btnAsignarRoles_Click);
            // 
            // Nuevo_Button
            // 
            this.Nuevo_Button.Location = new System.Drawing.Point(8, 23);
            this.Nuevo_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Nuevo_Button.Name = "Nuevo_Button";
            this.Nuevo_Button.Size = new System.Drawing.Size(100, 28);
            this.Nuevo_Button.TabIndex = 1;
            this.Nuevo_Button.Text = "Nuevo";
            this.Nuevo_Button.UseVisualStyleBackColor = true;
            this.Nuevo_Button.Click += new System.EventHandler(this.Nuevo_Button_Click);
            // 
            // tablaRoles
            // 
            this.tablaRoles.AllowUserToAddRows = false;
            this.tablaRoles.AllowUserToDeleteRows = false;
            this.tablaRoles.AllowUserToOrderColumns = true;
            this.tablaRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tablaRoles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tablaRoles.BackgroundColor = System.Drawing.SystemColors.Window;
            this.tablaRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablaRoles.Location = new System.Drawing.Point(8, 59);
            this.tablaRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tablaRoles.MultiSelect = false;
            this.tablaRoles.Name = "tablaRoles";
            this.tablaRoles.ReadOnly = true;
            this.tablaRoles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablaRoles.Size = new System.Drawing.Size(531, 273);
            this.tablaRoles.TabIndex = 4;
            this.tablaRoles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tablaRoles_CellClick);
            this.tablaRoles.Click += new System.EventHandler(this.tablaRoles_Click);
            // 
            // Modificar_Button
            // 
            this.Modificar_Button.Location = new System.Drawing.Point(116, 23);
            this.Modificar_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Modificar_Button.Name = "Modificar_Button";
            this.Modificar_Button.Size = new System.Drawing.Size(100, 28);
            this.Modificar_Button.TabIndex = 2;
            this.Modificar_Button.Text = "Modificar";
            this.Modificar_Button.UseVisualStyleBackColor = true;
            this.Modificar_Button.Click += new System.EventHandler(this.Modificar_Button_Click);
            // 
            // Volver_Button
            // 
            this.Volver_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Volver_Button.Location = new System.Drawing.Point(460, 359);
            this.Volver_Button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Volver_Button.Name = "Volver_Button";
            this.Volver_Button.Size = new System.Drawing.Size(100, 28);
            this.Volver_Button.TabIndex = 7;
            this.Volver_Button.Text = "Volver";
            this.Volver_Button.UseVisualStyleBackColor = true;
            this.Volver_Button.Click += new System.EventHandler(this.Volver_Button_Click);
            // 
            // ABMRol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Volver_Button);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ABMRol";
            this.Text = "AbmRolForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ABMRol_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ABMRol_FormClosed);
            this.Load += new System.EventHandler(this.ABMRol_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablaRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAsignarRoles;
        private System.Windows.Forms.Button Nuevo_Button;
        private System.Windows.Forms.DataGridView tablaRoles;
        private System.Windows.Forms.Button Modificar_Button;
        private System.Windows.Forms.Button Volver_Button;
    }
}