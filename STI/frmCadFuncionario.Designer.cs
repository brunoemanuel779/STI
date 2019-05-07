namespace STI
{
    partial class frmCadFuncionario
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
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblDataNasc = new System.Windows.Forms.Label();
            this.mskDatanasc = new System.Windows.Forms.MaskedTextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblCpf = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblTel = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtSalario = new System.Windows.Forms.Label();
            this.mskSal = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(18, 45);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(66, 22);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(96, 42);
            this.txtNome.MaxLength = 40;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(246, 29);
            this.txtNome.TabIndex = 1;
            // 
            // lblDataNasc
            // 
            this.lblDataNasc.AutoSize = true;
            this.lblDataNasc.Location = new System.Drawing.Point(348, 49);
            this.lblDataNasc.Name = "lblDataNasc";
            this.lblDataNasc.Size = new System.Drawing.Size(102, 22);
            this.lblDataNasc.TabIndex = 2;
            this.lblDataNasc.Text = "Data Nasc:";
            // 
            // mskDatanasc
            // 
            this.mskDatanasc.Location = new System.Drawing.Point(456, 42);
            this.mskDatanasc.Mask = "00/00/0000";
            this.mskDatanasc.Name = "mskDatanasc";
            this.mskDatanasc.Size = new System.Drawing.Size(109, 29);
            this.mskDatanasc.TabIndex = 2;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(18, 155);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(49, 22);
            this.lblRua.TabIndex = 4;
            this.lblRua.Text = "Rua:";
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(96, 148);
            this.txtRua.MaxLength = 30;
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(469, 29);
            this.txtRua.TabIndex = 5;
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(18, 108);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(54, 22);
            this.lblCpf.TabIndex = 6;
            this.lblCpf.Text = "CPF:";
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(96, 101);
            this.mskCpf.Mask = "000.000.000-00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(151, 29);
            this.mskCpf.TabIndex = 3;
            this.mskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblTel
            // 
            this.lblTel.AutoSize = true;
            this.lblTel.Location = new System.Drawing.Point(288, 108);
            this.lblTel.Name = "lblTel";
            this.lblTel.Size = new System.Drawing.Size(89, 22);
            this.lblTel.TabIndex = 8;
            this.lblTel.Text = "Telefone:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(383, 101);
            this.mskTel.Mask = "(00)0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(182, 29);
            this.mskTel.TabIndex = 4;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(18, 209);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(76, 22);
            this.lblCidade.TabIndex = 10;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(96, 202);
            this.txtCidade.MaxLength = 30;
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(469, 29);
            this.txtCidade.TabIndex = 6;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(22, 262);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(75, 22);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Acre\t ",
            "Alagoas\t ",
            "Amapá\t ",
            "Amazonas\t ",
            "Bahia\t ",
            "Ceará ",
            "Distrito Federal\t ",
            "Espírito Santo ",
            "Goiás\t ",
            "Maranhão\tSão Luís\t ",
            "Mato Grosso\t ",
            "Mato Grosso do Sul\t ",
            "Minas Gerais\t ",
            "Pará\t ",
            "Paraíba\t\t ",
            "Paraná\t ",
            "Pernambuco ",
            "Piaui\t ",
            "Rio de Janeiro\t\t ",
            "Rio Grande do Norte\t ",
            "Rio Grande do Sul\t\t ",
            "Rondônia\t\t ",
            "Roraima\t",
            "Santa Catarina\t ",
            "São Paulo\t ",
            "Sergipe\t\t ",
            "Tocantins\t"});
            this.cbxEstado.Location = new System.Drawing.Point(96, 254);
            this.cbxEstado.MaxLength = 30;
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(243, 30);
            this.cbxEstado.TabIndex = 7;
            // 
            // txtSalario
            // 
            this.txtSalario.AutoSize = true;
            this.txtSalario.Location = new System.Drawing.Point(345, 262);
            this.txtSalario.Name = "txtSalario";
            this.txtSalario.Size = new System.Drawing.Size(73, 22);
            this.txtSalario.TabIndex = 14;
            this.txtSalario.Text = "Salario:";
            // 
            // mskSal
            // 
            this.mskSal.Location = new System.Drawing.Point(424, 254);
            this.mskSal.Mask = "$ 00,000.00";
            this.mskSal.Name = "mskSal";
            this.mskSal.Size = new System.Drawing.Size(141, 29);
            this.mskSal.TabIndex = 8;
            this.mskSal.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(170, 337);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(126, 35);
            this.btnCadastro.TabIndex = 9;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(320, 337);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(130, 35);
            this.btnFechar.TabIndex = 10;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // frmCadFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 442);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.mskSal);
            this.Controls.Add(this.txtSalario);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.lblTel);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.mskDatanasc);
            this.Controls.Add(this.lblDataNasc);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmCadFuncionario";
            this.Text = "Cadastro de funcionarios";
            this.Load += new System.EventHandler(this.frmCadFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblDataNasc;
        private System.Windows.Forms.MaskedTextBox mskDatanasc;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.MaskedTextBox mskCpf;
        private System.Windows.Forms.Label lblTel;
        private System.Windows.Forms.MaskedTextBox mskTel;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.Label txtSalario;
        private System.Windows.Forms.MaskedTextBox mskSal;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnFechar;
    }
}