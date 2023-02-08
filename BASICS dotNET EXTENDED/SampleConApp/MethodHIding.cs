using System;


namespace SampleConApp
{
    class BaseClass
    {
        public void BaseFunc() => Console.WriteLine("base func is implemented");
    }

    class DerivedClass : BaseClass
    {
        public void DerivedFunc() => Console.WriteLine("derived func implemented");//base implemented
        public new void BaseFunc() => Console.WriteLine("base in derived class");
    }
    class MethodHIding
    {
        static void Main(string[] args)
        {
            BaseClass obj = new DerivedClass();
            obj.BaseFunc();

            if(obj is DerivedClass)
            {
               DerivedClass obj2 = obj as DerivedClass;
                obj2.BaseFunc();
                obj2.DerivedFunc();
            }
            
        }
    }
}
