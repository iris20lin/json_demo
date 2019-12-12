using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON_DEMO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSerialize_Click(object sender, EventArgs e)
        {
            NPC npc = new NPC();
            npc.Name = "王大頭";
            npc.Hp = 200;
            npc.Lv = 99;
            string json = JsonConvert.SerializeObject(npc);

            NPC[] npcs = new NPC[5];
            npcs[0] = new NPC("張三", 100, 20);
            npcs[1] = new NPC("李四", 110, 10);
            npcs[2] = new NPC("王五", 200, 60);
            string jsons = JsonConvert.SerializeObject(npcs);

            List<NPC> npcList = new List<NPC>();
            npcList.Add(new NPC("張三", 100, 20));
            npcList.Add(new NPC("李四", 110, 10));
            npcList.Add(new NPC("王五", 200, 60));
            string jsonList = JsonConvert.SerializeObject(npcList);

            Console.WriteLine(jsonList);
        }

        private void btnDeserialize_Click(object sender, EventArgs e)
        {
            //逸出字元
            string json = "{\"UTC\": \"2019-12-12 10:59:59\", \"Exrate\": 30.353}";

            CoinRate usdtwd = JsonConvert.DeserializeObject<CoinRate>(json);

            Console.WriteLine($"usdTWD  匯率 ={usdtwd.Exrate} 公告時間:{usdtwd.UTC}");

        }

        private void btnWeb_Click(object sender, EventArgs e)
        {
            WebClient client = new WebClient();
            string reply = client.DownloadString("https://tw.rter.info/capi.php");
            RterResponse m = JsonConvert.DeserializeObject<RterResponse>(reply);

            // 
            float usd = float.Parse(txtUSD.Text);
            float twd = usd * m.USDTWD.Exrate;
            txtTWD.Text = twd.ToString();
                       
            Console.WriteLine(m.USDTWD.Exrate);
        }
    }
}
