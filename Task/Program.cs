Console.Clear();
      string [] text;

      text = Console.ReadLine().Split(' ', ',', ';', '.');
      for (int i = 0; i < text.Length; i++)
      {
        if (text[i].Length < 3)
        {
            Console.WriteLine(text[i]);
        }
      
      }
        Console.ReadKey();
