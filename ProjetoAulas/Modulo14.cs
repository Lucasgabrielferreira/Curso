namespace Modulo14;

public class TrabalhandoComLinq
{
    public void AulaWhere()
    {
        string nomeCompleto = "Lucas Gabriel";

        var resultado = nomeCompleto.Where(p => p == 'a');

        foreach(var letra in resultado)
        {
            Console.WriteLine(letra);
        }
    }
}