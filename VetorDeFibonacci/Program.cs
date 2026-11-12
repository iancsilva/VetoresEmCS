Console.WriteLine("Digite um número inteiro");
int numero = int.Parse(Console.ReadLine());

void CriarVetorDeFibonacci(int numero)
{
    int[] vetorDeFibonacci = new int[numero];

    int penultimoNumero = 0;
    int ultimoNumero = 1;
    int numeroAtual = 0;

    for (int posicao = 0; posicao < numero; posicao++)
    {
        numeroAtual = penultimoNumero + ultimoNumero;
        penultimoNumero = ultimoNumero;
        ultimoNumero = numeroAtual;
        vetorDeFibonacci[posicao] = numeroAtual;
        Console.WriteLine($"Posição {posicao} = {vetorDeFibonacci[posicao]}");
    }
}

CriarVetorDeFibonacci(numero);