using System;
using System.Collections.Generic;
using System.Configuration;
using System.Web.Mvc;
using Moq;
using Ninject;
using Domain.Abstract;
using Domain.Entities;


namespace WebUI.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {
            Mock<IBookRepository> mock = new Mock<IBookRepository>();
            mock.Setup(m => m.Books).Returns(new List<Book>
            {
                new Book { Name = "Язык программирования", Author="Троелсен" , Price = 499 },
                new Book { Name = "С#", Author="Уотсон" , Price = 149},
                new Book { Name = "Асинхронное программирование", Author="Эелсен" , Price = 199 }
            });
            kernel.Bind<IBookRepository>().ToConstant(mock.Object);
        }
    }
}
