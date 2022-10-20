using System;

namespace IndexersDemo
{
    public class Program
    {

        public static void Main()
        {
            Indexer indexerObject1 = new Indexer(100,"Albert","physics",25000);

            for(int count = 1; count <= 4; count++)
            {
                Console.WriteLine(indexerObject1[count]);
            }

        }
    }




}