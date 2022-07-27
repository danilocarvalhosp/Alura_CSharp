using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank_ADM.Funcionarios
{
    internal class GerenteContas : Funcionario
    {
        public GerenteContas(string cpf) : base(cpf, 3000) {

        }

        public override void AumentarSalario() {
            Salario *= 1.05;
        }

        public override double getBonificacao() {
            return Salario * 0.25;
        }

    }
}
