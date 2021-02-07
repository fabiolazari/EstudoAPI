using Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsultaCep
{
	public partial class FrmConsultaCep : Form
	{
		string Uri = "https://viacep.com.br/ws";
		BindingSource dados = new BindingSource();
		BindingSource dadosGravado = new BindingSource();
		CEP cep = new CEP();
		CEP cepGravado = new CEP();

		public FrmConsultaCep()
		{
			InitializeComponent();
		}

		public void LimparCampos()
		{
			BtnPesquisar.Enabled = true;
			TxtCep.Enabled = true;
			TxtCep.Text = "";
			TxtLogradouro.DataBindings.Clear();
			TxtComplemento.DataBindings.Clear();
			TxtBairro.DataBindings.Clear();
			TxtLocalidade.DataBindings.Clear();
			TxtUF.DataBindings.Clear();
			TxtUnidade.DataBindings.Clear();
			TxtIbge.DataBindings.Clear();
			TxtGia.DataBindings.Clear();
			TxtCep.Focus();
		}

		public void CarregaGrid()
		{
			//Pega todos os dados da tabela
			List<CEP> pegaDados = new List<CEP>();
			
			try
			{
				pegaDados = new BindingList<CEP>(new CEP().GetAll()).ToList();
			}
			catch (Exception)
			{
				pegaDados = null;
			}

			if (pegaDados == null)
			{
				GridCep.Columns.Add("mensagem", "A TABELA DE CEP ESTÁ VAZIA!");
				GridCep.Columns["mensagem"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
				GridCep.Columns["mensagem"].Width = 830;
				GridCep.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			}
			else
			{
				GridCep.Columns.Clear();
				dadosGravado.DataSource = pegaDados;
				GridCep.DataSource = dadosGravado;
			}
		}

		private void FrmConsultaCep_Load(object sender, EventArgs e)
		{
			GridCep.AllowUserToAddRows = false;
			GridCep.AllowUserToDeleteRows = false;
			GridCep.EditMode = DataGridViewEditMode.EditProgrammatically;
			GridCep.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			GridCep.RowHeadersVisible = false;
			GridCep.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
			GridCep.RowTemplate.Resizable = DataGridViewTriState.False;
			GridCep.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
			CarregaGrid();
		}

		private async void BtnPesquisar_ClickAsync(object sender, EventArgs e)
		{
			BtnPesquisar.Enabled = false;
			BtnGravar.Enabled = true;
			TxtCep.Enabled = false;

			string Url = String.Format("{0}/{1}/json/", Uri, TxtCep.Text.Trim());
			
			using (var client = new HttpClient())
			{
				using (var response = await client.GetAsync(Url))
				{
					if (response.IsSuccessStatusCode)
					{
						var ProdutoJsonString = await response.Content.ReadAsStringAsync();
						cep = JsonConvert.DeserializeObject<CEP>(ProdutoJsonString);
						dados.DataSource = cep;

						//Carregando TextBoxes
						TxtLogradouro.DataBindings.Add("Text", dados, "logradouro", true, DataSourceUpdateMode.OnPropertyChanged);
						TxtComplemento.DataBindings.Add("Text", dados, "complemento", true, DataSourceUpdateMode.OnPropertyChanged);
						TxtBairro.DataBindings.Add("Text", dados, "bairro", true, DataSourceUpdateMode.OnPropertyChanged);
						TxtLocalidade.DataBindings.Add("Text", dados, "localidade", true, DataSourceUpdateMode.OnPropertyChanged);
						TxtUF.DataBindings.Add("Text", dados, "uf", true, DataSourceUpdateMode.OnPropertyChanged);
						TxtUnidade.DataBindings.Add("Text", dados, "unidade", true, DataSourceUpdateMode.OnPropertyChanged);
						TxtIbge.DataBindings.Add("Text", dados, "ibge", true, DataSourceUpdateMode.OnPropertyChanged);
						TxtGia.DataBindings.Add("Text", dados, "gia", true, DataSourceUpdateMode.OnPropertyChanged);
					}
					else
					{
						MessageBox.Show("Não foi possível obter o dados: " + response.StatusCode);
						LimparCampos();
					}
				}
			}
		}

		private void BtnLimpar_Click(object sender, EventArgs e)
		{
			dados.RemoveCurrent();
			LimparCampos();
		}

		private void BtnGravar_Click(object sender, EventArgs e)
		{
			//Rotina para gravar no banco
			try
			{
				((CEP)dados.Current).Insert();
				CarregaGrid();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			dados.RemoveCurrent();
			LimparCampos();
			BtnGravar.Enabled = false;
		}
	}
}
