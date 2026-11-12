int[] numeros = new int[4];
int contador = 0;

void popularVetor()
{
    contador = 0;

    do
    {
        Console.WriteLine($"Informe o número desejado da posição {contador}: ");
        numeros[contador] = int.Parse(Console.ReadLine());
        contador++;

    } while (contador < numeros.Length);
}

void mostrarVetor()
{
    contador = 0;
    while (contador < numeros.Length)
    {
        Console.WriteLine($"O número da posição {contador} é: {numeros[contador]}");
        contador++;
    }
    ;
}

popularVetor();
mostrarVetor();