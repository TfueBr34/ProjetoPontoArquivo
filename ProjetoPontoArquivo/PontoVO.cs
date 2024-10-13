using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modelo
{
    public class PontoVO
    {
        private int codigo;
        private string descricao;
        private double x;
        private double y;
        private int tipoFigura;
        private double lado1;
        private double lado2;
        private double lado3;

        public PontoVO()
        {
        }

        public PontoVO(int codigo)
        {
            this.codigo = codigo;
        }

        public PontoVO(int codigo, int tipoFigura, string descricao, double x, double y) : this(codigo)
        {
            this.descricao = descricao;
            this.x = x;
            this.y = y;
            this.tipoFigura = tipoFigura;
            this.lado1 = 0;
            this.lado2 = 0;
            this.lado3 = 0;
        }

        public int Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public double X { get => x; set => x = value; }
        public double Y { get => y; set => y = value; }
        public int TipoFigura { get => tipoFigura; set => tipoFigura = value; }
        public double Lado1 { get => lado1; set => lado1 = value; }
        public double Lado2 { get => lado2; set => lado2 = value; } 
        public double Lado3 { get => lado3; set => lado3 = value; }

        public override bool Equals(object? obj)
        {
            return obj is PontoVO vO &&
                   codigo == vO.codigo;
        }

        public override string ToString()
        {
            return "Código: " + Codigo + "  // descricao: " + Descricao;
        }
    }
}
