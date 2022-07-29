﻿using bytebank.Modelos.Conta;
using bytebank_ATENDIMENTO.bytebank.Exceptions;
using bytebank_ATENDIMENTO.bytebank.Util;
using System.Collections;

Console.WriteLine("Boas Vindas ao ByteBank - Atendimento.");

#region Exemplos Arrays em C#
int [] idades = new int [5];

// TestaArrayInt();
// TestaBuscarPalavra();

void TestaArrayInt()
{
    idades [0] = 30;
    idades [1] = 40;
    idades [2] = 17;
    idades [3] = 21;
    idades [4] = 18;

    Console.WriteLine($"Tamanho do Array {idades.Length}");

    int acumulador = 0;

    for (int i = 0; i < idades.Length; i++)
    {
        int idade = idades [i];
        Console.WriteLine($"Índice [{i}] = {idades [i]}");
        acumulador += idades [i];
    }

    int media = acumulador / idades.Length;
    Console.WriteLine($"Média de idades = {media}");
}

void TestaBuscarPalavra()
{
    string [] arrayDePalavras = new string [5];

    for (int i = 0; i < arrayDePalavras.Length; i++)
    {
        Console.WriteLine($"Digite {i + 1}ª Palavra: ");
        arrayDePalavras [i] = Console.ReadLine();
    }

    Console.Write("Digite a palavra a ser encontrada: ");
    var busca = Console.ReadLine();

    foreach (string palavra in arrayDePalavras)
    {
        if (palavra.Equals(busca))
        {
            Console.WriteLine($"Palavra encontrada = {busca}.");
            break;
        }
    }
}

// Array amostra = Array.CreateInstance(typeof(double), 5);
Array amostra = new double [5];
amostra.SetValue(5.9, 0);
amostra.SetValue(1.8, 1);
amostra.SetValue(7.1, 2);
amostra.SetValue(10, 3);
amostra.SetValue(6.9, 4);

// TestaMediana(amostra);

void TestaMediana(Array array)
{
    if (array == null || array.Length == 0)
    {
        Console.WriteLine("Array para cálculo da mediana está vazio ou nulo.");
    }

    double [] numerosOrdenados = (double []) array.Clone();
    Array.Sort(numerosOrdenados);

    int tamanho = numerosOrdenados.Length;
    int meio = tamanho / 2;
    double mediana = (tamanho % 2 != 0) ? numerosOrdenados [meio] : (numerosOrdenados [meio] + numerosOrdenados [meio - 1]) / 2;

    Console.WriteLine($"Com base na amostra, a mediana = {mediana}.");
}

//int [] valores = { 10, 58, 36, 47 };

//for (int i = 0; i < valores.Length; i++)
//{
//    Console.WriteLine(valores [i]);
//}

void TestaArrayDeContasCorrentes()
{
    ListaDeContasCorrentes listaDeContas = new ListaDeContasCorrentes();
    listaDeContas.Adicionar(new ContaCorrente(874, "5679787-A"));
    listaDeContas.Adicionar(new ContaCorrente(874, "4456668-B"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));
    listaDeContas.Adicionar(new ContaCorrente(874, "7781438-C"));

    var contaDoAndre = new ContaCorrente(963, "123456-X");
    listaDeContas.Adicionar(contaDoAndre);
    //listaDeContas.ExibeLista();
    //Console.WriteLine("=================");
    //listaDeContas.Remover(contaDoAndre);
    //listaDeContas.ExibeLista();

    for (int i = 0; i < listaDeContas.Tamanho; i++)
    {
        ContaCorrente conta = listaDeContas [i];
        Console.WriteLine($"Índice [{i}] = {conta.Conta}/{conta.Numero_agencia}.");
    }
}

// TestaArrayDeContasCorrentes();
#endregion

#region Exemplos de uso do List
//List<ContaCorrente> _listaDeContas2 = new List<ContaCorrente>()
//{
//    new ContaCorrente(874, "5679787-A"),
//    new ContaCorrente(874, "4456668-B"),
//    new ContaCorrente(874, "7781438-C")
//};

//List<ContaCorrente> _listaDeContas3 = new List<ContaCorrente>()
//{
//    new ContaCorrente(951, "5679787-E"),
//    new ContaCorrente(321, "4456668-F"),
//    new ContaCorrente(719, "7781438-G")
//};

//_listaDeContas2.AddRange(_listaDeContas3);
//_listaDeContas2.Reverse();

//for (int i = 0; i < _listaDeContas2.Count; i++)
//{
//    Console.WriteLine($"Índice[{i}] = Conta [{_listaDeContas2 [i].Conta}]");
//}

//Console.WriteLine("\n\n");

//var range = _listaDeContas3.GetRange(0, 1);
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Índice[{i}] = Conta [{range [i].Conta}]");
//}

//Console.WriteLine("\n\n");

//_listaDeContas3.Clear();
//for (int i = 0; i < range.Count; i++)
//{
//    Console.WriteLine($"Índice[{i}] = Conta [{range [i].Conta}]");
//}
#endregion 

List<ContaCorrente> _listaDeContas = new List<ContaCorrente>()
{
    new ContaCorrente(95, "123456-X"){Saldo = 100, Titular = new Cliente{Cpf="11111", Nome="Henrique"} },
    new ContaCorrente(95, "951258-X"){Saldo = 200, Titular = new Cliente{Cpf="22222", Nome="Pedro"} },
    new ContaCorrente(94, "987321-W"){Saldo = 60, Titular = new Cliente{Cpf="33333", Nome="Marisa"} }
};

AtendimentoCliente();

void AtendimentoCliente()
{
    try
    {
        char opcao = '0';
        while (opcao != '6')
        {
            Console.Clear();
            Console.WriteLine("====================================");
            Console.WriteLine("===          ATENDIMENTO         ===");
            Console.WriteLine("=== 1 - Cadastrar Conta          ===");
            Console.WriteLine("=== 2 - Listar Contas            ===");
            Console.WriteLine("=== 3 - Remover Conta            ===");
            Console.WriteLine("=== 4 - Ordenar Contas           ===");
            Console.WriteLine("=== 5 - Pesquisar Conta          ===");
            Console.WriteLine("=== 6 - Sair do Sistema          ===");
            Console.WriteLine("====================================");

            Console.WriteLine("\n\n");
            Console.Write("Digite a opção desejada: ");

            try
            {
                opcao = Console.ReadLine() [0];
            }
            catch (Exception excecao)
            {
                throw new ByteBankException(excecao.Message);
            }
            switch (opcao)
            {
                case '1':
                    CadastrarConta();
                    break;
                case '2':
                    ListarContas();
                    break;
                case '3':
                    RemoverContas();
                    break;
                case '4':
                    OrdenarContas();
                    break;
                default:
                    Console.WriteLine("Opção não implementada.");
                    break;
            }
        }
    }
    catch (ByteBankException excecao)
    {
        Console.WriteLine($"{excecao.Message}");
    }

}

void OrdenarContas()
{
    _listaDeContas.Sort();
    Console.WriteLine("... Lista de contas ordenada ...");
    Console.ReadKey();
}

void RemoverContas()
{
    Console.Clear();
    Console.WriteLine("====================================");
    Console.WriteLine("===        REMOVER CONTAS        ===");
    Console.WriteLine("====================================");
    Console.WriteLine("\n");
    Console.Write("Informe o número da Conta: ");

    string numeroConta = Console.ReadLine();
    ContaCorrente conta = null;
    foreach (var item in _listaDeContas)
    {
        if (item.Conta.Equals(numeroConta))
        {
            conta = item;
        }
    }
    if (conta != null)
    {
        _listaDeContas.Remove(conta);
        Console.WriteLine("... Conta removida da lista! ...");
    }
    else
    {
        Console.WriteLine("... Conta para remoção não encontrada ...");
    }
    Console.ReadKey();
}

void ListarContas()
{
    Console.Clear();
    Console.WriteLine("====================================");
    Console.WriteLine("===       LISTA DE CONTAS        ===");
    Console.WriteLine("====================================");
    Console.WriteLine("\n");

    if (_listaDeContas.Count < 0)
    {
        Console.WriteLine("... Não há contas cadastradas! ...");
        Console.ReadKey();
        return;
    }

    foreach (ContaCorrente item in _listaDeContas)
    {
        Console.WriteLine("===      Dados da Conta      ===");
        Console.WriteLine("Número da Conta: "+ item.Conta);
        Console.WriteLine("Saldo da Conta: "+ item.Saldo);
        Console.WriteLine("Titular da Conta: "+ item.Titular.Nome);
        Console.WriteLine("CPF do Titular: "+ item.Titular.Cpf);
        Console.WriteLine("Profissão do Titular: "+ item.Titular.Profissao);
        Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
        Console.ReadKey();
    }
}

void CadastrarConta()
{
    Console.Clear();
    Console.WriteLine("====================================");
    Console.WriteLine("===      CADASTRO DE CONTAS      ===");
    Console.WriteLine("====================================");
    Console.WriteLine("\n");
    Console.WriteLine("===    Informe dados da conta    ===");

    Console.Write("Número da Conta: ");
    string numeroConta = Console.ReadLine();

    Console.Write("Número da Agência: ");
    int numeroAgencia = int.Parse(Console.ReadLine());

    ContaCorrente conta = new ContaCorrente(numeroAgencia, numeroConta);

    Console.Write("Informe o saldo inicial: ");
    conta.Saldo = double.Parse(Console.ReadLine());

    Console.Write("Informe o nome do Titular: ");
    conta.Titular.Nome = Console.ReadLine();

    Console.Write("Informe o CPF do Titular: ");
    conta.Titular.Cpf = Console.ReadLine();

    Console.Write("Informe a profissão do Titular: ");
    conta.Titular.Profissao = Console.ReadLine();

    _listaDeContas.Add(conta);

    Console.WriteLine("... Conta cadastrada com sucesso!!! ...");
    Console.ReadKey();
}



