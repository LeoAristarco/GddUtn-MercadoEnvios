namespace WindowsFormsApplication1.ABM_Rol
{
    partial class RolesUsuarioDlg
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblIdUser = new System.Windows.Forms.Label();
            this.txtIdUser = new System.Windows.Forms.TextBox();
            this.cblRoles = new System.Windows.Forms.CheckedListBox();
            this.lblRoles = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnCancelar.Location = new System.Drawing.Point(157, 286);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(265, 286);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 28);
            this.btnGuardar.TabIndex = 6;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblUsername);
            this.groupBox1.Controls.Add(this.txtUsername);
            this.groupBox1.Controls.Add(this.lblIdUser);
            this.groupBox1.Controls.Add(this.txtIdUser);
            this.groupBox1.Controls.Add(this.cblRoles);
            this.groupBox1.Controls.Add(this.lblRoles);
            this.groupBox1.Location = new System.Drawing.Point(13, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(352, 265);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Asigne los roles al Usuario:";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(8, 47);
            this.lblUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(77, 17);
            this.lblUsername.TabIndex = 8;
            this.lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(93, 43);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.ReadOnly = true;
            this.txtUsername.Size = new System.Drawing.Size(241, 22);
            this.txtUsername.TabIndex = 9;
            // 
            // lblIdUser
            // 
            this.lblIdUser.AutoSize = true;
            this.lblIdUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdUser.Location = new System.Drawing.Point(8, 79);
            this.lblIdUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdUser.Name = "lblIdUser";
            this.lblIdUser.Size = new System.Drawing.Size(59, 17);
            this.lblIdUser.TabIndex = 4;
            this.lblIdUser.Text = "ID User:";
            // 
            // txtIdUser
            // 
            this.txtIdUser.Location = new System.Drawing.Point(93, 79);
            this.txtIdUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIdUser.Name = "txtIdUser";
            this.txtIdUser.ReadOnly = true;
            this.txtIdUser.Size = new System.Drawing.Size(241, 22);
            this.txtIdUser.TabIndex = 5;
            // 
            // cblRoles
            // 
            this.cblRoles.FormattingEnabled = true;
            this.cblRoles.Location = new System.Drawing.Point(93, 111);
            this.cblRoles.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cblRoles.Name = "cblRoles";
            this.cblRoles.Size = new System.Drawing.Size(241, 106);
            this.cblRoles.TabIndex = 1;
            this.cblRoles.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.cblRoles_ItemCheck);
            this.cblRoles.Click += new System.EventHandler(this.cblRoles_Click);
            this.cblRoles.SelectedValueChanged += new System.EventHandler(this.cblRoles_SelectedValueChanged);
            // 
            // lblRoles
            // 
            this.lblRoles.AutoSize = true;
            this.lblRoles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoles.Location = new System.Drawing.Point(8, 111);
            this.lblRoles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoles.Name = "lblRoles";
            this.lblRoles.Size = new System.Drawing.Size(48, 17);
            this.lblRoles.TabIndex = 7;
            this.lblRoles.Text = "Roles:";
            // 
            // RolesUsuarioDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(388, 324);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RolesUsuarioDlg";
            this.Text = "RolesUsuarioDlg";
            this.Load += new System.EventHandler(this.RolesUsuarioDlg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblIdUser;
        private System.Windows.Forms.TextBox txtIdUser;
        private System.Windows.Forms.CheckedListBox cblRoles;
        private System.Windows.Forms.Label lblRoles;
    }
}