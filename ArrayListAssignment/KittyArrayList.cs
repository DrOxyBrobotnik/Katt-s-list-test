namespace ArrayListAssignment
{
    public class KittyArrayList
    {
        public string Length { get; set; }
        KittyArrayList(int dumma)
        {

        }

        KittyArrayList(int dumma, int bunna)
        {

        }

        KittyArrayList(int dumma, int bunna, int cumma)
        {

        }

        int[] bunny = { 0 };
        int[] katt = { 0, 0 };
        int Get(int dumma)
        {
            return dumma;
        }

        void Add(int bunna)
        {
            bunna = bunny;
            bunna = katt;
        }

        void Remove(int cumma)
        {
            cumma = 0;
            if (bunny || katt.Contains(cumma))
            {
                Console.WriteLine("Sorry, number deleted");
            }
        }
    }
}