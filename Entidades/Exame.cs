using GisaApiArq.Dominio;
using GisaDominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisaDominio.Entidades
{
    public class Exame : EntidadeBase
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public int TipoExameId { get; set; }
        public int ConveniadoId { get; set; }
        public int? PacienteId { get; set; }
        public SituacaoAssociadoEnum Situacao { get; set; }

        public TipoExame TipoExame { get; set; }
        public Conveniado Conveniado { get; set; }
        public Associado? Paciente { get; set; }
    }
}
