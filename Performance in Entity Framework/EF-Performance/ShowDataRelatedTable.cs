using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Performance
{
    using System.Data.Entity;
    public class ShowDataRelatedTable
    {
        static void Main(string[] args)
        {
         
            PrintAdsFast();
            SelectAllAdsWithoutInclude();
        }

        static void PrintAdsFast()
        {
            var adsEntities = new AdsEntities();
            Console.WriteLine("List employees (without N+1 query problem):");
            var ads = new List<string>();
            var startTime = DateTime.Now;
            foreach (
                var ad in
                    adsEntities.Ads.Include(a => a.AdStatus)
                        .Include(a => a.Town)
                        .Include(a => a.Category)
                        .Include(a => a.AspNetUser))
            {
                Console.WriteLine("Title: " + ad.Title + ", Status: " + ad.AdStatus.Status +
                    ", Category: " + (ad.Category == null ? "(no category)" : ad.Category.Name) +
                    ", Town: " + (ad.Town == null ? "(no town)" : ad.Town.Name) +
                    ", User: " + ad.AspNetUser.Name);
            }
            Console.WriteLine("Time elapsed: {0}", DateTime.Now - startTime);
            Console.WriteLine(String.Join("\n", ads));
            Console.WriteLine();
        }

        public static void SelectAllAdsWithoutInclude()
        {

            Console.WriteLine("List all ads(with problem): ");
            var adss = new List<string>();
            var startTime = DateTime.Now;
            var context = new AdsEntities();
           
            foreach (var ad in context.Ads)
            {

                Console.WriteLine("Title: " + ad.Title + ", Status: " + ad.AdStatus.Status +
                     ", Category: " + (ad.Category == null ? "(no category)" : ad.Category.Name) +
                     ", Town: " + (ad.Town == null ? "(no town)" : ad.Town.Name) +
                     ", User: " + ad.AspNetUser.Name);
                
            }
            
            Console.WriteLine("Time elapsed: {0}", DateTime.Now - startTime);
            Console.WriteLine(String.Join("\n", adss.Take(5)));
            Console.WriteLine("...");
            Console.WriteLine();
        }

  
    }
}
        