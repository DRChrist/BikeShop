using System.Linq;
using BikeShop.Models.Entities;

namespace BikeShop.Data
{
    public class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            if(context.Bikes.Any())
            {
                return; //DB has been seeded
            }

            var bikes = new Bike[]
            {
                new Bike{BikeId=1, Name="Kildemoes Hjultriller", Manufacturer="Kildemoes", Type="Citybike", Gears=3, Price=1000.50,
                    Picture="https://fricdn.dk/Admin/Public/getImage.ashx?Image=/Files/Images/FriBikeShop/ProductImages/sort-scott-sub-sport-20-kvinde-trekking-kvinde-2016.jpg&Width=274&Crop=5&Compression=95&altFmImage_path=/Files/Templates/Designs/FriBikeShop/assets/images/no-image.jpg"},
                new Bike{BikeId=2, Name="Kildemoes Mosekilde", Manufacturer="Kildemoes", Type="Citybike", Gears=5, Price=500,
                    Picture="https://fricdn.dk/Admin/Public/getImage.ashx?Image=/Files/Images/FriBikeShop/ProductImages/sort-kildemoes-city-retro-ltd-2017.jpg&Width=274&Crop=5&Compression=95&altFmImage_path=/Files/Templates/Designs/FriBikeShop/assets/images/no-image.jpg"},
                new Bike{BikeId=3, Name="Scott Sub Sport 20", Manufacturer="Scott", Type="Citybike", Gears=12, Price=2800.28,
                    Picture="http://cdn.bikemag.com/uploads/2015/06/Scott-2016-Genius-and-Scale-Plus-3.jpg"},
                new Bike{BikeId=4, Name="Scott Sub Zero -273,15", Manufacturer="Scott", Type="Citybike", Gears=4, Price=1400.36,
                    Picture="http://www.nihola.com/fileadmin/_processed_/csm_4.0_oblique_no_hood_ladcykler_180b93617b.jpg"},
                new Bike{BikeId=5, Name="Trek Zektor Three", Manufacturer="Trek", Type="Citybike", Gears=18, Price=14000.50,
                    Picture="https://www.cykelshoppen.dk/14776/trek-madone-92-carbon-h2-viper-red-2017.jpg"},
                new Bike{BikeId=6, Name="Trek Zektor Zeven", Manufacturer="Trek", Type="Citybike", Gears=15, Price=200,
                    Picture="https://gzmyu4ma9b-flywheel.netdna-ssl.com/wp-content/uploads/2011/07/Trek-2012-Slash-9-Profile.jpg"},
                new Bike{BikeId=7, Name="Centurion Cohort", Manufacturer="Centurion", Type="Citybike", Gears=8, Price=3600.36,
                    Picture="https://www.designcykler.dk/images/nihola-ladcykel-p.jpg"}
            };
            foreach(Bike b in bikes)
            {
                context.Bikes.Add(b);
            }
            context.SaveChanges();
        }
    }
}