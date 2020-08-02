using AoE_DataMonitor.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Diagnostics;

namespace AoE_DataMonitor
{
    public partial class Form1 : Form
    {
        public List<RecordModel> RecordList = new List<RecordModel>(); // Tüm kayıtlar oluşturduğumuz class yapısında bir listede tutulacaktır.
        public List<string> PlayerList = new List<string>(); // Dosyadan tespit edilen oyuncuların isimlerinin listede tutulması.
        string fileName = "aoeData.txt", bestPlayer = "";// >kaydedilecek dosya ismi, >Score olarak en yüksek player
        int line = 0, speed = 1; // >veri yazdırırken atlanacak veri bloğu sayısı(player sayısı), >yazdırma hızı
        Stopwatch watch = new Stopwatch();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            #region Download status of the file
            try
            {
                RecordList = ReadFile();
            }
            catch (WebException Ex)
            {
                MessageBox.Show("Web Error." + Environment.NewLine + Ex.ToString());
            }
            #endregion


            #region File saving status
            if (File.Exists(fileName))
            {
                lblStatus.Text = "File Saved";
            }
            else
            {
                lblStatus.Text = "File not Saved";
            }
            #endregion

            #region Defining players and creating lines for each player for all graphics
            string firstPlayer = RecordList[0].Player; // İlk oyuncu isminin alınması
            int compResult = 1, playerCount = 0; // İsim karşılaştırma sonucu ve oyuncu sayısı
            while (compResult != 0) // İlk oyuncu ismi, sırası ile (aynı isimler denk gelene kadar) diğer isimler ile karşılaştırıyor ve oyuncu sayısı bulunuyor.
            {
                playerCount++;
                compResult = string.Compare(firstPlayer, RecordList[playerCount].Player); // İsim karşılaştırma
            }

            var userList = new List<KeyValuePair<int, string>>(); // Listbox için oyuncu isimleri ve id lerini tutan iki boyutlu bir liste tanımı.

            for (int i = 0; i < playerCount; i++)
            {
                PlayerList.Add(RecordList[i].Player); // Oyuncuların listesi
                userList.Add(new KeyValuePair<int, string>(i, RecordList[i].Player)); // Listbox için id lere sahip oyuncu listesi.
                // 7 adet veri grafiğine her oyuncu için grafik cizgisi tanımlanması ve grafik çeşidi belirlenmesi.
                chrtWood.Series.Add(PlayerList[i]);
                chrtWood.Series[PlayerList[i]].ChartType = SeriesChartType.Line;
                chrtFood.Series.Add(PlayerList[i]);
                chrtFood.Series[PlayerList[i]].ChartType = SeriesChartType.Line;
                chrtGold.Series.Add(PlayerList[i]);
                chrtGold.Series[PlayerList[i]].ChartType = SeriesChartType.Line;
                chrtStone.Series.Add(PlayerList[i]);
                chrtStone.Series[PlayerList[i]].ChartType = SeriesChartType.Line;
                chrtVils.Series.Add(PlayerList[i]);
                chrtVils.Series[PlayerList[i]].ChartType = SeriesChartType.Line;
                chrtMils.Series.Add(PlayerList[i]);
                chrtMils.Series[PlayerList[i]].ChartType = SeriesChartType.Line;
                chrtScore.Series.Add(PlayerList[i]);
                chrtScore.Series[PlayerList[i]].ChartType = SeriesChartType.Line;
            }
            #endregion


            #region Adding the players to the listbox and all players selected in the opening.
            userListBox.DataSource = new BindingSource(userList, null);
            userListBox.ValueMember = "Key";
            userListBox.DisplayMember = "Value";
            for (int i = 0; i < userList.Count; i++)
            {
                userListBox.SetSelected(i, true);
            }
            #endregion
        }

        public List<RecordModel> ReadFile()
        {
            WebClient client = new WebClient();
            client.DownloadFile("http://operations.sparsetechnology.com/public/users/yca/aotstats.txt", fileName); // Dosyanın indirilmesi ve kaydedilmesi.

            List<RecordModel> list = new List<RecordModel>(); // Oluşturduğumuz class içerisindeki model çerçevesinde yeni bir liste oluşturulur.
            var lines = File.ReadAllLines(fileName).ToList(); // Dosyadaki tüm satırları okuyup string listesine aktarır.
            // Listedeki her satır virgüller ile bölünür, dönen array kaydedilir(values), array deki değerler oluşturduğumuz class içerisindeki değişkenlere set edilir.
            for (int i = 1; i < lines.Count; i++)
            {
                string[] values = lines[i].Split(',');
                RecordModel model = new RecordModel();
                model.Time = values[0];
                model.Player = values[1];
                model.Wood = values[2];
                model.Food = values[3];
                model.Gold = values[4];
                model.Stone = values[5];
                model.Vils = values[6];
                model.Mils = values[7];
                list.Add(model); // Tüm modellenmiş kayıtlar bir listeye kaydedilir.
            }
            return list;
        }

        private void selectPlayerButton_click(object sender, EventArgs e)
        {
            // Listbox dan seçilen oyuncuların grafiklerde aktif, seçilmeyenlerin ise pasif hale getirilmesi
            foreach (var plyr in PlayerList)
            {
                chrtWood.Series[plyr].Enabled = false;
                chrtFood.Series[plyr].Enabled = false;
                chrtGold.Series[plyr].Enabled = false;
                chrtStone.Series[plyr].Enabled = false;
                chrtVils.Series[plyr].Enabled = false;
                chrtMils.Series[plyr].Enabled = false;
                chrtScore.Series[plyr].Enabled = false;
            }
            foreach (Object obj in userListBox.SelectedIndices)
            {
                chrtWood.Series[PlayerList[Int32.Parse(obj.ToString())]].Enabled = true;
                chrtFood.Series[PlayerList[Int32.Parse(obj.ToString())]].Enabled = true;
                chrtGold.Series[PlayerList[Int32.Parse(obj.ToString())]].Enabled = true;
                chrtStone.Series[PlayerList[Int32.Parse(obj.ToString())]].Enabled = true;
                chrtVils.Series[PlayerList[Int32.Parse(obj.ToString())]].Enabled = true;
                chrtMils.Series[PlayerList[Int32.Parse(obj.ToString())]].Enabled = true;
                chrtScore.Series[PlayerList[Int32.Parse(obj.ToString())]].Enabled = true;
            }

            #region Play Speed
            if (radio1x.Checked == true)
            {
                speed = 1;
            }
            else if (radio2x.Checked == true)
            {
                speed = 2;
            }
            else if (radio4x.Checked == true)
            {
                speed = 4;
            }
            else if (radio16x.Checked == true)
            {
                speed = 16;
            }
            #endregion
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            // Verilerin yazdırılmaya başlaması.
            timer1.Start();
            playButton.Enabled = false;
            pauseButton.Enabled = true;
        }
      
        private void pauseButton_Click(object sender, EventArgs e)
        {
            // Verilerin yazdırma işleminin durdurulması.
            timer1.Stop();
            playButton.Enabled = true;
            pauseButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // Grafiklere verilerin timer da belirtilen milisaniye aralıklarında yazdırılması.
            double firstScore = 0.0; //İlk score un tutulması

            for (int j = 0; j < PlayerList.Count; j++) // Tüm grafiklere her bir oyuncu tek tek yazdırılır. 
            {
                // Veri sonuna geldiğinde yazdırma durdurulur ve ekrana durum yazdırılır.
                if (RecordList.Count < line + 1)
                {
                    timer1.Stop();
                    playButton.Enabled = true;
                    pauseButton.Enabled = false;
                    lblStatus.Text = "End of file, Reading finished";
                    break;
                }
                chrtWood.Series[RecordList[j].Player].Points.AddXY(Int32.Parse(RecordList[line + j].Time), Int32.Parse(RecordList[line + j].Wood));
                chrtFood.Series[RecordList[j].Player].Points.AddXY(Int32.Parse(RecordList[line + j].Time), Int32.Parse(RecordList[line + j].Food));
                chrtGold.Series[RecordList[j].Player].Points.AddXY(Int32.Parse(RecordList[line + j].Time), Int32.Parse(RecordList[line + j].Gold));
                chrtStone.Series[RecordList[j].Player].Points.AddXY(Int32.Parse(RecordList[line + j].Time), Int32.Parse(RecordList[line + j].Stone));
                chrtVils.Series[RecordList[j].Player].Points.AddXY(Int32.Parse(RecordList[line + j].Time), Int32.Parse(RecordList[line + j].Vils));
                chrtMils.Series[RecordList[j].Player].Points.AddXY(Int32.Parse(RecordList[line + j].Time), Int32.Parse(RecordList[line + j].Mils));

                double score = (Double.Parse(RecordList[line + j].Mils) * 75.0 * 0.2) + (Double.Parse(RecordList[line + j].Vils) * 50.0 * 0.2) + ((Double.Parse(RecordList[line + j].Wood) + Double.Parse(RecordList[line + j].Food) + Double.Parse(RecordList[line + j].Gold) + Double.Parse(RecordList[line + j].Stone)) * 0.2);
                chrtScore.Series[RecordList[j].Player].Points.AddXY(Int32.Parse(RecordList[line + j].Time), score); // Score un hesaplanması ve yazdırılması.

                lblSecond.Text = "| " + RecordList[line].Time.ToString() + " miliSecond Best Player |";

                #region The player with the best score for every millisecond
                if (firstScore < score)
                {
                    bestPlayer = RecordList[j].Player;
                    firstScore = score;
                }
                #endregion
            }

            lblFirstPlayer.Text = bestPlayer; // Her milisaniye deki en yüksek skora sahip oyuncunun yazdırılması
            line += (PlayerList.Count * speed); // Veri yazdırma hızı veriler arası istenen hız kadar atlanak sağlanmaktadır.  
        }
    }
}
