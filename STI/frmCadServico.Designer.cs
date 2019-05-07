namespace STI
{
    partial class frmCadServico
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
            this.lblFunc = new System.Windows.Forms.Label();
            this.cbxFunc = new System.Windows.Forms.ComboBox();
            this.lblServ = new System.Windows.Forms.Label();
            this.cbxServ = new System.Windows.Forms.ComboBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.lblCliente = new System.Windows.Forms.Label();
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblFunc
            // 
            this.lblFunc.AutoSize = true;
            this.lblFunc.Location = new System.Drawing.Point(13, 50);
            this.lblFunc.Name = "lblFunc";
            this.lblFunc.Size = new System.Drawing.Size(108, 22);
            this.lblFunc.TabIndex = 0;
            this.lblFunc.Text = "Funcionario";
            // 
            // cbxFunc
            // 
            this.cbxFunc.FormattingEnabled = true;
            this.cbxFunc.Location = new System.Drawing.Point(127, 42);
            this.cbxFunc.Name = "cbxFunc";
            this.cbxFunc.Size = new System.Drawing.Size(355, 30);
            this.cbxFunc.TabIndex = 1;
            // 
            // lblServ
            // 
            this.lblServ.AutoSize = true;
            this.lblServ.Location = new System.Drawing.Point(17, 156);
            this.lblServ.Name = "lblServ";
            this.lblServ.Size = new System.Drawing.Size(79, 22);
            this.lblServ.TabIndex = 2;
            this.lblServ.Text = "Serviço:";
            this.lblServ.Click += new System.EventHandler(this.lblServ_Click);
            // 
            // cbxServ
            // 
            this.cbxServ.FormattingEnabled = true;
            this.cbxServ.Items.AddRange(new object[] {
            "Desenvolvimento de Sistemas",
            "Manutencão de Sistema",
            "Serviços de TI",
            "Serviços de Redes"});
            this.cbxServ.Location = new System.Drawing.Point(127, 148);
            this.cbxServ.Name = "cbxServ";
            this.cbxServ.Size = new System.Drawing.Size(355, 30);
            this.cbxServ.TabIndex = 3;
            this.cbxServ.SelectedIndexChanged += new System.EventHandler(this.cbxServ_SelectedIndexChanged);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Location = new System.Drawing.Point(21, 206);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(218, 22);
            this.lblInfo.TabIndex = 4;
            this.lblInfo.Text = "Informaçoes do Serviço:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(21, 231);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(457, 138);
            this.textBox1.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(308, 385);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 31);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(17, 104);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(74, 22);
            this.lblCliente.TabIndex = 7;
            this.lblCliente.Text = "Cliente:";
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(127, 96);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(355, 30);
            this.cbxCliente.TabIndex = 8;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(403, 385);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 31);
            this.btnFechar.TabIndex = 9;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmCadServiço
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 442);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.cbxCliente);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.cbxServ);
            this.Controls.Add(this.lblServ);
            this.Controls.Add(this.cbxFunc);
            this.Controls.Add(this.lblFunc);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmCadServiço";
            this.Text = "Cadastro de Serviços";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFunc;
        private System.Windows.Forms.ComboBox cbxFunc;
        private System.Windows.Forms.Label lblServ;
        private System.Windows.Forms.ComboBox cbxServ;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Button btnFechar;
    }
}