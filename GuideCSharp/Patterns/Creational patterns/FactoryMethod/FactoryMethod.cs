using System;
namespace GuideCSharp.Patterns.Creationalpatterns.FactoryMethod
{
    // https://dl.dropboxusercontent.com/s/pqy266z2c51fqzy/19103.png
    public class FactoryMethod
	{
		public FactoryMethod()
		{
            //Client
            Creator creator = new Creator();
            creator.Test();
            //printed: Employee

            creator = new ManagerCreator();
            creator.Test();
            //printed: Manager
        }
    }

    //Product
    class Employee
    {
        public virtual void Test()
        {
            Console.WriteLine("Employee");
        }
    }

    //ConcreteProduct
    class Manager : Employee
    {
        public override void Test()
        {
            Console.WriteLine("Manager");
        }
    }

    //Creator
    class Creator
    {
        //FactoryMethod
        protected virtual Employee CreateEmployee()
        {
            return new Employee();
        }

        //Some operation
        public void Test()
        {
            CreateEmployee().Test();
        }
    }

    //ConcreteCreator
    class ManagerCreator : Creator
    {
        //FactoryMethod
        protected override Employee CreateEmployee()
        {
            return new Manager();
        }
    }

}

