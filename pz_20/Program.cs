namespace pz_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            Registr(text);
        }

       static string Registr(string text)
        {
            char[] arr = text.ToCharArray();
            for(int i = 0; i < arr.Length; i++)
            {
                if (Char.IsUpper(arr[i]) == true)
                {
                    arr[i] = char.ToLower(arr[i]);
                }    
                else if (Char.IsLower(arr[i]) == true)
                {
                    arr[i] = char.ToUpper(arr[i]);
                }
            }
            string newtext = new string(arr);
            Console.WriteLine(newtext);
            return newtext;
        }
    }
}