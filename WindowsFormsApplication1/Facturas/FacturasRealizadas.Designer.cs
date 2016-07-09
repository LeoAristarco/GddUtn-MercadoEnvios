namespace WindowsFormsApplication1.Facturas
{
    partial class FacturasRealizadas
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
            this.buscarButton = new System.Windows.Forms.Button();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.nombreUserLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.formaDePagoComboBox = new System.Windows.Forms.ComboBox();
            this.volverButton = new System.Windows.Forms.Button();
            this.rendirButton = new System.Windows.Forms.Button();
            this.dgvOperaciones = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // buscarButton
            // 
            this.buscarButton.Location = new System.Drawing.Point(651, 9);
            this.buscarButton.Margin = new System.Windows.Forms.Padding(4);
            this.buscarButton.Name = "buscarButton";
            this.buscarButton.Size = new System.Drawing.Size(100, 28);
            this.buscarButton.TabIndex = 19;
            this.buscarButton.Text = "Buscar";
            this.buscarButton.UseVisualStyleBackColor = true;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Location = new System.Drawing.Point(471, 9);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(132, 22);
            this.usernameTextBox.TabIndex = 18;
            // 
            // nombreUserLabel
            // 
            this.nombreUserLabel.AutoSize = true;
            this.nombreUserLabel.Location = new System.Drawing.Point(390, 9);
            this.nombreUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nombreUserLabel.Name = "nombreUserLabel";
            this.nombreUserLabel.Size = new System.Drawing.Size(73, 17);
            this.nombreUserLabel.TabIndex = 17;
            this.nombreUserLabel.Text = "Username";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(623, 459);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(331, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Los campos marcados con (*) son OBLIGATORIOS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(517, 385);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Forma de Pago (*):";
            // 
            // formaDePagoComboBox
            // 
            this.formaDePagoComboBox.FormattingEnabled = true;
            this.formaDePagoComboBox.Location = new System.Drawing.Point(651, 385);
            this.formaDePagoComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.formaDePagoComboBox.Name = "formaDePagoComboBox";
            this.formaDePagoComboBox.Size = new System.Drawing.Size(160, 24);
            this.formaDePagoComboBox.TabIndex = 12;
            // 
            // volverButton
            // 
            this.volverButton.Location = new System.Drawing.Point(17, 385);
            this.volverButton.Margin = new System.Windows.Forms.Padding(4);
            this.volverButton.Name = "volverButton";
            this.volverButton.Size = new System.Drawing.Size(101, 53);
            this.volverButton.TabIndex = 14;
            this.volverButton.Text = "< < Volver";
            this.volverButton.UseVisualStyleBackColor = true;
            // 
            // rendirButton
            // 
            this.rendirButton.Location = new System.Drawing.Point(857, 385);
            this.rendirButton.Margin = new System.Windows.Forms.Padding(4);
            this.rendirButton.Name = "rendirButton";
            this.rendirButton.Size = new System.Drawing.Size(100, 53);
            this.rendirButton.TabIndex = 13;
            this.rendirButton.Text = "Generar Factura";
            this.rendirButton.UseVisualStyleBackColor = true;
            // 
            // dgvOperaciones
            // 
            this.dgvOperaciones.AllowUserToAddRows = false;
            this.dgvOperaciones.AllowUserToDeleteRows = false;
            this.dgvOperaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOperaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvOperaciones.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOperaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOperaciones.GridColor = System.Drawing.SystemColors.Window;
            this.dgvOperaciones.Location = new System.Drawing.Point(17, 44);
            this.dgvOperaciones.Margin = new System.Windows.Forms.Padding(4);
            this.dgvOperaciones.Name = "dgvOperaciones";
            this.dgvOperaciones.ReadOnly = true;
            this.dgvOperaciones.RowHeadersVisible = false;
            this.dgvOperaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOperaciones.Size = new System.Drawing.Size(940, 304);
            this.dgvOperaciones.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ventas que aún no fueron facturadas:";
            // 
            // FacturarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 491);
            this.Controls.Add(this.buscarButton);
            this.Controls.Add(this.usernameTextBox);
            this.Controls.Add(this.nombreUserLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.formaDePagoComboBox);
            this.Controls.Add(this.volverButton);
            this.Controls.Add(this.rendirButton);
            this.Controls.Add(this.dgvOperaciones);
            this.Controls.Add(this.label1);
            this.Name = "FacturarForm";
            this.Text = "FacturarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOperaciones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buscarButton;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Label nombreUserLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox formaDePagoComboBox;
        private System.Windows.Forms.Button volverButton;
        private System.Windows.Forms.Button rendirButton;
        private System.Windows.Forms.DataGridView dgvOperaciones;
        private System.Windows.Forms.Label label1;
    }
}