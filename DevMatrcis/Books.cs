
namespace DevMatrcis
{
    public class Books
    {
        //access modifiers : private,public, internal, protected
        //data
        //field
        //property
        //logic
        //method
        //indexer
        //constructor
        //destructor


       public int x = 90; //field
        static int y = 78;
        public string Name { get; set; } // property 

        //method
        public void BookDetails()
        {
            Console.WriteLine(y);
        }

        public int BookInfor()
        {
            Console.WriteLine(5);
            return 5;
        }

        public static void Booklist(int i, int y)
        {
            int x = i + y;
            Console.WriteLine("your result is = " + x);
        }

        public string BookList(int y, string letter)
        {
            Console.WriteLine(y);
            return letter;
        }





    }

}
