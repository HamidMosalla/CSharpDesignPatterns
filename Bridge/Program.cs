using System;
using Bridge.AbstractionRefined;
using Bridge.ImplementorConcrete;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
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
