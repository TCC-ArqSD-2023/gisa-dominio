using FluentResults;
using GisaApiArq.Servicos;
using GisaDominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GisaDominio.Interfaces.Servicos
{
    public interface IServicoAssociado : IServicoCrudBase<Associado>
    {
        Result AderirPlano(long associadoId, long planoId);
    }
}
