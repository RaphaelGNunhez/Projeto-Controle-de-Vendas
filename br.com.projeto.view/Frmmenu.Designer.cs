
namespace Projeto_Controle_de_Vendas.br.com.projeto.view
{
    partial class Frmmenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.menuNovaVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuHistoricoVenda = new System.Windows.Forms.ToolStripMenuItem();
            this.menuProdutos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFornecedores = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaFornecedor = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTrocar = new System.Windows.Forms.ToolStripMenuItem();
            this.menuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaCliente = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCadastroFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.menuConsultaFuncionario = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtData = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCliente,
            this.menuFuncionarios,
            this.menuFornecedores,
            this.menuProdutos,
            this.menuVendas,
            this.menuConfig});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 56);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuVendas
            // 
            this.menuVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNovaVenda,
            this.menuHistoricoVenda});
            this.menuVendas.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.menuVendas.Image = global::Projeto_Controle_de_Vendas.Properties.Resources._7581538_product_refund_return_service_product_recall_icon;
            this.menuVendas.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuVendas.Name = "menuVendas";
            this.menuVendas.Size = new System.Drawing.Size(113, 52);
            this.menuVendas.Text = "Vendas";
            // 
            // menuNovaVenda
            // 
            this.menuNovaVenda.Name = "menuNovaVenda";
            this.menuNovaVenda.Size = new System.Drawing.Size(195, 22);
            this.menuNovaVenda.Text = "Nova Venda";
            this.menuNovaVenda.Click += new System.EventHandler(this.cadastroDeClientesToolStripMenuItem_Click);
            // 
            // menuHistoricoVenda
            // 
            this.menuHistoricoVenda.Name = "menuHistoricoVenda";
            this.menuHistoricoVenda.Size = new System.Drawing.Size(195, 22);
            this.menuHistoricoVenda.Text = "Histórico de Vendas";
            this.menuHistoricoVenda.Click += new System.EventHandler(this.menuHistoricoVenda_Click);
            // 
            // menuProdutos
            // 
            this.menuProdutos.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroProduto,
            this.menuConsultaProduto});
            this.menuProdutos.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.menuProdutos.Image = global::Projeto_Controle_de_Vendas.Properties.Resources._9044816_product_icon;
            this.menuProdutos.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuProdutos.Name = "menuProdutos";
            this.menuProdutos.Size = new System.Drawing.Size(120, 52);
            this.menuProdutos.Text = "Produtos";
            // 
            // menuCadastroProduto
            // 
            this.menuCadastroProduto.Name = "menuCadastroProduto";
            this.menuCadastroProduto.Size = new System.Drawing.Size(205, 22);
            this.menuCadastroProduto.Text = "Cadastro de Produtos";
            this.menuCadastroProduto.Click += new System.EventHandler(this.menuCadastroProduto_Click);
            // 
            // menuConsultaProduto
            // 
            this.menuConsultaProduto.Name = "menuConsultaProduto";
            this.menuConsultaProduto.Size = new System.Drawing.Size(205, 22);
            this.menuConsultaProduto.Text = "Consulta de Produtos";
            this.menuConsultaProduto.Click += new System.EventHandler(this.menuConsultaProduto_Click);
            // 
            // menuFornecedores
            // 
            this.menuFornecedores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroFornecedor,
            this.menuConsultaFornecedor});
            this.menuFornecedores.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.menuFornecedores.Image = global::Projeto_Controle_de_Vendas.Properties.Resources._8675736_ic_fluent_vehicle_truck_profile_icon;
            this.menuFornecedores.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFornecedores.Name = "menuFornecedores";
            this.menuFornecedores.Size = new System.Drawing.Size(150, 52);
            this.menuFornecedores.Text = "Fornecedores";
            // 
            // menuCadastroFornecedor
            // 
            this.menuCadastroFornecedor.Name = "menuCadastroFornecedor";
            this.menuCadastroFornecedor.Size = new System.Drawing.Size(235, 22);
            this.menuCadastroFornecedor.Text = "Cadastro de Fornecedores";
            this.menuCadastroFornecedor.Click += new System.EventHandler(this.menuCadastroFornecedor_Click);
            // 
            // menuConsultaFornecedor
            // 
            this.menuConsultaFornecedor.Name = "menuConsultaFornecedor";
            this.menuConsultaFornecedor.Size = new System.Drawing.Size(235, 22);
            this.menuConsultaFornecedor.Text = "Consulta de Fornecedores";
            this.menuConsultaFornecedor.Click += new System.EventHandler(this.menuConsultaFornecedor_Click);
            // 
            // menuConfig
            // 
            this.menuConfig.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuTrocar,
            this.menuSair});
            this.menuConfig.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.menuConfig.Image = global::Projeto_Controle_de_Vendas.Properties.Resources._1564529_mechanism_options_settings_configuration_setting_icon;
            this.menuConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuConfig.Name = "menuConfig";
            this.menuConfig.Size = new System.Drawing.Size(155, 52);
            this.menuConfig.Text = "Configurações";
            // 
            // menuTrocar
            // 
            this.menuTrocar.Name = "menuTrocar";
            this.menuTrocar.Size = new System.Drawing.Size(180, 22);
            this.menuTrocar.Text = "Trocar de Usuário";
            this.menuTrocar.Click += new System.EventHandler(this.menuTrocar_Click);
            // 
            // menuSair
            // 
            this.menuSair.Name = "menuSair";
            this.menuSair.Size = new System.Drawing.Size(180, 22);
            this.menuSair.Text = "Sair do Sistema";
            this.menuSair.Click += new System.EventHandler(this.menuSair_Click);
            // 
            // menuCliente
            // 
            this.menuCliente.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroCliente,
            this.menuConsultaCliente});
            this.menuCliente.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuCliente.Image = global::Projeto_Controle_de_Vendas.Properties.Resources._5402435_account_profile_user_avatar_man_icon1;
            this.menuCliente.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuCliente.Name = "menuCliente";
            this.menuCliente.Size = new System.Drawing.Size(116, 52);
            this.menuCliente.Text = "Clientes";
            // 
            // menuCadastroCliente
            // 
            this.menuCadastroCliente.Name = "menuCadastroCliente";
            this.menuCadastroCliente.Size = new System.Drawing.Size(201, 22);
            this.menuCadastroCliente.Text = "Cadastro de Clientes";
            this.menuCadastroCliente.Click += new System.EventHandler(this.menuCadastroCliente_Click);
            // 
            // menuConsultaCliente
            // 
            this.menuConsultaCliente.Name = "menuConsultaCliente";
            this.menuConsultaCliente.Size = new System.Drawing.Size(201, 22);
            this.menuConsultaCliente.Text = "Consulta de Clientes";
            this.menuConsultaCliente.Click += new System.EventHandler(this.menuConsultaCliente_Click);
            // 
            // menuFuncionarios
            // 
            this.menuFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCadastroFuncionario,
            this.menuConsultaFuncionario});
            this.menuFuncionarios.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.menuFuncionarios.Image = global::Projeto_Controle_de_Vendas.Properties.Resources._309034_worker_man_profile_user_icon;
            this.menuFuncionarios.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.menuFuncionarios.Name = "menuFuncionarios";
            this.menuFuncionarios.Size = new System.Drawing.Size(142, 52);
            this.menuFuncionarios.Text = "Funcionarios";
            this.menuFuncionarios.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menuCadastroFuncionario
            // 
            this.menuCadastroFuncionario.Name = "menuCadastroFuncionario";
            this.menuCadastroFuncionario.Size = new System.Drawing.Size(227, 22);
            this.menuCadastroFuncionario.Text = "Cadastro de Funcionarios";
            this.menuCadastroFuncionario.Click += new System.EventHandler(this.menuCadastroFuncionario_Click);
            // 
            // menuConsultaFuncionario
            // 
            this.menuConsultaFuncionario.Name = "menuConsultaFuncionario";
            this.menuConsultaFuncionario.Size = new System.Drawing.Size(227, 22);
            this.menuConsultaFuncionario.Text = "Consulta de Funcionarios";
            this.menuConsultaFuncionario.Click += new System.EventHandler(this.menuConsultaFuncionario_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.txtData,
            this.toolStripStatusLabel3,
            this.txtHora,
            this.toolStripStatusLabel5,
            this.txtUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(867, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(75, 17);
            this.toolStripStatusLabel1.Text = "Data atual:";
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(76, 17);
            this.txtData.Text = "03/07/2025";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(73, 17);
            this.toolStripStatusLabel3.Text = "Hora atual:";
            // 
            // txtHora
            // 
            this.txtHora.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.txtHora.Name = "txtHora";
            this.txtHora.Size = new System.Drawing.Size(39, 17);
            this.txtHora.Text = "13:04";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(100, 17);
            this.toolStripStatusLabel5.Text = "Usuário logado:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(57, 17);
            this.txtUsuario.Text = "Raphael";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frmmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frmmenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frmmenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuCliente;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroCliente;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaCliente;
        private System.Windows.Forms.ToolStripMenuItem menuFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaFuncionario;
        private System.Windows.Forms.ToolStripMenuItem menuVendas;
        private System.Windows.Forms.ToolStripMenuItem menuNovaVenda;
        private System.Windows.Forms.ToolStripMenuItem menuFornecedores;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroFornecedor;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaFornecedor;
        private System.Windows.Forms.ToolStripMenuItem menuCadastroProduto;
        private System.Windows.Forms.ToolStripMenuItem menuConsultaProduto;
        private System.Windows.Forms.ToolStripMenuItem menuConfig;
        private System.Windows.Forms.ToolStripMenuItem menuTrocar;
        private System.Windows.Forms.ToolStripMenuItem menuSair;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel txtData;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel txtHora;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripMenuItem menuProdutos;
        public System.Windows.Forms.ToolStripMenuItem menuHistoricoVenda;
        public System.Windows.Forms.ToolStripStatusLabel txtUsuario;
        private System.Windows.Forms.Timer timer1;
    }
}