Console.WriteLine("Ingrese numero");
int numeroIngresado = int.Parse(Console.ReadLine());

int numeroAleatorio = new Random().Next(0, 20);

int contadorIntentos = 0;
do
{
    if (numeroIngresado > numeroAleatorio)
    {
        Console.WriteLine("Numero ingresado mayor, intente de nuevo");
        contadorIntentos++;

        Console.WriteLine("Ingrese numero");
        numeroIngresado = int.Parse(Console.ReadLine());
        
    } else
    {
        Console.WriteLine("Numero ingresador menor, intente de nuevo");
        contadorIntentos++;

        Console.WriteLine("Ingrese numero");
        numeroIngresado = int.Parse(Console.ReadLine());
        
    }
} while (numeroIngresado != numeroAleatorio);

Console.WriteLine($"Felicitaciones, has adivinado el " +
    $"número secreto que era {numeroAleatorio} en una cantidad de " +
    $"intentos = {contadorIntentos}");
