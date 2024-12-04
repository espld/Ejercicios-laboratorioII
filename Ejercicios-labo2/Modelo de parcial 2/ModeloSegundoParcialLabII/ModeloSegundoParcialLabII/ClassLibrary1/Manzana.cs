using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary1
{
    public class Manzana : Fruta, ISerializar, IDeserializar
    {
        protected string provinciaOrigen;

        public Manzana()
        {

        }
        public Manzana(string color, double peso, string provinciaOrigen)
            : base(color, peso)
        {
            this.provinciaOrigen = provinciaOrigen;
        }

        public string Nombre
        {
            get { return typeof(Manzana).Name; }
        }
        public string ProvinciaOrigen
        {
            get { return this.provinciaOrigen; }
            set { this.provinciaOrigen = value; }
        }
        public override bool TieneCarozo
        {
            get
            {
                return false;
            }
            set
            {
                this.TieneCarozo = value;
            }
        }

        bool IDeserializar.Xml(string path, out Fruta fruta)
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Manzana));

                using (StreamReader streamReader = new StreamReader(path))
                {
                    fruta = (Manzana)xmlSerializer.Deserialize(streamReader);
                }

                return true;
            }
            catch (Exception)
            {
                fruta = null;
                return false;
            }
        }

        public bool Xml(string path)
        {
            bool returnAux = false;

            using (StreamWriter sw = new StreamWriter(path))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(Manzana));
                xmlSerializer.Serialize(sw, this);
                returnAux = true;
            }

            return returnAux;
        }

        public override string FrutasToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.FrutasToString());
            sb.AppendLine($"Provincia de origen: {this.ProvinciaOrigen}");

            return sb.ToString();
        }
        public override string ToString()
        {
            return this.FrutasToString();
        }

    }
}
