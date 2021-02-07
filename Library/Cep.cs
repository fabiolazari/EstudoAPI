using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library
{
	public class CEP : Backwork<CEP> , ICRUD, IDisposable
	{
		private long _idCep;
		[Key]
		[DataObjectField(true, true, false)]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public long IdCep
		{
			get
			{
				return _idCep;
			}
			set
			{
				_idCep = value;
				this._isModified = true;
			}
		}

		private string _cep;
		[DisplayName("Cep")]
		[DataObjectField(false, false, false)]
		public string Cep
		{
			get
			{
				return _cep;
			}
			set
			{
				if (value == "")
				{
					throw new ValidacaoException("Código do CEP não deve ser vazio!");
				}
				_cep = value;
				this._isModified = true;
				
			}
		}

		private string _logradouro;
		[DisplayName("Logradouro")]
		[DataObjectField(false, false, false)]
		public string Logradouro
		{
			get
			{
				return _logradouro;
			}
			set
			{
				_logradouro = value;
				this._isModified = true;
			}
		}

		private string _complemento;
		[DisplayName("Complemento")]
		[DataObjectField(false, false, false)]
		public string Complemento
		{
			get
			{
				return _complemento;
			}
			set
			{
				_complemento = value;
				this._isModified = true;
			}
		}

		private string _bairro;
		[DisplayName("Bairro")]
		[DataObjectField(false, false, false)]
		public string Bairro
		{
			get
			{
				return _bairro;
			}
			set
			{
				_bairro = value;
				this._isModified = true;
			}
		}


		private string _localidade;
		[DisplayName("Localidade")]
		[DataObjectField(false, false, false)]
		public string Localidade
		{
			get
			{
				return _localidade;
			}
			set
			{
				_localidade = value;
				this._isModified = true;
			}
		}

		private string _uf;
		[DisplayName("UF")]
		[DataObjectField(false, false, false)]
		public string Uf
		{
			get
			{
				return _uf;
			}
			set
			{
				_uf = value;
				this._isModified = true;
			}
		}

		private string _unidade;
		[DisplayName("Unidade")]
		[DataObjectField(false, false, false)]
		public string Unidade
		{
			get
			{
				return _unidade;
			}
			set
			{
				_unidade = value;
				this._isModified = true;
			}
		}

		private long _ibge;
		[DisplayName("Cód.IBGE")]
		[DataObjectField(false, false, false)]
		public long Ibge
		{
			get
			{
				return _ibge;
			}
			set
			{
				_ibge = value;
				this._isModified = true;
			}
		}

		private int _gia;
		[DisplayName("Cód.Gia")]
		[DataObjectField(false, false, false)]
		public int Gia
		{
			get
			{
				return _gia;
			}
			set
			{
				_gia = value;
				this._isModified = true;
			}
		}
		[Browsable(false)]
		public bool IsNew { get; }

		private bool _isModified;
		[Browsable(false)]
		public bool IsModified => _isModified;

		public CEP()
		{
			this.IsNew = true;
			this._isModified = false;
		}

		public CEP(long id)
		{
			SetSelf(GetByPrimaryKey(id));
			this.IsNew = false;
			this._isModified = false;
		}
		
		public void Dispose()
		{
			this.Gravar();
		}
	}
}
