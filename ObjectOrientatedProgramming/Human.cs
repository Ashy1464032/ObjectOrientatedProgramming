using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientatedProgramming
{
    public class Human
    {
        public String name;
        public String age;
        public String hasSkillIssues;
        public Human(String Name, int Age, Boolean HasSkillIssues)
        {
            name = Name;
            age = Age.ToString();
            hasSkillIssues = HasSkillIssues.ToString();
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Has Skill issues: " + hasSkillIssues);
            Console.WriteLine("-----------------------");
        }
    }
}
