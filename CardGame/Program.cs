namespace CardGame
{
    internal class Program
    {
        //public static int Sum(Card[] arr)
        //{
        //    int sum = 0;
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        sum += arr[i].GetVal();
        //    }
        //    return sum;
        //}
        static void Main(string[] args)
        {
            //Card c = new Card(1, 1);
            //Card c1 = new Card(2, 2);
            //Card c3= new Card(3, 3);    
            //Card c4= new Card(4, 4);
            //Console.WriteLine(c);
            //Console.WriteLine(c1);
            //Console.WriteLine(c3);
            //Console.WriteLine(c4);
           
           

            string name = Console.ReadLine();
            Player player = new Player(name);
            Deck deck = new Deck();
            deck.Shuffle();

            player.Take(deck.Deal());
            player.Take(deck.Deal());

            while(Sum(hand))

            



        }
    }
}