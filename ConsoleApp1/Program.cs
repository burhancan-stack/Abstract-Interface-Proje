
using System;
using System.Text;
using System.Threading;
using SimuleProje.Abstract;
using SimuleProje.Concrete;
//Senaryo
//Kahve dükkanları için müşteri yönetimi yapan bir sistem yazmak istiyoruz.
//Starbucks ve Nero firması için çalışıyoruz.
//İki firma da müşterilerini veri tabanına eklemek istiyor.
//Starbucks müşterileri kaydederken, mutlaka mernis doğrulaması istiyor.
//Nero müşterileri kaydederken böyle bir kural istemiyor.
//Starbucks müşteriler için bir kahve alımınıda yıldız kazandırmak istiyor.

namespace SimuleProje {
    public class Program
    {
        static void Main(string[] args)
        {


            BaseCustomerManager customerManager = new NeroCustomerManager();

            customerManager.Save(new Customer { DateOfBirth = new DateTime(1985, 1, 6), FirstName = "Can", LastName = "Mert", Id = 1, NationalityId = "258237273" });

            Console.ReadLine();
            


        }  
    }

    
}