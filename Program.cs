using System;
using static System.Console;
namespace myApp
{
    class Program
    {
    public class ParentClass 
    {
        private string BaseOuput = null;

        public ParentClass (string ParentString)
        {
            BaseOuput = ParentString;
        }

        public void ParentPrintLine()
        {
            WriteLine(BaseOuput);
        }
    }

    public class ChildClass : ParentClass
    {
       private string DerivedOutput = null;

       public ChildClass (string ParentString, string ChildString) : base(ParentString)
       {
           DerivedOutput = ChildString;
       }

       public void ChildPrintLine()
       {
           WriteLine(DerivedOutput);
       }
    }

        static void Main()
        {
            ParentClass theParent = new ParentClass("Text for ParentClass");
            ChildClass theChild = new ChildClass("Parent String", "Text for ChildClass");

            theParent.ParentPrintLine();
            theChild.ParentPrintLine();
            theChild.ChildPrintLine();

        }
    
    
    }
}
