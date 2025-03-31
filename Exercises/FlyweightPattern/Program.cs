namespace FlyweightPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PageLayout layout = new PageLayout();

            int pageAmount = 10;
            for (int i = 0; i < pageAmount; i++)
            {
                Page page = new Page(layout, CreateRandomBody(10), i);
                page.Print();
            }
        }

        private static string CreateRandomBody(int _sentences)
        {
            string body = "";
            for (int y = 0; y < _sentences; y++)
            {
                body += CreateRandomSentence();
            }
            return body;
        }

        private static string CreateRandomSentence()
        {
            return RandomSubject()+RandomVerb()+RandomObject()+"\n";
        }

        private static string RandomSubject()
        {
            string[] subjects = { "Andreas ", "Benjamin ", "My cat ", "My dog ", "The car ", "My junior ", "The senior ", "My neightbor " };
            Random rand = new Random();
            return subjects[rand.Next(subjects.Length)];
        }

        private static string RandomVerb() 
        {
            string[] verbs = { "ate ", "had ", "makes ", "codes ", "hates ", "writes ", "lost " };
            Random rand = new Random();
            return verbs[rand.Next(verbs.Length)];
        }
        private static string RandomObject()
        {
            string[] objects = { "lasagne.", "pizza.", "my website.", "wallet.", "some words." };

            Random rand = new Random();
            return objects[rand.Next(objects.Length)];
        }
    }
}
