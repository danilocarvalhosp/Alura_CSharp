Console.WriteLine("Boas Vindas ao ByteBank - Atendimento.");

int [] idades = new int [5];

// TestaArrayInt();
TestaBuscarPalavra();

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


