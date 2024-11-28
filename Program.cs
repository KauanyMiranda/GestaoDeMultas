using static System.Console;
using static System.Convert;

public class Program
{
    static void Main(string[] args)
    {
        try
        {
            Veiculos v1 = new Veiculos();

            Write("Digite o número do NIV: ");
            string niv = ReadLine();

            v1.SetNivVerific(niv);

            WriteLine(v1.GetNivVerific());
        }catch (Exception ex)
        {
            WriteLine(ex.Message);
        }
    }
}