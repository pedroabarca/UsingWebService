using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebService.ENTIDADES
{
    
 
[System.SerializableAttribute()]
 [System.ComponentModel.DesignerCategoryAttribute("code")]
 [System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
 [System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class NewDataSet
    {

        private NewDataSetTable[] tableField;

        /// </>
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

        private sbyte gMTField;

        private string nameField;

        /// <comentarios/>
        public sbyte GMT
        {
            get
            {
                return this.gMTField;
            }
            set
            {
                this.gMTField = value;
            }
        }

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
    }

    class Gmt
    {
    }
}
