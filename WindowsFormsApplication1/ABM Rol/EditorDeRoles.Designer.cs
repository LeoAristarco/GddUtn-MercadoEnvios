namespace WindowsFormsApplication1.ABM_Rol
{
    partial class EditorDeRoles
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
            this.Nombre_Label = new System.Windows.Forms.Label();
            this.Nombre_Textbox = new System.Windows.Forms.TextBox();
            this.Funcionalidades_Checkboxlist = new System.Windows.Forms.CheckedListBox();
            this.Habilitado_Checkbox = new System.Windows.Forms.CheckBox();
            this.Funcionalidades_Label = new System.Windows.Forms.Label();
            this.Habilitado_Label = new System.Windows.Forms.Label();
            this.Guardar_Button = new System.Windows.Forms.Button();
            this.Cancelar_Button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Nombre_Label);
            this.groupBox1.Controls.Add(this.Nombre_Textbox);
            this.groupBox1.Controls.Add(this.Funcionalidades_Checkboxlist);
            this.groupBox1.Controls.Add(this.Habilitado_Checkbox);
            this.groupBox1.Controls.Add(this.Funcionalidades_Label);
            this.groupBox1.Controls.Add(this.Habilitado_Label);
            this.groupBox1.Location = new System.Drawing.Point(10, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 244);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione las funcionalidades:";
            // 
            // Nombre_Label
            // 
            this.Nombre_Label.AutoSize = true;
            this.Nombre_Label.Location = new System.Drawing.Point(6, 33);
            this.Nombre_Label.Name = "Nombre_Label";
            this.Nombre_Label.Size = new System.Drawing.Size(44, 13);
            this.Nombre_Label.TabIndex = 0;
            this.Nombre_Label.Text = "Nombre";
            // 
            // Nombre_Textbox
            // 
            this.Nombre_Textbox.Location = new System.Drawing.Point(95, 33);
            this.Nombre_Textbox.Name = "Nombre_Textbox";
            this.Nombre_Textbox.Size = new System.Drawing.Size(182, 20);
            this.Nombre_Textbox.TabIndex = 1;
            // 
            // Funcionalidades_Checkboxlist
            // 
            this.Funcionalidades_Checkboxlist.FormattingEnabled = true;
            this.Funcionalidades_Checkboxlist.Location = new System.Drawing.Point(95, 70);
            this.Funcionalidades_Checkboxlist.Name = "Funcionalidades_Checkboxlist";
            this.Funcionalidades_Checkboxlist.Size = new System.Drawing.Size(182, 94);
            this.Funcionalidades_Checkboxlist.TabIndex = 2;
            // 
            // Habilitado_Checkbox
            // 
            this.Habilitado_Checkbox.AutoSize = true;
            this.Habilitado_Checkbox.Location = new System.Drawing.Point(95, 204);
            this.Habilitado_Checkbox.Name = "Habilitado_Checkbox";
            this.Habilitado_Checkbox.Size = new System.Drawing.Size(15, 14);
            this.Habilitado_Checkbox.TabIndex = 3;
            this.Habilitado_Checkbox.UseVisualStyleBackColor = true;
            // 
            // Funcionalidades_Label
            // 
            this.Funcionalidades_Label.AutoSize = true;
            this.Funcionalidades_Label.Location = new System.Drawing.Point(6, 70);
            this.Funcionalidades_Label.Name = "Funcionalidades_Label";
            this.Funcionalidades_Label.Size = new System.Drawing.Size(84, 13);
            this.Funcionalidades_Label.TabIndex = 3;
            this.Funcionalidades_Label.Text = "Funcionalidades";
            // 
            // Habilitado_Label
            // 
            this.Habilitado_Label.AutoSize = true;
            this.Habilitado_Label.Location = new System.Drawing.Point(6, 204);
            this.Habilitado_Label.Name = "Habilitado_Label";
            this.Habilitado_Label.Size = new System.Drawing.Size(54, 13);
            this.Habilitado_Label.TabIndex = 4;
            this.Habilitado_Label.Text = "Habilitado";
            // 
            // Guardar_Button
            // 
            this.Guardar_Button.Location = new System.Drawing.Point(228, 260);
            this.Guardar_Button.Name = "Guardar_Button";
            this.Guardar_Button.Size = new System.Drawing.Size(75, 23);
            this.Guardar_Button.TabIndex = 10;
            this.Guardar_Button.Text = "Guardar";
            this.Guardar_Button.UseVisualStyleBackColor = true;
            this.Guardar_Button.Click += new System.EventHandler(this.Guardar_Button_Click);
            // 
            // Cancelar_Button
            // 
            this.Cancelar_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancelar_Button.Location = new System.Drawing.Point(147, 260);
            this.Cancelar_Button.Name = "Cancelar_Button";
            this.Cancelar_Button.Size = new System.Drawing.Size(75, 23);
            this.Cancelar_Button.TabIndex = 9;
            this.Cancelar_Button.Text = "Cancelar";
            this.Cancelar_Button.UseVisualStyleBackColor = true;
            // 
            // EditorDeRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 292);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Guardar_Button);
            this.Controls.Add(this.Cancelar_Button);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditorDeRoles";
            this.Text = "EditorDeRoles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Nombre_Label;
        private System.Windows.Forms.TextBox Nombre_Textbox;
        private System.Windows.Forms.CheckedListBox Funcionalidades_Checkboxlist;
        private System.Windows.Forms.CheckBox Habilitado_Checkbox;
        private System.Windows.Forms.Label Funcionalidades_Label;
        private System.Windows.Forms.Label Habilitado_Label;
        private System.Windows.Forms.Button Guardar_Button;
        private System.Windows.Forms.Button Cancelar_Button;
    }
}