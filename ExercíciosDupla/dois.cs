internal class Program
{
    static void Main(string[] args)
    {
        TextReader reader = new StreamReader("C:\\Users\\Aula\\source\\repos\\ConsoleApp1\\ConsoleApp1\\nomes_telefones.txt");
        String linha = reader.ReadLine();
        while (linha != null)
        {
            string temp1 = linha.Substring(0, linha.IndexOf('(') - 1);
            linha = reader.ReadLine();

            if (temp1.Length > 12)
            {
                Console.WriteLine(temp1.ToUpper());
            }
        }
        Console.WriteLine("Leitura completa");
    }
}