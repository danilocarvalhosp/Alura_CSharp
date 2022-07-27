using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

GerenciadorBonificacoes gerenciador = new GerenciadorBonificacoes();

Console.WriteLine("Boas Vindas ao ByteBank Administração.");

Funcionario pedro = new Funcionario("10252462425", 2000);
pedro.Nome = "Pedro";
Console.WriteLine("Total de funcionários: " + Funcionario.totalFuncionarios);

Diretor paula = new Diretor("258746325894", 5000);
paula.Nome = "Paula";
Console.WriteLine("Total de funcionários: " + Funcionario.totalFuncionarios);

Funcionario andre = new Diretor("65865845699", 3000);
andre.Nome = "André";
// Funcionario.totalFuncionarios = 5;
Console.WriteLine("Total de funcionários: " + Funcionario.totalFuncionarios);

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());

gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);
gerenciador.Registrar(andre);

Console.WriteLine("Total de Bonificações: " + gerenciador.getBonificacao());
Console.WriteLine("Total de funcionários: " + Funcionario.totalFuncionarios);

andre.AumentarSalario();
Console.WriteLine("Novo salário do André: " + andre.Salario);

andre.AumentarSalario();
Console.WriteLine("Novo salário do Pedro: " + pedro.Salario);

Console.ReadKey();
