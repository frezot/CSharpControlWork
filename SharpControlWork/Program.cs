using System;
using System.Collections.Generic;
using System.Linq;

namespace SharpControlWork
{
    class Program
    {
        static void Main()
        {
            #region Exercise1 inheritance

            Console.WriteLine(new Apple().Name);

            #endregion

            #region Exercise2 overload

            Console.WriteLine(
                "Max of 3.14 and 6.626 is : {0} \n" +
                "Max of 'qwe' and 'qwerty' is: {1} \n"
                , Exercise2.Max(3.14, 6.626)
                , Exercise2.Max("qwe", "qwerty")
                );

            #endregion

            #region Exercise3 generic

            var m1 = CreateMatrix(2, 2, 3.14159);
            foreach (var m in m1)
                Console.WriteLine(m);
            //matrix display is not formated because not required

            #endregion

            #region Exercise4 try-catch-finaly

            try
            {
                var someContact = new Contact {Name = "someName", Email = "someWithoutAt"};
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("now block 'finaly' execute");
            }

            #endregion

            #region Exercise5 extension method

            var age = new DateTime(1987, 08, 12).CurrentAge();
            Console.WriteLine("Current age is {0} years", age);

            #endregion

            #region Exercise6 Events

            var btn = new Button();
            btn.OnClick += () => Console.WriteLine("btn was clicked!");
            btn.OnClick += () => Console.WriteLine("check how works chain call");
            btn.Click();
            
            #endregion

            #region Exercise7 LINQ

            var arrOfNums = new[] {7, 5, 5, 55, 4, 5, 8, 64};

            Console.WriteLine
                ("Count of even nums is: {0}", arrOfNums.Count(n => n%2 == 0));

            var text = new List<string>
            {
                "this string without key",
                "forty two is an answer",
                "another one usless string",
            };

            Console.WriteLine(
                "Result of searching forty two: {0} \n" +
                "Result of searching aliens is: {1}"
                , text.Any(s => s.Contains("forty two"))
                , text.Any(s => s.Contains("aliens"))
                );

            var personnel = new List<Man>
            {
                new Man {Name = "Victor", Age = 40},
                new Man {Name = "Ivan", Age = 29},
                new Man {Name = "Chack", Age = 36},
                new Man {Name = "Natali", Age = 25},
            };


            foreach (var person in personnel.Where(n => n.Age%5 == 0))
                Console.WriteLine("{0}, {1} years old", person.Name, person.Age);


            Console.WriteLine("Ordered list of names:");
            foreach (var name in personnel.Select(m => m.Name).OrderBy(s => s))
                Console.WriteLine("{0,10}", name);

            #endregion

            
            Console.ReadKey();
        }

        public static T[,] CreateMatrix <T> (int cols, int rows, T content)
            where T: struct 
        {
                var OUT = new T[cols,rows];
 
                for (var i=0; i<cols; i++)
                {
                    for(var j=0; j<rows; j++)
                    {
                        OUT[i, j] = content;
                    }
                }
                return OUT;
        }


    }
    public static class DateTimeExtensions
    {
        public static int CurrentAge(this DateTime date)
        {
            var today = DateTime.Now;
            var diff = today.Year - date.Year;
            if (today.Month < date.Month) diff--;
            else if (today.Month == date.Month 
                && today.Day < date.Day) diff--;

            return diff;
        }
    }
}
