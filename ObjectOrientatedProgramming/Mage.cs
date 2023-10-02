using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientatedProgramming
{
    public class Mage : Human
    {
        public int Level;
        public Mage(String Name, int Age, Boolean HasSkillIssues, int level) : base(Name, Age, HasSkillIssues)
        {
            name = Name;
            age = Age.ToString();
            hasSkillIssues = HasSkillIssues.ToString();
            Level = level;
        }
        public void PrintInfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Has Skill issues: " + hasSkillIssues);
            Console.WriteLine("Your Mage Level: " + Level.ToString());
            Console.WriteLine("-----------------------");
        }
    }
}
