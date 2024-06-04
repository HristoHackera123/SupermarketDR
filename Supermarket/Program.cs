namespace Supermarket
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double total = 0;
            Dictionary<string, ProductInfo> dict = new Dictionary<string, ProductInfo>();
            string[] answer = Console.ReadLine().Split().ToArray();
            while (answer[0] != "stocked")
            {
                string productName = answer[0];
                double price = double.Parse(answer[1]);
                int stock = int.Parse(answer[2]);
                if (dict.ContainsKey(productName))
                {
                    dict[productName].Price = price;
                    dict[productName].Quantity += stock;
                }
                else
                {
                    dict[productName] = new ProductInfo(price, stock);
                }
                answer = Console.ReadLine().Split().ToArray();
            }
            foreach(string item in dict.Keys)
            {
                int itemQuantity = dict[item].Quantity;
                double itemPrice = dict[item].Price;
                double itemTotalPrice = itemPrice * itemQuantity;
                Console.WriteLine($"{item}: ${itemPrice:f2} * {itemQuantity} = ${itemTotalPrice:f2}");
                total+= itemTotalPrice;
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine($"Grand total: ${total:f2}");
        }
    }
}
