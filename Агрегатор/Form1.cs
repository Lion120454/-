using System;
using System.Windows.Forms;


namespace Агрегатор
{
    public partial class Form1 : Form
    {
		public Form1()
        {
			InitializeComponent();
        }
		private void ButtonClick(object sender, EventArgs e)
		{
            string link, city, stamp, model, generation, request;
            city = textBoxCity.Text;
            stamp = textBoxStamp.Text;
            model = textBoxModel.Text;
            string wmi = textBoxVin.Text;
            wmi = wmi.Substring(0, 3);
            generation = textBoxGeneration.Text;
            request = textBoxRequest.Text;
            link = "https://www.avito.ru/" + city + "/zapchasti_i_aksessuary/zapchasti/dlya_avtomobiley?cd=1&q=" + stamp + "+" + model + "+" + generation + "+" + request;


            labelAvitoCount.Text = Request.Parser(Request.GetRequest(link))+" объявления";
            string s;
            //vin.WorldManufacturerIdentifiers.TryGetValue(wmi, out s);
            //labelAvitoCount.Text = s;




			//richTextBoxDrom.Text=Request.Parser
			//(Request.GetRequest("https://baza.drom.ru/tomsk/sell_spare_parts/руль/model/toyota+vista/?autoPartsFuel=gasoline&autoPartsGeneration=4&autoPartsVolume=2000/"));
			//richTextBoxAutoTrade.Text= Request.Parser
			//(Request.GetRequest("https://autotrade.su/tomsk/catalog/toyota/vista/77/gabarit"));
		}
    }
}
//https://www.avito.ru/tomsk/zapchasti_i_aksessuary/zapchasti/dlya_avtomobiley