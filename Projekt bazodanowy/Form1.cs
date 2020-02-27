using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;
using System.Xml;
using System.Runtime.Serialization;

namespace Projekt_bazodanowy
{
    public partial class Form1 : Form
    {
        DatabaseBasketballEntities dbModel;

        public Form1(bool  b = true)
        {
            InitializeComponent();

            if (b == true)
            {
                dbModel = new DatabaseBasketballEntities();
                dbModel.Configuration.ProxyCreationEnabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prezes p = new Prezes();
            p.nazwisko = "Smith";
            p.email = "smith@gmail.com";
            p.prezes_id = 1;

            Zespol z = new Zespol();
            z.nazwa = "Chicago Bulls";
            z.zespol_id = 2;

            p.Zespol = z;

            Trener t = new Trener();
            t.nazwisko = "Hoiberg";

            Trener t2 = new Trener();
            t2.nazwisko = "Lue";

            t.Zespol = z;
            t2.Zespol = z;

            Hala h = new Hala();
            h.nazwa = "United Center";
            h.hala_id = 3;

            h.Zespol = z;

            Zawodnik zk = new Zawodnik();
            zk.nazwisko = "Jordan";
            zk.numer = 23;
            DateTime data = new DateTime(1997, 3, 6);
            zk.data_urodzin = data.Date;

            Zawodnik zk2 = new Zawodnik();
            zk2.nazwisko = "LeBron";
            zk2.numer = 7;
            zk2.data_urodzin = data.Date;

            Zawodnik zk3 = new Zawodnik();
            zk3.nazwisko = "Curry";
            zk3.numer = 30;
            zk3.data_urodzin = data.Date;

            zk.Zespol = z;
            zk2.Zespol = z;
            zk3.Zespol = z;

            dbModel.Prezes.Add(p);
            dbModel.Trener.Add(t);
            dbModel.Trener.Add(t2);
            dbModel.Hala.Add(h);
            dbModel.Zawodnik.Add(zk);
            dbModel.Zawodnik.Add(zk2);
            dbModel.Zawodnik.Add(zk3);
            dbModel.SaveChanges();

            MessageBox.Show(null, "Dodano do bazy", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            foreach (Zespol z in dbModel.Zespol)
            {
                listBox.Items.Add(z.nazwa);
                listBox.Items.Add(z.zespol_id.ToString());
            }
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Trener t in dbModel.Trener)
            {
                dbModel.Trener.Remove(t);
            }
            dbModel.SaveChanges();

            MessageBox.Show(null, "Usunieto", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            foreach (Trener t in dbModel.Trener)
            {
                listBox.Items.Add(t.nazwisko);
                listBox.Items.Add(t.trener_id.ToString());
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            foreach (Prezes p in dbModel.Prezes)
            {
                listBox.Items.Add(p.nazwisko);
                listBox.Items.Add(p.email);
                listBox.Items.Add(p.prezes_id.ToString());
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();

            foreach (Zawodnik zk in dbModel.Zawodnik)
            {
                listBox.Items.Add(zk.nazwisko);
                listBox.Items.Add(zk.numer.ToString());
                listBox.Items.Add(zk.zawodnik_id.ToString());
                listBox.Items.Add(zk.data_urodzin.ToString("dd/MM/yyyy"));
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            foreach (Zawodnik zw in dbModel.Zawodnik)
            {
                dbModel.Zawodnik.Remove(zw);
            }
            dbModel.SaveChanges();

            MessageBox.Show(null, "Usunieto", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public bool zapisDoJson()
        {
            File.WriteAllText(@"C: \Users\sniad\Desktop\STUDIA\2 ROK\Pracownia programowania\Projekt bazodanowy\Basketball.json", JsonConvert.SerializeObject(dbModel.Zespol, Newtonsoft.Json.Formatting.None, new JsonSerializerSettings()
            {
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            }));

            MessageBox.Show(null, "Zapisano", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        private void zapisJson_Click(object sender, EventArgs e)
        {
            zapisDoJson();
        }

        public bool sprawdzJson(out List<Zespol> tymczasowyZespol, string sciezkaPlik)
        {
            tymczasowyZespol = new List<Zespol>();
            try
            {
                using (StreamReader file = File.OpenText(sciezkaPlik))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    tymczasowyZespol = (List<Zespol>)serializer.Deserialize(file, typeof(List<Zespol>));
                }
            }
            catch(Exception e)
            {
                throw new ArgumentException("Parametr zespol_id nie moze byc pusty");
            }

            return true;
        }

        public bool odczytZJson()
        {
            List<Zespol> tymczasowyZespol;
            string sciezkaPlik = @"C:\Users\sniad\Desktop\STUDIA\2 ROK\Pracownia programowania\Projekt bazodanowy\Basketball.json";
            sprawdzJson(out tymczasowyZespol, sciezkaPlik);

            foreach (Zespol z in tymczasowyZespol)
                dbModel.Zespol.Add(z);
                
            dbModel.SaveChanges();
            
            MessageBox.Show(null, "Odczytano", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        private void odczytJson_Click(object sender, EventArgs e)
        {
            odczytZJson();
        }

        public bool zapisDoXml()
        {
            int id = 0;
            foreach (Zawodnik z in dbModel.Zawodnik)
                id = z.zawodnik_id;
            foreach (Hala h in dbModel.Hala)
                id = h.hala_id;
            foreach (Prezes p in dbModel.Prezes)
                id = p.prezes_id;
            foreach (Trener t in dbModel.Trener)
                id = t.trener_id;

            string plik = @"C:\Users\sniad\Desktop\STUDIA\2 ROK\Pracownia programowania\Projekt bazodanowy\Basketball.xml";
            FileStream zapis = new FileStream(plik, FileMode.Create);
            DataContractSerializer serializer = new DataContractSerializer(typeof(List<Zespol>));
            serializer.WriteObject(zapis, dbModel.Zespol.ToList());
            zapis.Close();

            MessageBox.Show(null, "Zapisano", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        private void zapisXml_Click(object sender, EventArgs e)
        {
            zapisDoXml();
        }

        public bool sprawdzXml(out List<Zespol> tymczasowyZespol, string sciezkaPlik)
        {
            tymczasowyZespol = new List<Zespol>();
            try
            {
                FileStream odczyt = new FileStream(sciezkaPlik, FileMode.Open);
                XmlDictionaryReader reader = XmlDictionaryReader.CreateTextReader(odczyt, new XmlDictionaryReaderQuotas());
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<Zespol>));

                tymczasowyZespol = (List<Zespol>)serializer.ReadObject(reader, true);
                reader.Close();
                odczyt.Close();
            }
            catch(Exception e)
            {
                throw new ArgumentException("Parametr zespol_id nie moze byc pusty");
            }

            return true;
        }

        public bool odczytXml()
        {
            List<Zespol> tymczasowyZespol;
            string sciezkaPlik = @"C:\Users\sniad\Desktop\STUDIA\2 ROK\Pracownia programowania\Projekt bazodanowy\Basketball.xml";
            sprawdzXml(out tymczasowyZespol, sciezkaPlik);

            foreach (Zespol z in tymczasowyZespol)
                dbModel.Zespol.Add(z);
            
            dbModel.SaveChanges();

            MessageBox.Show(null, "Odczytano", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);

            return true;
        }

        private void odczytZXml_Click(object sender, EventArgs e)
        {
            odczytXml();
        }
    }
}
