using gisa_dominio.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gisa_dominio.Entidades
{
    public class Prestador : EntidadeBase
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public SexoEnum Sexo { get; set; }
        public string NumeroDocumentoProfissional { get; set; }
        public List<Especialidade> Especialidade { get; set; }
        public Endereco EnderecoAtendimento { get; set; }
        public string Telefone { get; set; }

    }
}
