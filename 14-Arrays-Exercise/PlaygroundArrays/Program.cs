namespace PlaygroundArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TryParseExample();
            int[] array = { 1, 2, 3, 4, 5, 6 };

            Lastitem();
            int[] firstHalf = array[0..^(array.Length / 2)];
            int[] secondHalf = array[((array.Length / 2) - 1)..^1];
            int[] slice1 = array[1..^3];
            int[] slice2 = array[..^3];
            int[] slice3 = array[2..];
            int[] slice4 = array[..];
        }

        private static void TryParseExample()
        {
            string columnId = "ID:12";
            if (!int.TryParse(columnId, out int prasedColumnValue))
            {
                Console.WriteLine("Coulmn id must be a valid number between 0 and 200000");

                return;
            }

            Console.WriteLine(prasedColumnValue);
        }

        static void Lastitem()
        {
            var array = new int[] { 1, 2, 3, 4, 5 };
            for (int i = 1; i <= array.Length; i++)
            {
                Console.WriteLine(array[^i]);
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[array.Length - i - 1]);
            }
        }
    }
}
