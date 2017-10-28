using System;
using Bridge.AbstractionRefined;
using Bridge.ImplementorConcrete;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {

            /*
             * https://en.wikipedia.org/wiki/Bridge_pattern
             What problems can the Bridge design pattern solve?
             An abstraction and its implementation should be defined and extended independently from each other.
             A compile-time binding between an abstraction and its implementation should be avoided so that an implementation can be selected at run-time.

            When using subclassing, different subclasses implement an abstract class in different ways.
            But an implementation is bound to the abstraction at compile-time and can't be changed at run-time.
            */

            var clientRepository = new ClientRepository();
            var clientDataObject = new ClientDataObject();

            clientRepository.AddObject(clientDataObject);
            clientRepository.SaveChanges();

            clientRepository.CopyObject(clientDataObject);
            clientRepository.RemoveObject(clientDataObject);
            clientRepository.SaveChanges();

            Console.WriteLine("===============================================================");

            var productRepository = new ProductRepository();
            var productDataObject = new ProductDataObject();

            productRepository.AddObject(productDataObject);
            clientRepository.SaveChanges();

            productRepository.CopyObject(productDataObject);
            productRepository.RemoveObject(productDataObject);
            productRepository.SaveChanges();




            Console.ReadKey();
        }
    }
}
