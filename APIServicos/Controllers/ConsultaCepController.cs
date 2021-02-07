using Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace APIServicos.Controllers
{
    public class ConsultaCepController : ApiController
    {
        // GET: api/ConsultaCep
        public IHttpActionResult Get()
        {
			try
			{
				return Ok(new CEP().GetAll());
			}
			catch (Exception)
			{
				return NotFound();
			}
        }

        // GET: api/ConsultaCep/5
        public IHttpActionResult Get(string cep)
        {
			int traco = cep.IndexOf("-");
			int total = (cep.Trim()).Length;
			string Ncep = cep;

			if ((traco <= 0) && (total == 8))
			{
				Ncep = (cep.Trim()).Substring(0, 5) + "-" + (cep.Trim()).Substring(5, 3);
			}

			List<CEP> _return = new CEP().GetAll().Where(x => x.Cep == Ncep).ToList();

			if (_return.Count == 0)
			{
				return NotFound();
			}
			
			return Ok(_return);
		}

        // POST: api/ConsultaCep
        public IHttpActionResult Post([FromBody]CEP value)
		{
			try
			{
				value.Insert();
			}
			catch (Exception ex)
			{
				throw ex;
			}
			return Ok();
		}

        // PUT: api/ConsultaCep/5
        public IHttpActionResult Put(int id, [FromBody]CEP value)
		{
			CEP cep = new CEP(id)
			{
				Cep = value.Cep,
				Logradouro = value.Logradouro,
				Complemento = value.Complemento,
				Bairro = value.Bairro,
				Localidade = value.Localidade,
				Uf = value.Uf,
				Unidade = value.Unidade,
				Ibge = value.Ibge,
				Gia = value.Gia
			};

			try
			{
				cep.Update();
			}
			catch (Exception)
			{
				throw;
			}
			return Ok();
		}

        // DELETE: api/ConsultaCep/5
        public IHttpActionResult Delete(int id)
        {
			CEP cep = new CEP(id);
			try
			{
				cep.Delete();
			}
			catch (Exception)
			{
				throw;
			}
			return Ok();
		}
    }
}
