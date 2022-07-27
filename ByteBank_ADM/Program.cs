using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utilitario;

// CalcularBonificacao();
UsarSistema();

void CalcularBonificacao() {
    GerenciadorBonificacoes gerenciador = new GerenciadorBonificacoes();

    Designer pedro = new Designer("833.222.048-39");
    pedro.Nome = "Pedro";

    Desenvolvedor samya = new Desenvolvedor("254858965844");
    samya.Nome = "Samya";

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
    gerenciador.Registrar(samya);

    Console.WriteLine("Total de Bonificação: " + gerenciador.getBonificacao());
}

void UsarSistema() {
    SistemaInterno sistemainterno = new SistemaInterno();

    Diretor roberta = new Diretor("159.753.398-04");
    roberta.Nome = "Roberta";
    roberta.Senha = "123";

    GerenteContas ursula = new GerenteContas("326.985.628-89");
    ursula.Nome = "Úrsula";
    ursula.Senha = "321";

    sistemainterno.Logar(roberta, "123");
    sistemainterno.Logar(ursula, "321");
}

Console.ReadKey();
