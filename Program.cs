using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
public class program
{
    public static void Main()
    {
        Console.WriteLine("Smartphone Iphone");
        Smartphone iphone = new Iphone("123456789","147258369", "Iphone 12", 256 );
        iphone.Ligar();
        iphone.InstalarAplicativo("Instagram");

        Console.WriteLine("\n");

        Console.WriteLine("Smartphone Nokia");
        Smartphone nokia = new Nokia("987654321", "963852741", "Nokia Eterno", 256);
        nokia.ReceberLigacao();
        nokia.InstalarAplicativo("WhatsApp");

    }
}



