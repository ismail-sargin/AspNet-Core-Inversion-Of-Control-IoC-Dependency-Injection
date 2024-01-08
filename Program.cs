// See https://aka.ms/new-console-template for more information
using IOC.Console;

BLL bll = new BLL(new DAL());
bll.GetProducts().ForEach(x =>
{
    Console.WriteLine($"{x.Id}-{x.Name}-{x.Price}-{x.Stock}");
});
