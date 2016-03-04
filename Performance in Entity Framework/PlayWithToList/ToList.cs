using EF_Performance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWithToList
{
    class ToList
    {
        static void Main(string[] args)
        {
           // ToListSlow();
            ToListFast();
        }

        private static void ToListSlow()
        {
            var db = new AdsEntities();
            var ad = db.Ads.ToList();
            var starTime = DateTime.Now;
            var ads = db.Ads
            .ToList()
            .Where(a => a.AdStatus.Status == "Published")
            .Select(a => new
            {
                a.Title,
                a.Category,
                a.Town,
                a.Date
            })
            .ToList()
            .OrderBy(a => a.Date);
            var endTime = DateTime.Now;
            Console.WriteLine(endTime - starTime);
            Console.WriteLine(ads.Count());
        }

        private static void ToListFast()
        {
           var startTime = DateTime.Now;
           var db = new AdsEntities();
           var ad = db.Ads.ToList();
            var ads2 = db.Ads
            .Where(a => a.AdStatus.Status == "Published")
                //.OrderBy(a => a.Date)
            .Select(a => new
            {
                a.Title,
                a.Category,
                a.Town
            })
            .ToList();
            var endTime = DateTime.Now;
            Console.WriteLine(endTime - startTime);
            Console.WriteLine(ads2.Count());

        }


    }
}
