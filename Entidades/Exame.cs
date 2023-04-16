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
        public long TipoExameId { get; set; }
        public long ConveniadoId { get; set; }
        public long? PacienteId { get; set; }
        public SituacaoAtendimentoEnum Situacao { get; set; }

        public virtual TipoExame TipoExame { get; set; }
        public virtual Conveniado Conveniado { get; set; }
        public virtual Associado? Paciente { get; set; }
    }
}
