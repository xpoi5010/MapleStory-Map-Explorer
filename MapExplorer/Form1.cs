using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Diagnostics;


namespace MapExplorer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            if (!File.Exists("Map.xml")) Application.Exit();
            InitializeComponent();
            ProcessingWorker.RunWorkerAsync();
            ProcessingWorker.RunWorkerCompleted += ProcessingWorker_RunWorkerCompleted;
            this.Loading.Visible = true;
        }

        private void ProcessingWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.Loading.Visible = false;
            foreach(string Key in collection.Keys)
            {
                street_combo.Items.Add(Key);
            }
        }

        private enum ReadStatus
        {
            id,streetname,mapname,none
        }

        MapList collection = new MapList();
        private void ProcessingWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            Map temp = new Map();
            XmlDocument document = new XmlDocument();
            document.Load($@"{Application.StartupPath}\Map.xml");
            XmlNodeReader xnr = new XmlNodeReader(document);
            ReadStatus status = ReadStatus.none;
            while (xnr.Read())
            {
               
                switch (xnr.NodeType)
                {
                    case XmlNodeType.Element:
                        switch (xnr.Name)
                        {
                            case "imgdir":
                                if (IsInteger(xnr.GetAttribute("name")))
                                {
                                    temp = new Map();
                                    status = ReadStatus.id;
                                    temp.Id = xnr.GetAttribute("name");
                                }
                                break;
                            case "string":
                                string attr = xnr.GetAttribute("name");
                                switch (attr)
                                {
                                    case "streetName":
                                        status = ReadStatus.streetname;
                                        temp.StreetName = xnr.GetAttribute("value");
                                        break;
                                    case "mapName":
                                        status = ReadStatus.mapname;
                                        temp.MapName = xnr.GetAttribute("value");
                                        break;
                                }
                                break;
                        }
                        
                        break;
                    case XmlNodeType.EndElement:
                        switch (xnr.Name)
                        {
                            case "imgdir":
                                if (IsInteger(xnr.GetAttribute("name")))
                                {
                                    collection.Add(temp);
                                }
                                break;
                        }
                        break;
                    
                }
            }
        }
        private bool IsInteger(string value)
        {
            string temp = value;
            char[] number = {'0','1','2','3','4','5','6','7','8','9'};
            char[] values = value.ToCharArray();
            foreach(char Char in number)
            {
                temp = temp.Replace(Char.ToString(), "");
            }
            return temp == "";
        }

        private void street_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedStreetName = (string)street_combo.Items[street_combo.SelectedIndex];
            List<Map> maps = collection[SelectedStreetName];
            Name_combo.Items.Clear();
            Name_combo.Text = "" ;
            foreach (Map map in maps)
            {
                Name_combo.Items.Add(map.MapName??"(無地圖名稱)");

            }
            ssn = SelectedStreetName;
            smn = "";
        }

        string ssn = "";
        string smn = "";
        string sid = "";

        private void button6_Click(object sender, EventArgs e)
        {
            if (smn == "" || ssn == "") return;
            update();
            Map Selected = collection[ssn].Find(x => x.MapName == smn && x.StreetName == ssn);
            sid = Selected.Id;
            smn = Selected.MapName;
            ssn = Selected.StreetName;
            output();
        }

        private void street_combo_TextChanged(object sender, EventArgs e)
        {
            if (street_combo.Items.Contains(street_combo.Text))
            {
                street_combo.SelectedIndex = street_combo.Items.IndexOf(street_combo.Text);

            }
        }

        private void Name_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string SelectedMapName = (string)Name_combo.Items[Name_combo.SelectedIndex];
            smn = SelectedMapName;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string InputId = id_input.Text;
            Map output = new Map();
            foreach(string key in collection.Keys)
            {
                Map a = collection[key].Find(x => x.Id == InputId);
                if(a.Id !=null && a.StreetName != null&& a.MapName != null)
                {
                    output = a;
                }
            }
            if (output.Id != null && output.StreetName != null && output.MapName != null)
            {
                sid = output.Id;
                smn = output.MapName;
                ssn = output.StreetName;
            }
            this.output();
        }

        private void output()
        {
            id.Text = $"地圖代號:{sid}";
            street.Text = $"地圖街道:{ssn}";
            name.Text = $"地圖名稱:{smn}";
        }

        private void update()
        {
            string SelectedMapName = (string)Name_combo.Items[Name_combo.SelectedIndex];
            smn = SelectedMapName;
            string SelectedStreetName = (string)street_combo.Items[street_combo.SelectedIndex];
            ssn = SelectedStreetName;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Copy(sid);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Copy(ssn);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Copy(smn);
        }

        private void Copy(string text)
        {
            Clipboard.SetText(text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Copy(String.Format("{0}-{1} {2}", sid, ssn, smn));
        }


    }
}

