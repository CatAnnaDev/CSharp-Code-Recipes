using System;
namespace GuideCSharp.Patterns.Creationalpatterns.AbstractFactory
{
    // https://dl.dropboxusercontent.com/s/3uu3xvy1bsajypt/19101.png
    public class AbstractFactory
	{
		public AbstractFactory()
		{
            //client code
            void TestFactory(IFactory factory)
            {
                IProductA productA = factory.CreateA();
                IProductB productB = factory.CreateB();
                productA.TestA();
                productB.TestB();
            }

            TestFactory(new Factory1());
            //printed: test A1
            //         test B1
            TestFactory(new Factory2());
            //printed: test A2
            //         test B2
        }
    }

    //abstract factory
    interface IFactory
    {
        IProductA CreateA();
        IProductB CreateB();
    }

    //concrete factory 1
    class Factory1 : IFactory
    {
        public IProductA CreateA()
        {
            return new ProductA1();
        }
        public IProductB CreateB()
        {
            return new ProductB1();
        }
    }

    //concrete factory 2
    class Factory2 : IFactory
    {
        public IProductA CreateA()
        {
            return new ProductA2();
        }
        public IProductB CreateB()
        {
            return new ProductB2();
        }
    }

    //abstract product A
    interface IProductA
    {
        void TestA();
    }

    //abstract product B
    interface IProductB
    {
        void TestB();
    }

    //concrete product A1
    class ProductA1 : IProductA
    {
        public void TestA()
        {
            Console.WriteLine("test A1");
        }
    }

    //concrete product A2
    class ProductA2 : IProductA
    {
        public void TestA()
        {
            Console.WriteLine("test A2");
        }
    }

    //concrete product B1
    class ProductB1 : IProductB
    {
        public void TestB()
        {
            Console.WriteLine("test B1");
        }
    }

    //concrete product B2
    class ProductB2 : IProductB
    {
        public void TestB()
        {
            Console.WriteLine("test B2");
        }
    }
}

