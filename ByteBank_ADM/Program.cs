using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

CalcularBonificacao();

void CalcularBonificacao() {
    GerenciadorBonificacoes gerenciador = new GerenciadorBonificacoes();

    Designer pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro";

    Diretor paula = new Diretor("159.753.398-04");
    paula.Nome = "Paula";

    Auxiliar igor = new Auxiliar("981.198.778-53");
    igor.Nome = "Igor";

    GerenteContas camila = new GerenteContas("326.985.628-89");
    camila.Nome = "Camila";

    gerenciador.Registrar(pedro);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());
}

Console.ReadKey();
