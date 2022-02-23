
namespace Assignment4
static void Main(string[] args)
{
           String title = "The ESRI Training";
           String author = "Sridhar";
           int price = 400;
           double rating = 4;

              Console.WriteLine("Title:\t" + title);

              Console.WriteLine("Author:\t{0}", author);

              Console.writeLine("Original Price: {0}\tRating: {1}", price, rating);

            if (rating > 4 && price < 400)

            {
                Console.WriteLine("Recomendation = Highly recommned")
                
                if (rating < 3)

                {
                
                Console.WriteLine("Recomendation = Not recommned")
                    //if both condition 1 and condition2 is true 

                }

                else

                {
                
                 Console.WriteLine("Recomendation = May recommned")
                    //condition 1 is true but condition 2 is false 

                }

            }
            else

            {

                //condition 1 is false and I don’t care about condition 2 

            }

        }
    }

}