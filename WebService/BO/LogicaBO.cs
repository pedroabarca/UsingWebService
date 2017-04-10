using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WebService.WsPais;


namespace WebService.BO
{
  public  class LogicaBO
    {
        
        /// <summary>
        /// Consulta los metodos distintos para obtener los diferentes condigos a consultar (telefonico, moneda,acronimo,gmt)
        /// </summary>
        /// <param name="pais"> Nombre del pais a Consultar</param>
        /// <returns>Una lista de string con los resultados de las consultas</returns>
        public List<string> ConsultarPais(string pais)
        {
            List<String> result;
            try
            {
                result = new List<string>();
                countrySoapClient cs = new countrySoapClient("countrySoap");

                string isd = cs.GetISD(pais);
                string moneda = cs.GetCurrencyByCountry(pais);
                string gmt = cs.GetGMTbyCountry(pais);

                XmlDocument doc = new XmlDocument();
                doc.LoadXml(isd);//consultamos por condigoTelefonico
                XmlNodeList elemList = doc.GetElementsByTagName("code");
                result.Add("Código Telefónico: " + elemList[0].InnerText);
                
                doc.LoadXml(moneda);//Consultamos por moneda
                elemList = doc.GetElementsByTagName("CurrencyCode");
                result.Add("Moneda: "+elemList[0].InnerText);
                elemList = doc.GetElementsByTagName("CountryCode");
                result.Add("Acronimo: "+elemList[0].InnerText);

                doc.LoadXml(gmt);//Consultamos por zona horaria
                elemList = doc.GetElementsByTagName("GMT");
                result.Add("Zona Horaria: "+elemList[0].InnerText);

                return result;

            }
            catch (Exception)
            {
                return result = null;
            }
           


        }
    }
}
