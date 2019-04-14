using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestSharp;
using System.Collections;
using Newtonsoft.Json.Linq;

namespace MedBot
{
    public partial class Form1 : Form
    {
        IEnumerable<MedItem> totalMedItems = Enumerable.Empty<MedItem>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void GetResults_Click(object sender, EventArgs e)
        {
            if (!(userInputBox.Text==null && userInputBox.Text.Equals("")))
            {
                var client = new RestClient("https://api.lexigram.io/v1/extract/entities");
                string API_KEY = Environment.GetEnvironmentVariable("MED_BOT_KEY",EnvironmentVariableTarget.Machine);
                var request = new RestRequest(Method.POST);
                request.AddHeader("content-type", "application/json");
                request.AddHeader("authorization", string.Format("Bearer {0}", API_KEY));
                MedRequestObject reqBody = new MedRequestObject(userInputBox.Text);
                request.AddJsonBody(reqBody);
                IRestResponse response = client.Execute(request);
                JObject jsonResp = JObject.Parse(response.Content);
                JArray matchesArray = (JArray)jsonResp.GetValue("matches");

                ArrayList medicines = new ArrayList();
                foreach (JObject temp in matchesArray)
                {

                    bool isDrug = false;
                    foreach(JToken typeToken in temp.GetValue("types"))
                    {
                        isDrug= typeToken.ToString().Equals("DRUGS");
                    }
                    if (isDrug)
                    {
                        string medicine = "";
                        JObject explanation = (JObject) temp.GetValue("explanation");
                        foreach (JObject token in explanation.GetValue("matchedTokens"))
                        {
                            medicine += token.GetValue("token") + " ";
                        }
                        if (!(medicine == "" && medicines.Contains(medicine)))
                        {
                            medicines.Add(medicine);
                            Console.WriteLine(medicine);
                        }
                        Console.WriteLine("Medicine name "+medicines.Count.ToString());
                    }
                }
                foreach(string medName in medicines)
                {
                    List<MedItem> medies = MedItem.getMedItems(medName);
                    Console.WriteLine(medies.Count.ToString());
                    this.totalMedItems = this.totalMedItems.Union(medies);
                    
                }
                
                updateListView();
                userInputBox.Text = null;

            }

        }
        public void updateListView()
        {
            MedicineItemsView.Items.Clear();
            Console.WriteLine("Total Items :"+ totalMedItems.ToList<MedItem>().Count.ToString());
            foreach (MedItem item in totalMedItems){
                var row = new string[] { item.ID.ToString(), item.medName, item.medType,item.price, item.url.ToString() };
                var lvi = new ListViewItem(row);

                lvi.Tag = item;
                MedicineItemsView.Items.Add(lvi);
            }
        }
    }
}

