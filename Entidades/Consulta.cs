using GisaApiArq.Dominio;
using GisaDominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisaDominio.Entidades
{
    public class Consulta : EntidadeBase
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public long PrestadorId { get; set; }
        public long? PacienteId { get; set; }
        public SituacaoAtendimentoEnum Situacao { get; set; }

        public virtual Prestador? Prestador { get; set; }
        public virtual Associado? Paciente { get; set; }
    }
}
