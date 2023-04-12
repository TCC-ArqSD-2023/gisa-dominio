using GisaApiArq.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisaDominio.Entidades
{
    public class Conveniado : EntidadeBase
    {
        public string Nome { get; set; }
        public virtual Endereco Endereco { get; set; }
        public string Telefone { get; set; }

        public long EnderecoId { get; set; }
    }
}
