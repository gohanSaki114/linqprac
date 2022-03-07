using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace linqprac
{

    public class linqcheck
    {


        public void bringDecending(List<string> cities)
        {
            IEnumerable ts = from c in cities
                             orderby c descending
                             select c;
            Console.WriteLine("By Decending"+"\n");
            foreach (string s in ts)
            {
                Console.WriteLine(s);
                
            }

            Console.WriteLine("");    
        }

        public void bringAcecending(List<string> cities)
        {
            IEnumerable ts = from c in cities
                             orderby c 
                             select c;
            Console.WriteLine("By Ascending" + "\n");
            foreach (string s in ts)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("");
        }

        public void bringDecendingOrderBylength(List<string> cities)
        {
            IEnumerable ts = cities.OrderByDescending(x => x.Length);
            var ts1 = from x in cities
                     orderby x.Length descending, x descending
                     select x;
            Console.WriteLine("Decending order by length" + "\n");
            foreach (string s in ts1)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
        }
        public void bringAcecendingOrderBylength(List<string> cities)
        {
           
            var ts1 = from x in cities
                      orderby x.Length ascending, x ascending
                      select x;
            Console.WriteLine("Acecending order by length" + "\n");

            foreach (string s in ts1)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
        }
        public void getNamewithVandD(List<string> cities) 
        {
            IEnumerable resultset = from ed in cities
                                    where ed.StartsWith("V") || ed.StartsWith("D") select ed;
            Console.WriteLine("Bring Data that starts with V and D");
            foreach (string s in resultset)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("");
        }
        public void getNameStartsWithA(List<string> cities)
        {
            IEnumerable<string> resultset = from result in cities
                                    where result.StartsWith("A") select 
                                    result;

          

            Console.WriteLine(resultset.Count());
            Console.WriteLine();
        }

        public static void Main(string[] args)
        {

            List<string> cities = new List<string>
              {
               "Mumbai",
               "Delhi",
               "Ahmedabad",
               "Surat",
               "Valsad",
               "Varanasi",
               "Chennai",
               "Bhopal",
               "Darjeeling",
               };
            linqcheck linqc = new linqcheck();
            linqc.bringDecending(cities);
            linqc.bringAcecending(cities);
            linqc.bringDecendingOrderBylength(cities);
            linqc.bringAcecendingOrderBylength(cities);
            linqc.getNamewithVandD(cities);
            linqc.getNameStartsWithA(cities);
            linqc.getOrderedCityNamebyFirstletter(cities);

        }

        private void getOrderedCityNamebyFirstletter(List<string> cities)
        {
            var result = from ci in cities
                         group ci by ci[0] into ciGroup
                         orderby ciGroup.Key descending
                         select ciGroup;
            //Console.WriteLine(Format("");

            foreach (IGrouping<char,string> Group in result)
            {
                Console.WriteLine(("GroupID = "+ Group.Key));
                foreach (var cx in Group)
                {
                   Console.WriteLine(cx);
                }
            }
        }
    }




}

