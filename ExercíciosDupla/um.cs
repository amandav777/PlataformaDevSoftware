namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextReader reader = new StreamReader("C:\\Users\\Aula\\source\\repos\\ConsoleApp1\\ConsoleApp1\\nomes_telefones.txt");
            String linha = reader.ReadLine();
            while (linha != null)
            {
                //string temp1 = linha.Substring (linha.IndexOf('('));
                string temp1 = linha.Replace("(", "").Replace(")", "").Replace("-", "");
                Console.WriteLine(temp1);
                linha = reader.ReadLine();
            }
            Console.WriteLine("Leitura completa");
        }
    }
}
