namespace Ucu.Poo.TestDateFormat;

/// <summary>
/// El programa principal.
/// </summary>
public static class Program
{
    /// <summary>
    /// Punto de entrada al programa principal.
    /// </summary>
    public static void Main()
    {
        string testDate = "Cuadro";
        try {
        Console.WriteLine($"{testDate} se convierte a {DateFormatter.ChangeFormat(testDate)}");
        } catch(FormatException ex) 
        {
            Console.WriteLine("Error de formato de fecha"  + ex.Message); 
        }
    }
}