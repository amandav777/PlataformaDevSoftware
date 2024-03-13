  static void Main(string[] args)
  {
      TextReader reader = new StreamReader("C:\\Users\\Aula\\source\\repos\\ConsoleApp1\\ConsoleApp1\\datas.txt");
      String linha = reader.ReadLine();
      while (linha != null)
      {
          string[] temp1Vector = linha.Split('/');

          Console.WriteLine(temp1Vector[2]);
          linha = reader.ReadLine();
      }

      Console.WriteLine("Leitura completa");
  }