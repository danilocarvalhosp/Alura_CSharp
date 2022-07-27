using ByteBank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Utilitario
{
    public class GerenciadorBonificacoes
    {
        private double TotalBonificacao;

        public void Registrar(Funcionario funcionario) {
            this.TotalBonificacao += funcionario.getBonificacao();
        }

        public double getBonificacao() {
            return this.TotalBonificacao;
        }
    }
}
