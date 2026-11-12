Console.WriteLine("Quantos caracteres deseja que o vetor contenha? (máximo de 6)");
int quantidade = int.Parse(Console.ReadLine());

char[] caracteres = new char[quantidade];
int contador = 0;

void popularVetor()
{
    for (int i = 0; i < quantidade; i++)
    {

        Console.WriteLine($"Informe o caractere desejado da posição {i}: ");
        caracteres[i] = char.Parse(Console.ReadLine());
        
    }
}

void mostrarVetor()
{
    for (int i = 0; i < quantidade; i++)
    {
        Console.WriteLine($"O caractere da posição {i} é: {caracteres[i]}");
    }
    
}

void mostrarVetorInvertido()
{
    for (int i = quantidade - 1; i >= 0; i--)
    {
        Console.WriteLine($"O caractere da posição {i} é: {caracteres[i]}");
    }
        
    }
    

popularVetor();
mostrarVetor();
Console.WriteLine("------------------------------------");
mostrarVetorInvertido();