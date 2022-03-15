using System;
namespace ConsoleApp
{
    public class bank
    {
        private string ownerr;
        private int ball;
        public void accoun(string own,int bal)
        {
            this.ownerr = own;
            this.ball = bal;
        }
        public string ownn
        {
            get
            {
                return this.ownerr;

            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.WriteLine(" invalid name ");
                }
                else
                {
                    this.ownerr = value;
                }
                
            }
        }
        public int dep
        {
            set
            {
                ball += value;
            }
            get
            {
                return this.ball;
            }
        }
        public int wid
        {
            get
            {
                return this.ball;

            }
            set
            {
                if (ball < value)
                {
                    Console.WriteLine("balance is low" ,ball);
                }
                else
                {
                    ball -= value;
                }
            }
           
        }
      public void show()
      {
          Console.WriteLine(ownerr + "  " + ball);
      }

    }
    class program
    {
        static void Main(string[] args)
        {
         
            
            bank obj = new bank();
            obj.accoun("", 1200);

            obj.ownn = "";
            obj.dep=122;
            obj.wid = 10000;
            obj.show();
        }
    }
}
