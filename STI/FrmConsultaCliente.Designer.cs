namespace STI
{
    partial class FrmConsultaCliente
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
            this.btnSeleionar = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.btnSelecionar = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancelar.Location = new System.Drawing.Point(422, 442);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(240, 61);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "     Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnSeleionar
            // 
            this.btnSeleionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSeleionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeleionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeleionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSeleionar.Location = new System.Drawing.Point(-234, 442);
            this.btnSeleionar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleionar.Name = "btnSeleionar";
            this.btnSeleionar.Size = new System.Drawing.Size(267, 61);
            this.btnSeleionar.TabIndex = 4;
            this.btnSeleionar.Text = "   Selecionar";
            this.btnSeleionar.UseVisualStyleBackColor = false;
            // 
            // dgvCliente
            // 
            this.dgvCliente.AllowDrop = true;
            this.dgvCliente.AllowUserToAddRows = false;
            this.dgvCliente.AllowUserToDeleteRows = false;
            this.dgvCliente.AllowUserToOrderColumns = true;
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(7, 25);
            this.dgvCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.ReadOnly = true;
            this.dgvCliente.Size = new System.Drawing.Size(506, 302);
            this.dgvCliente.TabIndex = 1;
            // 
            // btnSelecionar
            // 
            this.btnSelecionar.BackColor = System.Drawing.Color.Transparent;
            this.btnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelecionar.Image = global::STI.Properties.Resources.selecionar;
            this.btnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelecionar.Location = new System.Drawing.Point(7, 343);
            this.btnSelecionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSelecionar.Name = "btnSelecionar";
            this.btnSelecionar.Size = new System.Drawing.Size(158, 46);
            this.btnSelecionar.TabIndex = 2;
            this.btnSelecionar.Text = "   Selecionar";
            this.btnSelecionar.UseVisualStyleBackColor = false;
            this.btnSelecionar.Click += new System.EventHandler(this.btnSelecionar_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::STI.Properties.Resources.cancelar;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.Location = new System.Drawing.Point(381, 343);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(132, 46);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "     Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // FrmConsultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 398);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSelecionar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSeleionar);
            this.Controls.Add(this.dgvCliente);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmConsultaCliente";
            this.Text = "Consulta Cliente";
            this.Load += new System.EventHandler(this.FrmConsultaCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSeleionar;
        internal System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.Button btnSelecionar;
        private System.Windows.Forms.Button btnCancel;
    }
}