using Biblioteca.classesBasicas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Biblioteca.utils
{
    public class CepUtils
    {
        private const string CEP_URL = "https://viacep.com.br/ws/{0}/xml/";

        public static Endereco PegarEndereco(string cep)
        {
            Endereco endereco = null;

            try
            {
                XmlDocument xml = new XmlDocument();
                xml.Load(String.Format(CEP_URL, cep.Replace("-", "")));

                endereco = new Endereco();

                endereco.CEP = xml.DocumentElement.SelectSingleNode("/xmlcep/cep").InnerText;
                endereco.Logradouro = xml.DocumentElement.SelectSingleNode("/xmlcep/logradouro").InnerText;
                endereco.Complemento = xml.DocumentElement.SelectSingleNode("/xmlcep/complemento").InnerText;
                endereco.Bairro = xml.DocumentElement.SelectSingleNode("/xmlcep/bairro").InnerText;
                endereco.UF = xml.DocumentElement.SelectSingleNode("/xmlcep/uf").InnerText;
                endereco.Cidade = xml.DocumentElement.SelectSingleNode("/xmlcep/cidade").InnerText;
            }
            catch(Exception err)
            {
                throw new Exception(err.Message);
            }
            return endereco;
        }
    }
}
