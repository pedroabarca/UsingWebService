
namespace WebService.ENTIDADES
{
   public class ISD
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

            private ushort codeField;

            private string nameField;

            /// <comentarios/>
            public ushort code
            {
                get
                {
                    return this.codeField;
                }
                set
                {
                    this.codeField = value;
                }
            }

            /// <comentarios/>
            public string name
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



    }
}
