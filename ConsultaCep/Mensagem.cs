using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsultaCep
{
	public class Mensagem
	{
		public List<string> _lista;
		public List<string> Lista
		{
			get
			{
				return _lista;
			}
			set
			{
				_lista = value;
			}
		}

		public Mensagem(string mensagem)
		{
			_lista = new List<string>
			{
				mensagem
			};
		}
	}
}
