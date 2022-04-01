//  Cria váriavel numérica

int numeroDigitado;

Console.Write("Número digitado:");
numeroDigitado = Convert.ToInt32 (Console.ReadLine());

// Cria váriavel verdadeira ou falsa (bolleano)

bool numeroEhPar = (numeroDigitado % 2) == 0;

if (numeroEhPar)
{     
    Console.WriteLine ($"{numeroDigitado} é par");

}

else 
{
    Console.WriteLine($"{numeroDigitado} é ímpar");
}