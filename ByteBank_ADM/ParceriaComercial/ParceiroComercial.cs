using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.ParceriaComercial
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Senha { get; set; }

        public bool Autenticar(string senha) {
            return Senha == senha;
        }
    }
}
