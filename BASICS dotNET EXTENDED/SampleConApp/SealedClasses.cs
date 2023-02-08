using System;
namespace SampleConApp
{
    class ChildClass
    {
        public virtual void ChildMethod()
        {
            Console.WriteLine("child method is virtual");
        }
    }
    class ParentClass : ChildClass
    {
        public sealed override void ChildMethod()
        {
            Console.WriteLine("child method is over rided in parent classs");
        }
    }
    class GrandParentClass : ParentClass
    {
        public new  void ChildMethod()
        {
            Console.WriteLine("child method is over rided in grand parent classs");
        }
    }
    class SealedClasses
    {
        static void Main(string[] args)
        {
            ChildClass cls = new ChildClass();
            cls.ChildMethod();
            cls = new ParentClass();
            cls.ChildMethod();
            GrandParentClass cls1 = new GrandParentClass();
            cls1.ChildMethod();
        }

    }
}
