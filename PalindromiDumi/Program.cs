namespace PalindromiDumi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Napishi duma: ");
            string word = Console.ReadLine();
            char[] duma = word.ToCharArray();
            int mid = duma.Length / 2;
            int i = 0;
            int j = duma.Length - 1;
            bool result = false;
            if (duma.Length % 2 == 1)

                for (i = 0; i < mid; i++)
                {
                    if (duma[i] == duma[duma.Length - 1 - i])
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            if (result)
            {
                Console.WriteLine(word);
            }
        }
    }
}
