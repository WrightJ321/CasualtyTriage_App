using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniProj_WrightJ
{
    //add informational box for each question prompt
    public static class Data
    {
        public static List<Casualty> userCasualties = new List<Casualty>();
    }
    public class Casualty
    {
        public int Weight { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Evac { get; set; }

        public Casualty() { }
        public Casualty(int weight, int age, string gender, string evac)
        {
            Weight = weight;
            Age = age;
            Gender = gender;
            Evac = evac;
            

        }


    }
}
