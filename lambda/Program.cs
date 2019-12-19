using System;
using System.Linq;
using System.Collections.Generic;
using salary;
using person;
namespace lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numbers = {1,5,32,7,9,1325,264,1258,984,12,842,147,098,14354,12,75,5,6,7};
            //var check =(numbers.Where(args => a==2)).Any();
            // var check2 = numbers.Any(a => a==2);
            // var firstSelect = numbers.Where(a => a==13).First(); // if not there's exception
            // var secondSelect = numbers.Where(a => a==13).FirstOrDefault(); // if not the default is zero!
            // var thirdSelect = numbers.Where(a => a==13).Single(); // there must be one of 13 unless there's exception
            // var fourthSelect = numbers.Where(a => a==13).SingleOrDefault(); 
            // Console.WriteLine(check);
            // Console.WriteLine(fourthSelect);

            string [] names = {"rahim","sina","ali","ahmad","negin","raha"};
            // var sNames = (numbers.Where(a => a.StartWith('s'))).ToList();
            // var iContained = (numbers.Where(a => a.ToLower().Contains('i') )).ToList();

            Person person1 = new Person(1,"sina","ak","shahran");

            Person person2 = new Person(2,"ahmad","wsdg","shahran");
            Person person3 = new Person(3,"tarlan","wegdcx","left abad");
            Person person4 = new Person(4,"mammad","oopcx","right abad");
            Person person5 = new Person(5,"ali","odcvnk","up abbad");



            // Salary salary1 = new Salary(100,200,3000,1);

            // Salary salary2 = new Salary("esfand",4000,2);
            // Salary salary3 = new Salary(100,200,5000,3);
            // Salary salary4 = new Salary(100,200,7000,4);

            List<Person> people = new List<Person>();
            Salary [] salaries = {
                new Salary("esfand",800,1),
                new Salary("bahman",400,1),
                new Salary("dey",400,1),
                new Salary("esfand",400,2),
                new Salary("dey",400,2),
                new Salary("bahman",100,2),
                new Salary("esfand",400,3),
                new Salary("bahman",400,3),
                new Salary("dey",200,3)

            };

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            // salaries.Add(salary1);
            // salaries.Add(salary2);
            // salaries.Add(salary3);
            // salaries.Add(salary4);

            // var richest = people.GroupJoin(salaries,
            // person => person.id,
            // salary => salary.id,
            // (person, salaryGroup) => new {

            //     name = person.name,
            //     sum_of_salary = salaryGroup.ToArray().Sum(s => s.salary)
            // }
            // ).Max(x => x.sum_of_salary);
            var richestPerson = people.GroupJoin(salaries,
            person => person.id,
            salary => salary.id,
            (person, salaryGroup) => new {

                name = person.name,
                sum_of_salary = salaryGroup.ToArray().Sum(s => s.salary)
            }
            ).OrderByDescending(x => x.sum_of_salary).First();

           
            

            Console.WriteLine(richestPerson.name);
            

        }   
    }
}
