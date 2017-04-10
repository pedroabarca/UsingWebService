using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.ENTIDADES
{
   public class Modena
    {

        /// <comentarios/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
        public partial class NewDataSet
        {

            private NewDataSetTable[] tableField;

            /// <comentarios/>
            [System.Xml.Serialization.XmlElementAttribute("Table")]
            public NewDataSetTable[] Table
            {
                get
                {
                    return this.tableField;
                }
                set
                {
                    this.tableField = value;
                }
            }
        }

        /// <comentarios/>
        [System.SerializableAttribute()]
        [System.ComponentModel.DesignerCategoryAttribute("code")]
        [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
        public partial class NewDataSetTable
        {

            private string nameField;

            private string countryCodeField;

            private string currencyField;

            private string currencyCodeField;

            /// <comentarios/>
            public string Name
            {
                get
                {
                    return this.nameField;
                }
                set
                {
                    this.nameField = value;
                }
            }

            /// <comentarios/>
            public string CountryCode
            {
                get
                {
                    return this.countryCodeField;
                }
                set
                {
                    this.countryCodeField = value;
                }
            }

            /// <comentarios/>
            public string Currency
            {
                get
                {
                    return this.currencyField;
                }
                set
                {
                    this.currencyField = value;
                }
            }

            /// <comentarios/>
            public string CurrencyCode
            {
                get
                {
                    return this.currencyCodeField;
                }
                set
                {
                    this.currencyCodeField = value;
                }
            }
        }


    }
}
