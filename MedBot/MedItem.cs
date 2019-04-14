using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using HtmlAgilityPack;


namespace MedBot
{
    class MedItem
    {
        public Guid ID { get; set; }
        public string medName{ get; set; }
        public string medType { get; set; }
        public DateTime created { get; set; }
        public string price { get; set; }
        public Uri url { get; set; }
        public Uri imageUrl { get; set; }
        //public string medUrl { get; set; } 
        public MedItem(string medName, string medType,string price, Uri url)
        {
            this.ID = Guid.NewGuid();
            this.medName = medName;
            this.price = price;
            this.created = DateTime.Now;
            this.url = url;
            //this.imageUrl = imageUrl;
            this.medType = medType;

        }
        public static List<MedItem> getMedItems(string query)
        {
            string url = string.Format("https://www.1mg.com/search/all?name={0}", query);
            var web = new HtmlWeb();
            var doc = web.Load(url);
            List<MedItem> meds = new List<MedItem>();
            HtmlNodeCollection MedicineName = doc.DocumentNode.SelectNodes("//*[contains(concat( ' ', @class, ' ' ),concat( ' ', 'style__pro-title___3zxNC', ' ' ))]");
            HtmlNodeCollection MedicineType = doc.DocumentNode.SelectNodes("//*[contains(concat( ' ', @class, ' ' ), concat( ' ', 'style__pack-size___254Cd', ' ' ))]");
            HtmlNodeCollection MedicinePrice = doc.DocumentNode.SelectNodes("//*[contains(concat( ' ', @class, ' ' ), concat( ' ', 'style__price-tag___B2csA', ' ' ))]");
            HtmlNodeCollection MedicineUrl = doc.DocumentNode.SelectNodes("//*[(@id = 'category-container')]//a");
            HtmlNodeCollection MedicineImage = doc.DocumentNode.SelectNodes("//img[contains(@class,'style__image___Ny-Sa')]");
            string baseLink = "https://www.1mg.com";
            for (int i=0; i < MedicineName.Count; i++)
            {
                string name = MedicineName[i].InnerText;
                string medType = MedicineType[i].InnerText;
                string medPrice = MedicinePrice[i].InnerText;
                Uri medUrl = new Uri(baseLink+MedicineUrl[i].GetAttributeValue("href",""));
                //Uri ImageMedUrl = new Uri(MedicineImage[i].GetAttributeValue("src", "https://image.flaticon.com/icons/svg/172/172835.svg"));
                MedItem item = new MedItem(name, medType, medPrice, medUrl);
                Console.WriteLine(item.ToString());
                meds.Add(item);
            }
            Console.WriteLine(meds.Count.ToString());
            return meds;
        }
        public override string ToString()
        {
            return string.Format("Medicine Id: {0}\n Medicine Name:{1}\n MedicineType:{2}\n" +
                "Medicine Price: {3}\nMedicine URL:{4}\n", this.ID.ToString(), this.medName, this.medType, this.price, this.url.ToString());
        }

    }
}
