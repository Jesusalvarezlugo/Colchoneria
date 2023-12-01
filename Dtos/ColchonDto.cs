using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colchoneria.Dtos
{
    internal class ColchonDto
    {
        //Atributos

        long idColchon;
        string marcaColchon;
        string tipoColchon;
        double anchoColchon;
        double largoColchon;

      

        //Getters y Setters
        public long IdColchon { get => idColchon; set => idColchon = value; }
        public string MarcaColchon { get => marcaColchon; set => marcaColchon = value; }
        public string TipoColchon { get => tipoColchon; set => tipoColchon = value; }
        public double AnchoColchon { get => anchoColchon; set => anchoColchon = value; }
        public double LargoColchon { get => largoColchon; set => largoColchon = value; }

        //Constructores

        public ColchonDto()
        {

        }

        public ColchonDto(long idColchon, string marcaColchon, string tipoColchon, double anchoColchon, double largoColchon)
        {
            this.idColchon = idColchon;
            this.marcaColchon = marcaColchon;
            this.tipoColchon = tipoColchon;
            this.anchoColchon = anchoColchon;
            this.largoColchon = largoColchon;
        }

        //ToString

        override
        public string ToString()
        {
            string texto;

            texto = "ID: " + this.idColchon + " \n MARCA: " + this.marcaColchon + 
                    "\n TIPO: " + this.tipoColchon + "\n ANCHO: " + this.anchoColchon +
                    "\n LARGO: " + this.largoColchon;

            return texto;
        }
        

    }
}
