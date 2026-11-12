int tamanho = 10;
char[] vetorInicial = new char[tamanho];
string[] vetorAscii = new string[tamanho * 2];

void PopularVetor(char[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine("Informe a letra desejada: ");
        vetor[i] = char.Parse(Console.ReadLine());
    }
}

int ConverterASCII(char letra)
{
    return (int)letra;
}

void CriarVetorASCII()
{
    for (int i = 0; i < vetorAscii.Length; i += 2)
    {
        vetorAscii[i] = vetorInicial[i / 2].ToString();
        vetorAscii[i + 1] = ConverterASCII(vetorInicial[i / 2]).ToString();
    }
}

void ExibirVetor(string[] vetor)
{
    for (int i = 0; i < vetor.Length; i++)
    {
        Console.WriteLine($"[{vetor[i]}] ");
    }
    Console.WriteLine();
}

PopularVetor(vetorInicial);

string[] temp = new string[vetorInicial.Length];

for (int i = 0; i < vetorInicial.Length; i++)
{
    temp[i] = vetorInicial[i].ToString();
}

ExibirVetor(temp);
CriarVetorASCII();
ExibirVetor(vetorAscii);