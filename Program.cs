using System;
using System.Collections.Generic;
using System.Globalization;
using factory;
using lam;
using sai;
using System.Linq;
//using score;
//using person;
namespace csharp_console_directories
{
    class Program
    {
        private  void divide (int number){
            // List<int> numbers = new List<int>();
            // while (number>0){
            //     numbers.add(number % 1000);
            //     number /= 1000;
            // }
            // for (int i =numbers.count()-1; i >= 0; i--)
            // {
            //     Console.WriteLine(numbers[i]);
            // }
            
        }
        static void Main(string[] args)
        {
            //int num = Convert.ToInt32(Console.ReadLine());
            // divide(inp);
            //num.divider();


            // DateTime d = new DateTime(2014, 05, 21);
            // string s = d.GetPersianDate(); 

            // string name = "sina ahmadkhani";
            // name.toFarsi();
            Saipa saipa = new Saipa(10,10,10);
            //Console.WriteLine(saipa.speed);


            car pride = new Saipa(9,9,9);


            IEnumerable<int> mylist = new List<int>(); 

            List<int> array = new List<int>();

            int [] randomNumbers = {123,12,1,5,6,8,0,9,66,88};

            var list = (from n in randomNumbers where n>10 select n).ToList();
        
            // var sortedList = list.Sort((inp1,inp2) => {
            //     if(inp1>inp2)
            //         return 1;
            //     else
            //         return 0;
            //     return 1;
                
            // });
            // Console.WriteLine(sortedList.ToString());

            var list2 = (from n in randomNumbers where n>0 orderby n  ascending select n).ToList();
            //var list3 = (from n in randomNumbers where n==2 select n).Count;


            Person person1 = new Person(1,"sina","ak",19);
            Person person2 = new Person(1,"rahim","sb",20);
            Person person3 = new Person(1,"ali","ili",20);
            Person [] persons = new Person[3];
            persons[0]=person1; 
            persons[1]=person2;
            persons[2]=person3;

            Score score1 = new Score(20,19,18,1);
            Score score2 = new Score(10,17,8,2);
            Score score3 = new Score(14,16,15,3);
            Score[] scores = new Score[3];
            scores[0]=score1; 
            scores[1]=score2;
            scores[2]=score3;


            // var joined = (from person in persons
            //  join score in scores
            //   on person.id equals score.id
            //    select new{
            //     name = person.name,
            //     cSharp = person.cSharp,
            //     c = person.c,
            //     java=person.java
            // }).toArray();


            var average = (from person in persons 
            join score in scores
            on score1.id equals person.id select (score.java+score.c+score.cSharp)/3).toArray;
            

            var avrg= (from score in scores let avg =(a+b+c)/3 select avg).ToList();
            foreach(int item in avrg){
                Console.WriteLine(item);
            }

            var max = (from score in scores let ma = max(a,b,c) select ma);
            


            //var max = (from person in persons
             //select max(person.c,person.cSharp,person.java,person.))

            
        }
    }

    public class Person{
        public int _id;
        public string _name;

        public string _lastName;
        public int _age;

        public Person(int _id,string _name,string _lastName,int _age){
                this._id = _id;
                this._age =_age;
                this._lastName = _lastName;
                this._name = _name;
        }
    }
    
    class Score{
        private int _java;
        private int _c;
        private int _cSharp;
        private  int _id;

        public Score(int _java, int _c,int _cSharp, int _id){
            this._java=_java;
            this._cSharp = _cSharp;
            this._c = _c;
            this._id = _id;

        }

        public int java {
            get{return _java; }
            set{ _java = value; }
        }

        public int c {
            get{return _c; }
            set{ _c = value; }
        }
        public int cSharp {
            get{return _cSharp; }
            set{ _cSharp = value; }
        }
        public int id {
            get{return _id; }
            set{ _id = value; }
        }


    }
    // static class GregorianCalendar{
    //     static private int number;
    //     // public numberDivider(int number){
    //     //     this.number = number;

    //     // }
    //     static public void divider (this int number){
    //         Console.WriteLine(number.ToString("N7"));
    //         //Console.WriteLine("{0:n}",inp);
    //     }
    // }
    // public static string GetPersianDate(this DateTime date)
    // {
    //     PersianCalendar jc = new PersianCalendar();
    //    // return string.Format("{0:0000}/{1:00}/{2:00}"  , jc.GetYear(date), jc.GetMonth(date), jc.GetDayOfMonth(date));
    //    return null;
    // }
    // public static DateTime GetDateTimeFromJalaliString(this string jalaliDate)
    // {
    //     PersianCalendar jc = new PersianCalendar();

    //     try
    //     {
    //         string[] date = jalaliDate.Split('/');
    //         int year = Convert.ToInt32(date[0]);
    //         int month = Convert.ToInt32(date[1]);
    //         int day = Convert.ToInt32(date[2]);

    //         DateTime d = jc.ToDateTime(year, month, day, 0, 0, 0, 0, PersianCalendar.PersianEra);

    //         return d;
    //     }
    //     catch
    //     {
    //         throw new FormatException("The input string must be in 0000/00/00 format.");
    //     }
    // }
    // public static DateTime ConvertToGregorian(this DateTime obj)
    // {
    //         GregorianCalendar gregorian = new GregorianCalendar();
    //         int y = gregorian.GetYear(obj);
    //         int m = gregorian.GetMonth(obj);
    //         int d = gregorian.GetDayOfMonth(obj);
    //         DateTime gregorianDate = new DateTime(y, m, d);
    //         var result = gregorianDate.ToString(CultureInfo.InvariantCulture);
    //         DateTime dt = Convert.ToDateTime(result);
    //         return dt;
    // }

    static class farsi{
        public static void toFarsi(this string name){
            Console.WriteLine("سینا احمدخانی");
        }
    }
}

