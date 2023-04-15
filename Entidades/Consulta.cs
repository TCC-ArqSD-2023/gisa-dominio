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
        public int PrestadorId { get; set; }
        public int? PacienteId { get; set; }
        public SituacaoAssociadoEnum Situacao { get; set; }

        public Prestador Prestador { get; set; }
        public Associado? Paciente { get; set; }
    }
}
