int[] numeros = new int[5];

void popularVetor()
{
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine($"Informe o número desejado");
        numeros[i] = int.Parse(Console.ReadLine());
    }
}
void mostrarVetor()
{
    for (int i = 0; i < numeros.Length; i++)
    {
        Console.WriteLine(numeros[i]);
    }
}

void CopiarEMostrarVetorInvertido()
{
    int[] copia = new int[5];
    int indiceInvertido = 4;

    for (int i = 0; i < numeros.Length; i++)
    {
        copia[i] = numeros[indiceInvertido];
        Console.WriteLine(copia[i]);
        indiceInvertido--;
    }

}

void vetorPar()
{
    int tamanho = 0;
    for(int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] % 2 == 0)
        {
            tamanho++;
        }
    }

    int[] copiaPar = new int [tamanho];

    int posicaoDaCopia = 0;

    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] % 2 == 0)
        {
            copiaPar[posicaoDaCopia] = numeros[i];
            Console.WriteLine(copiaPar[posicaoDaCopia]);
            posicaoDaCopia++;
        }

    }

}


void vetorImpar()
{
    int tamanho = 0;
    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] % 2 != 0)
        {
            tamanho++;
        }
    }

    int[] copiaImpar = new int[tamanho];

    int posicaoDaCopia = 0;

    for (int i = 0; i < numeros.Length; i++)
    {
        if (numeros[i] % 2 != 0)
        {
            copiaImpar[posicaoDaCopia] = numeros[i];
            Console.WriteLine(copiaImpar[posicaoDaCopia]);
            posicaoDaCopia++;
        }

    }

}

popularVetor();
Console.WriteLine("------------------------------");
mostrarVetor();
Console.WriteLine("------------------------------"); 
CopiarEMostrarVetorInvertido();
Console.WriteLine("------------------------------");
vetorPar();
Console.WriteLine("------------------------------");
vetorImpar();
