using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Microsoft.Extensions.DependencyInjection;
using System.ServiceProcess;

namespace App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddSingleton<IProductService, ProductManager>();
            serviceCollection.AddSingleton<ICategoryService, CategoryManager>();
            serviceCollection.AddSingleton<IProductRepository, EfProductDal>();
            serviceCollection.AddSingleton<ICategoryRepository, EfCategoryDal>();

            var serviceProvider = serviceCollection.BuildServiceProvider();



            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1(serviceProvider.GetRequiredService<IProductService>(), serviceProvider.GetRequiredService<ICategoryService>()));
        }
    }
}