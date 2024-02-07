namespace Modulo10;

public class TrabalhandoComStrings
{
    public void ConverterParaLetrasMinusculas()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToLower());
    }

     public void ConverterParaLetrasMaiusculas()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.ToUpper());
    }

     public void AulaSubstring()
    {
        Console.Write("Favor digitar alguma informacao: ");
        var linha = Console.ReadLine();
        Console.WriteLine(linha.Substring(0,6));
    }

      public void AulaRange()
    {
        string nomeArquivo = "2024_02_07_backup.bak";
        string ano = nomeArquivo[..4];
        Console.WriteLine(ano);
        string extensao = nomeArquivo[^3..];
        Console.WriteLine(extensao);

        string nome = nomeArquivo[11..^4];
        Console.WriteLine(nome);

        string apenasNome = nomeArquivo[..^4];
        Console.WriteLine(apenasNome);
    }

      public void AulaContains()
    {
        string nomeArquivo = "2024_02_07_backup.bak";
        if(nomeArquivo.Contains("backup"))
        {
            Console.WriteLine("Palavra encotrada");
        }
        else
        {
            Console.WriteLine("Palavra não encotrada");

        }
        //Console.WriteLine("Contem nome: " + nomeArquivo.Contains("backup"));
    }

      public void AulaTrim()
    {
        string teste = "**LUCAS GABRIEL**";

        Console.WriteLine("TOTAL: " + teste.Trim('*'));
        Console.WriteLine("INICIO: " + teste.TrimStart('*'));
        Console.WriteLine("FINAL: " + teste.TrimEnd('*'));
        
    }
}