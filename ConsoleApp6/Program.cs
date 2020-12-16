using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp6
{
    class Program
    {
        public static string blogTopic;
        public static string userName;
        public static DateTime Datepublished = DateTime.Now;
        public static string blogContent;
        public static string email;
        public static string Age;
        public static string fileName;
       
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Welcome to this program which will allow you create your blog post in amazing looking form");

                Console.WriteLine("Enter your user name");
                userName = Console.ReadLine();
                Console.WriteLine("Enter File Name");
                fileName = Console.ReadLine();
                Console.WriteLine("Enter your Age");
                Age = Console.ReadLine();
                Console.WriteLine("Where do you live?");
                string home = Console.ReadLine();
                Console.WriteLine("Enter your email");
                email = Console.ReadLine();
                Console.WriteLine("What is your area of interest?");
                string interest = (Console.ReadLine());
                Console.WriteLine("Blog Topic");
                blogTopic = Console.ReadLine();
                Console.WriteLine("Enter Blog Content here");
                blogContent = Console.ReadLine();

                var path = "C:\\Users\\ChiamakaUzuegbu\\OneDrive - Enov8 Solutions Ltd\\Desktop\\Chiamaka\\" + fileName + ".html";
                LowLevelWrite(path);
                Reverseinformation();
            }
            catch (Exception)
            {

                throw;
            }
        }

      static void LowLevelWrite(string path)
        {
            using (StreamWriter str = new StreamWriter(path))
            {
                str.WriteLine("<!DOCTYPE html>");
                str.WriteLine("<html lang='en'>");
                str.WriteLine("<head>");
                str.WriteLine("<meta charset='UTF - 8'>");
                str.WriteLine("<meta name = 'viewport' content = 'width = device - width, initial - scale = 1.0'>");
                str.WriteLine($"<title> {blogTopic} </title>");
                str.WriteLine("</head>");
                str.WriteLine("<body style='padding:20px; text-align:justify; font-weight:normal; background-color:aliceblue;'>");
                str.WriteLine($"<h1 style = 'text-color:crimson; text-align:center'> { blogTopic} </h1>");
                str.WriteLine($"<h4> By {userName} / {Datepublished}/ {email} <h4>");
                str.WriteLine($"<p> {blogContent} </p>");
                str.WriteLine($"<h6><footer>copyright &copy; 2020 {userName} {Age}, is a tech enthusiast and a seasoned writer with many years of experience and expertise</footer></h6>");
                str.WriteLine("</body>");
                str.WriteLine("</html>");
               
            
            //Try to reduce repitition in coding
            }

        }

        public static void Reverseinformation()
        {
            List<string> newsContent = new List<string>();
            var path = "C:\\Users\\ChiamakaUzuegbu\\OneDrive - Enov8 Solutions Ltd\\Desktop\\Chiamaka\\" + fileName + ".html";
            using (StreamWriter str = new StreamWriter(path))
            {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter the current news on the blog");
                string replyNews = Console.ReadLine();

                newsContent.Add(replyNews);      

            }
            Console.WriteLine("Enter File Name");
            fileName = Console.ReadLine();
            Console.WriteLine("This is the right order\n");

            for (int j = 0; j < 3; j++)
            {
                Console.WriteLine(newsContent[j]);
            }
            Console.WriteLine("This is the reverse order\n");
            newsContent.Reverse();
            for (int j = 0; j < 3; j++)
			{
                Console.WriteLine(newsContent[j]);
			}
            Console.ReadLine();
            }

        } 

    }
}
