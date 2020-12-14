using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class Class1
{
	abstract class Deneme
    {
		public virtual void set()
        {

        }
    }
    class Guru99Tutorial : Deneme
    {
        protected int DenemeID;
        protected string DenemeName;

        public void SetTutorial(int pID, string pName)
        {
            DenemeID = pID;
            DenemeName = pName;
        }

        public String GetTutorial()
        {
            return DenemeName;
        }

        static void Main(string[] args)
        {
            Guru99Deneme pTutor = new Guru99Deneme();

            pTutor.SetDeneme(1, ".Net");

            Console.WriteLine(pTutor.GetDeneme());

            Console.ReadKey();
        }
    }
}
