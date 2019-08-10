using System;
using System.Collections.Generic;

namespace CovarianceAndContravarianceSample
{
    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eat");
        }
    }
    public class Bird : Animal
    {
        public void Fly()
        {
            Console.WriteLine("Fly");
        }
    }

    internal delegate Animal ReturnAnimalDelegate();
    internal delegate Bird ReturnBirdDelegate();

    internal delegate void TakeAnimalDelegate(Animal a);
    internal delegate void TakeBirdDelegate(Bird b);

    internal interface IProcess<out T>
    {
        T Process();
    }
    public class AnimalProcessor<T> : IProcess<T>
    {
        public T Process()
        {
            throw new NotImplementedException();
        }
    }

    internal interface IZoo<in T>
    {
        void Add(T t);
    }
    public class Zoo<T> : IZoo<T>
    {
        public void Add(T t)
        {

        }
    }

    internal class Program
    {
        public static Bird GetBird()
        {
            return new Bird();
        }
        public static Animal GetAnimal()
        {
            return new Animal();
        }

        public static void Eat(Animal a)
        {
            a.Eat();
        }
        public static void Fly(Bird b)
        {
            b.Fly();
        }

        private static void Main(string[] args)
        {
            //delegates covariance
            Animal a = new Bird();
            ReturnAnimalDelegate d = GetBird;

            //Delegates contravariance
            TakeBirdDelegate d2 = Eat;
            d2(new Bird());

            //arrays covariance
            Animal[] animals = new Bird[10];

            //generics covariance
            IProcess<Animal> animalProcessor = new AnimalProcessor<Animal>();
            IProcess<Bird> birdProcessor = new AnimalProcessor<Bird>();

            Animal animal = birdProcessor.Process();
            animalProcessor = birdProcessor;

            IEnumerable<Animal> animalList = new List<Bird>();

            //generic contravariance
            IZoo<Animal> animalZoo = new Zoo<Animal>();
            animalZoo.Add(new Animal());
            IZoo<Bird> birdZoo = new Zoo<Bird>();

            birdZoo = animalZoo;
            birdZoo.Add(new Bird());
        }
    }
}
