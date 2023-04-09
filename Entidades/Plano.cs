using GisaDominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisaDominio.Entidades
{
    public class Plano : EntidadeBase
    {
        public string Nome { get; set; }
        public string CodigoAns { get; set; }
        public CategoriaPlanoEnum Categoria { get; set; }
        public TipoPlanoEnum Tipo { get; set; }
        public bool Odonto { get; set; }
        public int IdadeMinima { get; set; }
        public int IdadeMaxima { get; set; }
        public int QuantidadeConsultasAno { get; set; }
        public int QuantidadeExamesAno { get; set; }
        public double ValorMensalidade { get; set; }
    }
}
