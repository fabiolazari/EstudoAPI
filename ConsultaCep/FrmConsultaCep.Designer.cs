namespace ConsultaCep
{
	partial class FrmConsultaCep
	{
		/// <summary>
		/// Variável de designer necessária.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpar os recursos que estão sendo usados.
		/// </summary>
		/// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código gerado pelo Windows Form Designer

		/// <summary>
		/// Método necessário para suporte ao Designer - não modifique 
		/// o conteúdo deste método com o editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.GridCep = new System.Windows.Forms.DataGridView();
			this.TxtCep = new System.Windows.Forms.TextBox();
			this.BtnPesquisar = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.BtnGravar = new System.Windows.Forms.Button();
			this.LblGia = new System.Windows.Forms.Label();
			this.LblIbge = new System.Windows.Forms.Label();
			this.LblUnidade = new System.Windows.Forms.Label();
			this.LblUF = new System.Windows.Forms.Label();
			this.lblLocalidade = new System.Windows.Forms.Label();
			this.LblBairro = new System.Windows.Forms.Label();
			this.lblComplemento = new System.Windows.Forms.Label();
			this.LblLogradouro = new System.Windows.Forms.Label();
			this.TxtGia = new System.Windows.Forms.TextBox();
			this.TxtIbge = new System.Windows.Forms.TextBox();
			this.TxtUnidade = new System.Windows.Forms.TextBox();
			this.TxtUF = new System.Windows.Forms.TextBox();
			this.TxtLocalidade = new System.Windows.Forms.TextBox();
			this.TxtBairro = new System.Windows.Forms.TextBox();
			this.TxtComplemento = new System.Windows.Forms.TextBox();
			this.TxtLogradouro = new System.Windows.Forms.TextBox();
			this.BtnLimpar = new System.Windows.Forms.Button();
			this.LblCep = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.GridCep)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// GridCep
			// 
			this.GridCep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.GridCep.Location = new System.Drawing.Point(11, 135);
			this.GridCep.Name = "GridCep";
			this.GridCep.ReadOnly = true;
			this.GridCep.Size = new System.Drawing.Size(833, 267);
			this.GridCep.TabIndex = 0;
			// 
			// TxtCep
			// 
			this.TxtCep.Location = new System.Drawing.Point(45, 12);
			this.TxtCep.Name = "TxtCep";
			this.TxtCep.Size = new System.Drawing.Size(107, 20);
			this.TxtCep.TabIndex = 1;
			// 
			// BtnPesquisar
			// 
			this.BtnPesquisar.Location = new System.Drawing.Point(175, 12);
			this.BtnPesquisar.Name = "BtnPesquisar";
			this.BtnPesquisar.Size = new System.Drawing.Size(75, 23);
			this.BtnPesquisar.TabIndex = 2;
			this.BtnPesquisar.Text = "&Pesquisar";
			this.BtnPesquisar.UseVisualStyleBackColor = true;
			this.BtnPesquisar.Click += new System.EventHandler(this.BtnPesquisar_ClickAsync);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.BtnGravar);
			this.panel1.Controls.Add(this.LblGia);
			this.panel1.Controls.Add(this.LblIbge);
			this.panel1.Controls.Add(this.LblUnidade);
			this.panel1.Controls.Add(this.LblUF);
			this.panel1.Controls.Add(this.lblLocalidade);
			this.panel1.Controls.Add(this.LblBairro);
			this.panel1.Controls.Add(this.lblComplemento);
			this.panel1.Controls.Add(this.LblLogradouro);
			this.panel1.Controls.Add(this.TxtGia);
			this.panel1.Controls.Add(this.TxtIbge);
			this.panel1.Controls.Add(this.TxtUnidade);
			this.panel1.Controls.Add(this.TxtUF);
			this.panel1.Controls.Add(this.TxtLocalidade);
			this.panel1.Controls.Add(this.TxtBairro);
			this.panel1.Controls.Add(this.TxtComplemento);
			this.panel1.Controls.Add(this.TxtLogradouro);
			this.panel1.Controls.Add(this.BtnLimpar);
			this.panel1.Controls.Add(this.LblCep);
			this.panel1.Controls.Add(this.GridCep);
			this.panel1.Controls.Add(this.BtnPesquisar);
			this.panel1.Controls.Add(this.TxtCep);
			this.panel1.Location = new System.Drawing.Point(11, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(859, 415);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(8, 108);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(419, 20);
			this.label1.TabIndex = 21;
			this.label1.Text = "CEP\'s pesquisados e gravados no banco de dados:";
			// 
			// BtnGravar
			// 
			this.BtnGravar.Enabled = false;
			this.BtnGravar.Location = new System.Drawing.Point(364, 12);
			this.BtnGravar.Name = "BtnGravar";
			this.BtnGravar.Size = new System.Drawing.Size(75, 23);
			this.BtnGravar.TabIndex = 4;
			this.BtnGravar.Text = "&Gravar";
			this.BtnGravar.UseVisualStyleBackColor = true;
			this.BtnGravar.Click += new System.EventHandler(this.BtnGravar_Click);
			// 
			// LblGia
			// 
			this.LblGia.AutoSize = true;
			this.LblGia.Location = new System.Drawing.Point(792, 55);
			this.LblGia.Name = "LblGia";
			this.LblGia.Size = new System.Drawing.Size(45, 13);
			this.LblGia.TabIndex = 20;
			this.LblGia.Text = "Cód.Gia";
			// 
			// LblIbge
			// 
			this.LblIbge.AutoSize = true;
			this.LblIbge.Location = new System.Drawing.Point(725, 55);
			this.LblIbge.Name = "LblIbge";
			this.LblIbge.Size = new System.Drawing.Size(54, 13);
			this.LblIbge.TabIndex = 19;
			this.LblIbge.Text = "Cód.IBGE";
			// 
			// LblUnidade
			// 
			this.LblUnidade.AutoSize = true;
			this.LblUnidade.Location = new System.Drawing.Point(615, 55);
			this.LblUnidade.Name = "LblUnidade";
			this.LblUnidade.Size = new System.Drawing.Size(47, 13);
			this.LblUnidade.TabIndex = 18;
			this.LblUnidade.Text = "Unidade";
			// 
			// LblUF
			// 
			this.LblUF.AutoSize = true;
			this.LblUF.Location = new System.Drawing.Point(575, 55);
			this.LblUF.Name = "LblUF";
			this.LblUF.Size = new System.Drawing.Size(24, 13);
			this.LblUF.TabIndex = 17;
			this.LblUF.Text = "UF:";
			// 
			// lblLocalidade
			// 
			this.lblLocalidade.AutoSize = true;
			this.lblLocalidade.Location = new System.Drawing.Point(453, 55);
			this.lblLocalidade.Name = "lblLocalidade";
			this.lblLocalidade.Size = new System.Drawing.Size(62, 13);
			this.lblLocalidade.TabIndex = 16;
			this.lblLocalidade.Text = "Localidade:";
			// 
			// LblBairro
			// 
			this.LblBairro.AutoSize = true;
			this.LblBairro.Location = new System.Drawing.Point(324, 55);
			this.LblBairro.Name = "LblBairro";
			this.LblBairro.Size = new System.Drawing.Size(34, 13);
			this.LblBairro.TabIndex = 15;
			this.LblBairro.Text = "Bairro";
			// 
			// lblComplemento
			// 
			this.lblComplemento.AutoSize = true;
			this.lblComplemento.Location = new System.Drawing.Point(211, 55);
			this.lblComplemento.Name = "lblComplemento";
			this.lblComplemento.Size = new System.Drawing.Size(74, 13);
			this.lblComplemento.TabIndex = 14;
			this.lblComplemento.Text = "Complemento:";
			// 
			// LblLogradouro
			// 
			this.LblLogradouro.AutoSize = true;
			this.LblLogradouro.Location = new System.Drawing.Point(17, 55);
			this.LblLogradouro.Name = "LblLogradouro";
			this.LblLogradouro.Size = new System.Drawing.Size(64, 13);
			this.LblLogradouro.TabIndex = 13;
			this.LblLogradouro.Text = "Logradouro:";
			// 
			// TxtGia
			// 
			this.TxtGia.Enabled = false;
			this.TxtGia.Location = new System.Drawing.Point(795, 71);
			this.TxtGia.Name = "TxtGia";
			this.TxtGia.Size = new System.Drawing.Size(49, 20);
			this.TxtGia.TabIndex = 12;
			// 
			// TxtIbge
			// 
			this.TxtIbge.Enabled = false;
			this.TxtIbge.Location = new System.Drawing.Point(728, 71);
			this.TxtIbge.Name = "TxtIbge";
			this.TxtIbge.Size = new System.Drawing.Size(61, 20);
			this.TxtIbge.TabIndex = 11;
			// 
			// TxtUnidade
			// 
			this.TxtUnidade.Enabled = false;
			this.TxtUnidade.Location = new System.Drawing.Point(618, 71);
			this.TxtUnidade.Name = "TxtUnidade";
			this.TxtUnidade.Size = new System.Drawing.Size(104, 20);
			this.TxtUnidade.TabIndex = 10;
			// 
			// TxtUF
			// 
			this.TxtUF.Enabled = false;
			this.TxtUF.Location = new System.Drawing.Point(578, 71);
			this.TxtUF.Name = "TxtUF";
			this.TxtUF.Size = new System.Drawing.Size(34, 20);
			this.TxtUF.TabIndex = 9;
			// 
			// TxtLocalidade
			// 
			this.TxtLocalidade.Enabled = false;
			this.TxtLocalidade.Location = new System.Drawing.Point(456, 71);
			this.TxtLocalidade.Name = "TxtLocalidade";
			this.TxtLocalidade.Size = new System.Drawing.Size(116, 20);
			this.TxtLocalidade.TabIndex = 8;
			// 
			// TxtBairro
			// 
			this.TxtBairro.Enabled = false;
			this.TxtBairro.Location = new System.Drawing.Point(327, 71);
			this.TxtBairro.Name = "TxtBairro";
			this.TxtBairro.Size = new System.Drawing.Size(123, 20);
			this.TxtBairro.TabIndex = 7;
			// 
			// TxtComplemento
			// 
			this.TxtComplemento.Enabled = false;
			this.TxtComplemento.Location = new System.Drawing.Point(214, 71);
			this.TxtComplemento.Name = "TxtComplemento";
			this.TxtComplemento.Size = new System.Drawing.Size(107, 20);
			this.TxtComplemento.TabIndex = 6;
			// 
			// TxtLogradouro
			// 
			this.TxtLogradouro.Enabled = false;
			this.TxtLogradouro.Location = new System.Drawing.Point(11, 71);
			this.TxtLogradouro.Name = "TxtLogradouro";
			this.TxtLogradouro.Size = new System.Drawing.Size(197, 20);
			this.TxtLogradouro.TabIndex = 5;
			// 
			// BtnLimpar
			// 
			this.BtnLimpar.Location = new System.Drawing.Point(269, 12);
			this.BtnLimpar.Name = "BtnLimpar";
			this.BtnLimpar.Size = new System.Drawing.Size(75, 23);
			this.BtnLimpar.TabIndex = 4;
			this.BtnLimpar.Text = "&Limpar";
			this.BtnLimpar.UseVisualStyleBackColor = true;
			this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
			// 
			// LblCep
			// 
			this.LblCep.AutoSize = true;
			this.LblCep.Location = new System.Drawing.Point(8, 15);
			this.LblCep.Name = "LblCep";
			this.LblCep.Size = new System.Drawing.Size(31, 13);
			this.LblCep.TabIndex = 3;
			this.LblCep.Text = "CEP:";
			// 
			// FrmConsultaCep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoScroll = true;
			this.ClientSize = new System.Drawing.Size(882, 439);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FrmConsultaCep";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Consulta CEP";
			this.Load += new System.EventHandler(this.FrmConsultaCep_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridCep)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView GridCep;
		private System.Windows.Forms.TextBox TxtCep;
		private System.Windows.Forms.Button BtnPesquisar;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button BtnLimpar;
		private System.Windows.Forms.Label LblCep;
		private System.Windows.Forms.TextBox TxtUnidade;
		private System.Windows.Forms.TextBox TxtUF;
		private System.Windows.Forms.TextBox TxtLocalidade;
		private System.Windows.Forms.TextBox TxtBairro;
		private System.Windows.Forms.TextBox TxtComplemento;
		private System.Windows.Forms.TextBox TxtLogradouro;
		private System.Windows.Forms.Label LblGia;
		private System.Windows.Forms.Label LblIbge;
		private System.Windows.Forms.Label LblUnidade;
		private System.Windows.Forms.Label LblUF;
		private System.Windows.Forms.Label lblLocalidade;
		private System.Windows.Forms.Label LblBairro;
		private System.Windows.Forms.Label lblComplemento;
		private System.Windows.Forms.Label LblLogradouro;
		private System.Windows.Forms.TextBox TxtGia;
		private System.Windows.Forms.TextBox TxtIbge;
		private System.Windows.Forms.Button BtnGravar;
		private System.Windows.Forms.Label label1;
	}
}

