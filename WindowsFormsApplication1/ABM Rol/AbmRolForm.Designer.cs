namespace WindowsFormsApplication1.ABM_Rol
{
    partial class AbmRolForm
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
            this.Roles_Datagrid = new System.Windows.Forms.DataGridView();
            this.Modificar_Button = new System.Windows.Forms.Button();
            this.Eliminar_Button = new System.Windows.Forms.Button();
            this.Volver_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Roles_Datagrid)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAsignarRoles);
            this.groupBox1.Controls.Add(this.Nuevo_Button);
            this.groupBox1.Controls.Add(this.Roles_Datagrid);
            this.groupBox1.Controls.Add(this.Modificar_Button);
            this.groupBox1.Controls.Add(this.Eliminar_Button);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(547, 340);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestión de Roles";
            // 
            // btnAsignarRoles
            // 
            this.btnAsignarRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarRoles.Location = new System.Drawing.Point(411, 23);
            this.btnAsignarRoles.Margin = new System.Windows.Forms.Padding(4);
            this.btnAsignarRoles.Name = "btnAsignarRoles";
            this.btnAsignarRoles.Size = new System.Drawing.Size(128, 28);
            this.btnAsignarRoles.TabIndex = 4;
            this.btnAsignarRoles.Text = "Asignar roles";
            this.btnAsignarRoles.UseVisualStyleBackColor = true;
            // 
            // Nuevo_Button
            // 
            this.Nuevo_Button.Location = new System.Drawing.Point(8, 23);
            this.Nuevo_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Nuevo_Button.Name = "Nuevo_Button";
            this.Nuevo_Button.Size = new System.Drawing.Size(100, 28);
            this.Nuevo_Button.TabIndex = 1;
            this.Nuevo_Button.Text = "Nuevo";
            this.Nuevo_Button.UseVisualStyleBackColor = true;
            // 
            // Roles_Datagrid
            // 
            this.Roles_Datagrid.AllowUserToAddRows = false;
            this.Roles_Datagrid.AllowUserToDeleteRows = false;
            this.Roles_Datagrid.AllowUserToOrderColumns = true;
            this.Roles_Datagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Roles_Datagrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Roles_Datagrid.BackgroundColor = System.Drawing.SystemColors.Window;
            this.Roles_Datagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Roles_Datagrid.Location = new System.Drawing.Point(8, 59);
            this.Roles_Datagrid.Margin = new System.Windows.Forms.Padding(4);
            this.Roles_Datagrid.MultiSelect = false;
            this.Roles_Datagrid.Name = "Roles_Datagrid";
            this.Roles_Datagrid.ReadOnly = true;
            this.Roles_Datagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Roles_Datagrid.Size = new System.Drawing.Size(531, 273);
            this.Roles_Datagrid.TabIndex = 4;
            // 
            // Modificar_Button
            // 
            this.Modificar_Button.Location = new System.Drawing.Point(116, 23);
            this.Modificar_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Modificar_Button.Name = "Modificar_Button";
            this.Modificar_Button.Size = new System.Drawing.Size(100, 28);
            this.Modificar_Button.TabIndex = 2;
            this.Modificar_Button.Text = "Modificar";
            this.Modificar_Button.UseVisualStyleBackColor = true;
            // 
            // Eliminar_Button
            // 
            this.Eliminar_Button.Location = new System.Drawing.Point(224, 23);
            this.Eliminar_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Eliminar_Button.Name = "Eliminar_Button";
            this.Eliminar_Button.Size = new System.Drawing.Size(100, 28);
            this.Eliminar_Button.TabIndex = 3;
            this.Eliminar_Button.Text = "Eliminar";
            this.Eliminar_Button.UseVisualStyleBackColor = true;
            // 
            // Volver_Button
            // 
            this.Volver_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Volver_Button.Location = new System.Drawing.Point(460, 360);
            this.Volver_Button.Margin = new System.Windows.Forms.Padding(4);
            this.Volver_Button.Name = "Volver_Button";
            this.Volver_Button.Size = new System.Drawing.Size(100, 28);
            this.Volver_Button.TabIndex = 7;
            this.Volver_Button.Text = "Volver";
            this.Volver_Button.UseVisualStyleBackColor = true;
            // 
            // AbmRolForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 403);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Volver_Button);
            this.Name = "AbmRolForm";
            this.Text = "AbmRolForm";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Roles_Datagrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAsignarRoles;
        private System.Windows.Forms.Button Nuevo_Button;
        private System.Windows.Forms.DataGridView Roles_Datagrid;
        private System.Windows.Forms.Button Modificar_Button;
        private System.Windows.Forms.Button Eliminar_Button;
        private System.Windows.Forms.Button Volver_Button;
    }
}