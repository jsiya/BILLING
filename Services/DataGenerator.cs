using BILLING.Models;
using Bogus;
using System;
using System.Collections.Generic;
using Bogus;
//using Bogus.DataSets;
using Bogus.Extensions.Norway;

namespace BILLING.Services;


public static class DataGenerator
{
    public const int NumberOfCustomers = 5; //s-yaradacagi customer sayi

    public static List<Tariff> tarifs;  //tarifler arasindan random secsin deye bunu dbden getir!!!
    public static List<Customer> customers = new(); //randaom datalar verib return edeceyi musteriler
    private static Faker<Network> GetNetworkGenerator(string? MAC) //customerere random sebeke vermek
    {
        return new Faker<Network>()
            .RuleFor(n => n.MAC, _ => MAC)
            .RuleFor(n => n.IP, f => f.Internet.IpAddress().ToString())
            .RuleFor(n => n.Upload, f => f.Random.Float(0, 300))
            .RuleFor(n => n.Download, f => f.Random.Float(0, 300))
            .RuleFor(n => n.Action, f => f.Random.Bool())
            .RuleFor(n => n.LastModifyDate, f => f.Date.Past(1, DateTime.UtcNow))
            .RuleFor(n => n.ExpireDate, f => f.Date.Past(1));

    }

    private static Faker<Address> GetAddressGenerator() //random address verme kuceni enumdan secir
    {
        return new Faker<Address>("az")
            .RuleFor(a => a.Street, f => f.PickRandomWithout<Streets>())
            .RuleFor(a => a.Apartment, f => f.Address.SecondaryAddress())
            .RuleFor(a => a.Building, f => f.Address.BuildingNumber());
    }

    private static Faker<Complaint> GetComplaintGenerator(Guid? subcriberId) //random sikayet lorem-le
    {
        return new Faker<Complaint>("az")
            .RuleFor(c => c.Id, f => f.Random.Guid())
            .RuleFor(c => c.SubscriberId, _ => subcriberId.ToString())
            .RuleFor(c => c.Status, f => f.Random.Bool())
            .RuleFor(c => c.Content, f => f.Lorem.Word())
            .RuleFor(c => c.Description, f => f.Lorem.Text())
            .RuleFor(c => c.SentDate, f => f.Date.Past(1));
    }

    private static Faker<Payment> GetPaymentGenerator() // random odenisler buna bax!!!!
    {
        return new Faker<Payment>()
            .RuleFor(p => p.Id, f => f.IndexGlobal)
            .RuleFor(p => p.Amount, f => f.Random.Short(10 - 35))
            .RuleFor(p => p.Terminal, f => f.PickRandom<string>("EManat", "MilliOn", "EPUL"))
            .RuleFor(p => p.PaymentDate, f => f.Date.Past(3));
    }

    private static Faker<Customer> GetCustomerGenerator() //random 1 musteri
    {
        return new Faker<Customer>("az")
            .RuleFor(c => c.SubscriberId, f => f.Random.Guid())
            .RuleFor(c => c.Name, f => f.Person.FirstName)
            .RuleFor(c => c.Surname, f => f.Person.LastName)
            .RuleFor(c => c.Phone, f => f.Person.Phone)
            .RuleFor(c => c.IdentityNumber, f => f.Person.Fødselsnummer())
            .RuleFor(c => c.Mail, f => f.Person.Email)
            .RuleFor(c => c.MAC, f => f.Internet.Mac())
            .RuleFor(c => c.Balance, f => f.Random.Float(-50, 100))
            .RuleFor(c => c.Tarif, f => f.PickRandom(tarifs))
            .RuleFor(c => c.CustomerAdress, GetAddressGenerator())
            .RuleFor(c => c.PaymentHistory, GetPaymentGenerator().Generate(20))
            .RuleFor(c => c.Complaints, (_, c) => GetComplaintGenerator(c.SubscriberId).Generate(3))
            .RuleFor(c => c.CustomerNetwork, (f, c) => GetNetworkGenerator(c?.MAC));
            
    }
    public static void BogusData() //verilen sayda musteri qaytarir
    {
        var customerGenerator = GetCustomerGenerator();
        var generatedCustomers = customerGenerator.Generate(NumberOfCustomers);
        customers.AddRange(generatedCustomers);
    }
}
