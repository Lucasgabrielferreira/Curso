namespace Modulo12;

public class TrabalhandoComExcecoes
{
    public void AulaGerandoExcaption()
    {
        while(true)
        {
            Console.Write("Informe um numero: ");
            var numero = Console.ReadLine();
            var resultado = 500 / int.Parse(numero);

            Console.WriteLine("Resultado: " + resultado);
        }
        
    }
}