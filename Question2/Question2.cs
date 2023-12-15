namespace Question2
{
    public class Question2
    {       
        static int GetAddress(string[] commands)
        {
            int address = 0, startCommand = 0, endCommand = 0;
            for (int i = 0; i < commands.Length; i++)
            {
                startCommand = endCommand = 0;
                if (commands[i].StartsWith("20"))
                {
                    startCommand = 20;
                    endCommand = int.Parse((commands[i].Substring(2)));
                }
                if (commands[i].StartsWith("5"))
                {
                    startCommand = 5;
                    endCommand = int.Parse((commands[i].Substring(1)));
                }

                switch (startCommand)
                {
                    case 20: address += endCommand; break;
                    case 5: i += (endCommand - 1); break;
                }
            }

            return address;
        }
        static void Main()
        {
            var commands = File.ReadAllLines("C:\\commands.txt");
            int address = GetAddress(commands);
            Console.WriteLine("Question 2 - Address : {0}", address);
        }
    }
}
