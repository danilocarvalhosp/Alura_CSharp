using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Utilitario;

GerenciadorBonificacoes gerenciador = new GerenciadorBonificacoes();

Console.WriteLine("Boas Vindas ao ByteBank Administração.");

Funcionario pedro = new Funcionario();
pedro.Nome = "Pedro";
pedro.Cpf = "10252462425";
pedro.Salario = 2000;
Console.WriteLine("Total de funcionários: " + Funcionario.totalFuncionarios);

Diretor paula = new Diretor();
paula.Nome = "Paula";
paula.Cpf = "258746325894";
paula.Salario = 5000;
Console.WriteLine("Total de funcionários: " + Funcionario.totalFuncionarios);

Funcionario andre = new Diretor();
andre.Nome = "André";
andre.Salario = 3000;
// Funcionario.totalFuncionarios = 5;
Console.WriteLine("Total de funcionários: " + Funcionario.totalFuncionarios);

Console.WriteLine("Bonificação: " + pedro.getBonificacao());
Console.WriteLine("Bonificação: " + paula.getBonificacao());

gerenciador.Registrar(pedro);
gerenciador.Registrar(paula);

Console.WriteLine("Total de Bonificações: " + gerenciador.getBonificacao());

Console.ReadKey();
