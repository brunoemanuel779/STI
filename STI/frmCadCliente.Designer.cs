namespace STI
{
    partial class frmCadCliente
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
            this.lblCpf = new System.Windows.Forms.Label();
            this.mskCpf = new System.Windows.Forms.MaskedTextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.mskTel = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblID = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.lblEstadoc = new System.Windows.Forms.Label();
            this.cbxEstadoc = new System.Windows.Forms.ComboBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(48, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(70, 24);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(142, 59);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(453, 32);
            this.txtNome.TabIndex = 2;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Location = new System.Drawing.Point(48, 123);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(58, 24);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF:";
            this.lblCpf.Click += new System.EventHandler(this.label1_Click);
            // 
            // mskCpf
            // 
            this.mskCpf.Location = new System.Drawing.Point(142, 115);
            this.mskCpf.Mask = "000.000.000.00";
            this.mskCpf.Name = "mskCpf";
            this.mskCpf.Size = new System.Drawing.Size(162, 32);
            this.mskCpf.TabIndex = 3;
            this.mskCpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(48, 289);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(82, 24);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Items.AddRange(new object[] {
            "Acre",
            "Alagoas",
            "Amapá ",
            "Amazonas\t",
            "Bahia ",
            "Ceará",
            "Distrito Federal ",
            "Espírito Santo",
            "Goiás ",
            "Maranhão ",
            "Mato Grosso",
            "Mato Grosso do Sul ",
            "Minas Gerais ",
            "Pará",
            "Paraíba\t ",
            "Paraná",
            "Pernambuco",
            "Piaui",
            "Rio de Janeiro",
            "Rio Grande do Norte",
            "Rio Grande do Sul",
            "Rondônia",
            "Roraima",
            "Santa Catarina",
            "São Paulo",
            "Sergipe",
            "Tocantins"});
            this.cbxEstado.Location = new System.Drawing.Point(142, 286);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(243, 32);
            this.cbxEstado.TabIndex = 7;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(142, 178);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(453, 32);
            this.txtRua.TabIndex = 5;
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(48, 186);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(54, 24);
            this.lblRua.TabIndex = 7;
            this.lblRua.Text = "Rua:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(48, 241);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(82, 24);
            this.lblCidade.TabIndex = 8;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(142, 233);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(433, 32);
            this.txtCidade.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(330, 123);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(95, 24);
            this.lblTelefone.TabIndex = 10;
            this.lblTelefone.Text = "Telefone:";
            // 
            // mskTel
            // 
            this.mskTel.Location = new System.Drawing.Point(431, 115);
            this.mskTel.Mask = "(00) 0000-0000";
            this.mskTel.Name = "mskTel";
            this.mskTel.Size = new System.Drawing.Size(164, 32);
            this.mskTel.TabIndex = 4;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(38, 435);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(123, 35);
            this.btnCadastrar.TabIndex = 9;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(588, 435);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(118, 35);
            this.btnFechar.TabIndex = 13;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(48, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(37, 24);
            this.lblID.TabIndex = 14;
            this.lblID.Text = "ID:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(142, 12);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(155, 32);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(176, 435);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(128, 35);
            this.btnConsultar.TabIndex = 10;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlterar
            // 
            this.btnAlterar.Location = new System.Drawing.Point(321, 435);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(113, 35);
            this.btnAlterar.TabIndex = 11;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // lblEstadoc
            // 
            this.lblEstadoc.AutoSize = true;
            this.lblEstadoc.Location = new System.Drawing.Point(48, 351);
            this.lblEstadoc.Name = "lblEstadoc";
            this.lblEstadoc.Size = new System.Drawing.Size(128, 24);
            this.lblEstadoc.TabIndex = 18;
            this.lblEstadoc.Text = "Estado Civil:";
            // 
            // cbxEstadoc
            // 
            this.cbxEstadoc.FormattingEnabled = true;
            this.cbxEstadoc.Items.AddRange(new object[] {
            "Solteiro",
            "Casado",
            "Divorciado"});
            this.cbxEstadoc.Location = new System.Drawing.Point(193, 343);
            this.cbxEstadoc.Name = "cbxEstadoc";
            this.cbxEstadoc.Size = new System.Drawing.Size(192, 32);
            this.cbxEstadoc.TabIndex = 8;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(462, 435);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(97, 35);
            this.btnExcluir.TabIndex = 12;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // frmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 482);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.cbxEstadoc);
            this.Controls.Add(this.lblEstadoc);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.mskTel);
            this.Controls.Add(this.lblTelefone);
            this.Controls.Add(this.txtCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.lblRua);
            this.Controls.Add(this.txtRua);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.mskCpf);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblNome);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCadCliente";
            this.Text = "Cadastro De Clientes";
            this.Load += new System.EventHandler(this.CadCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblID;
        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.MaskedTextBox mskCpf;
        public System.Windows.Forms.ComboBox cbxEstado;
        public System.Windows.Forms.TextBox txtRua;
        public System.Windows.Forms.TextBox txtCidade;
        public System.Windows.Forms.MaskedTextBox mskTel;
        public System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Label lblEstadoc;
        private System.Windows.Forms.ComboBox cbxEstadoc;
        private System.Windows.Forms.Button btnExcluir;
    }
}