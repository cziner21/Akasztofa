using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace aksztofa
{


    public partial class HangMan : Form
    {
        //beírt karakter
        public string guessChar = "";
        //Dinamikus címkék
        public List<Label> labels = new List<Label>();
        //választott szó (choosenWord, csak már sok volt a choose, és a kavarodás elkerülése miatt rövidítettem)
        public string cWord;
        //rossz betűk tárolására
        public List<string> wrongLetters = new List<string>();
        //ebbe tárolom a már kitalált betűket
        public List<string> tmp = new List<string>();
        
        /// <summary>
        /// Konstruktor, kezdő felület beállítása
        /// </summary>
        public HangMan() {
            InitializeComponent();
            guessLabel.Visible = false;
            guessLetter.Visible = false;
            sendBtn.Visible = false;
            categoryBox.SelectedIndex = -1;

            categoryBox.Items.Add("Állat");
            categoryBox.Items.Add("Növény");
            categoryBox.Items.Add("Keresztnév");
            categoryBox.Items.Add("Tárgy");
        }

        /// <summary>
        /// miután kiválasztottuk a megfelelő kategóriát(ha nem választunk, a 0-át választja)
        /// kialakítja a felületet és meghívja a Read függvényt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selectBtn_Click(object sender, EventArgs e) {

            //felesleges gombok, comboboxok, labelek eltüntetése
            chooseCateory.Visible = false;
            selectBtn.Visible = false;
            categoryBox.Visible = false;

            int index;
            if (categoryBox.SelectedIndex >= 0 && categoryBox.SelectedIndex <= 3)
                index = categoryBox.SelectedIndex;
            else
                index = 0;
            //kiválasztott kategórából való beolvasás
            Read(index);

            //új elemek megjelenítése
            guessLabel.Visible = true;
            guessLetter.Visible = true;
            sendBtn.Visible = true;
            guessLabel.Location = new Point(10, 100);
            guessLetter.Location = new Point(101, 94);
            sendBtn.Location = new Point(160, 93);
        }

        /// <summary>
        /// a kategóriának megfelelő text fileból beolvas mindent, randomra választ egy szót, majd meghívj rá
        /// a címkegeneráló függvényt
        /// </summary>
        /// <param name="category"></param>
        public void Read(int category) {
            string[] text;
            Random rnd = new Random();

            if (category == 0) {
                text = System.IO.File.ReadAllLines(@"D:/Work/Programok/bevgraf/allat.txt");
                int lines = text.Length;
                int chosen = rnd.Next(0, lines);
                char[] letters = text[chosen].ToUpper().ToCharArray();
                cWord = text[chosen];
                //Dinamikusan annyi címkét generál, ammenyi betű van a szóban               
                generateLabels(letters);              
            }           
            if (category == 1) {
                text = System.IO.File.ReadAllLines(@"D:/Work/Programok/bevgraf/noveny.txt");
                int lines = text.Length;
                int chosen = rnd.Next(0, lines);
                char[] letters = text[chosen].ToUpper().ToCharArray();
                cWord = text[chosen];
                //Dinamikusan annyi címkét generál, ammenyi betű van a szóban               
                generateLabels(letters);
            }
            if (category == 2) {
                text = System.IO.File.ReadAllLines(@"D:/Work/Programok/bevgraf/keresztnev.txt");
                int lines = text.Length;
                int chosen = rnd.Next(0, lines);
                char[] letters = text[chosen].ToUpper().ToCharArray();
                cWord = text[chosen];
                //Dinamikusan annyi címkét generál, ammenyi betű van a szóban               
                generateLabels(letters);
            }
            if (category == 3) {
                text = System.IO.File.ReadAllLines(@"D:/Work/Programok/bevgraf/targy.txt");
                int lines = text.Length;
                int chosen = rnd.Next(0, lines);
                char[] letters = text[chosen].ToUpper().ToCharArray();
                cWord = text[chosen];
                //Dinamikusan annyi címkét generál, ammenyi betű van a szóban               
                generateLabels(letters);
            }
            
        }

        /// <summary>
        /// Ha jó betűt írunk, akkor kicseréli a "_" jeleket a megfelelő betűkre
        /// ha rosszat, hozzáadogatja  a wrognLetters listához a rosszakat
        /// </summary>
        /// <param name="labels"></param>
        /// <param name="chosedWord"></param>
        /// <param name="gc"></param>
        public void controlGame(List<Label> labels, string chosedWord, string gc) {
                
                if (chosedWord.Contains(gc)) {
                    
                    for (int j = 0; j < chosedWord.Length; j++) {
                        if (chosedWord[j] == gc[0]) {
                            labels[j].ForeColor = Color.Green;
                            labels[j].Font = new Font(labels[j].Font, FontStyle.Bold);
                            labels[j].Text = gc.ToString();
                            tmp.Add(gc);
                        }                        
                    }                    
                }
                else{
                    if (!wrongLetters.Contains(gc))
                        wrongLetters.Add(gc);
                    else
                        MessageBox.Show("Ezt a betűt, már beírtad egyszer!","Duplikált betű!");
                }
                //ha a kitalált betűk hossza megegyezik
                //a kitalálandó szó hosszával, akkor nyertünk
                if (tmp.Count == chosedWord.Length) {
                    guessLetter.Enabled = false;
                    MessageBox.Show("Gratulálok, nyertél!","Nyertél!");
                }

        }

        /// <summary>
        /// Ez a metódus dinamikusan generál címkéket
        /// a paraméterként kapott szó hosszának megfelelő 
        /// darabszámmal
        /// </summary>
        /// <param name="letters">karakter tömb</param>
        public void generateLabels(char[] letters) {
            //20 pixel távra lesznek egymástól a címkék
            int distance = 120;
            for (int i = 0; i < letters.Length; i++) {
                Label newLabel = new Label();
                //Label NewLabel = new Label();
                newLabel.Name = "chosenLetter" + i;
                newLabel.Text = "_";
                newLabel.Location = new Point(distance, 35);
                newLabel.Visible = true;
                labels.Add(newLabel);
                distance += 20;
            }

            foreach (Label l in labels) {
                this.Controls.Add(l);
                l.BringToFront();
            }                
        }

        /// <summary>
        /// Bezárja a formot
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void quit_Click(object sender, EventArgs e) {
            this.Close();
        }

        /// <summary>
        /// Új játék indítása
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newGame_Click(object sender, EventArgs e) {

            //takarítás
            this.Controls.Clear();
            this.labels.Clear();
            this.wrongLetters.Clear();
            this.tmp.Clear();
            this.InitializeComponent();

            guessLabel.Visible = false;
            guessLetter.Visible = false;
            sendBtn.Visible = false;
            categoryBox.SelectedIndex = -1;

            categoryBox.Items.Add("Állat");
            categoryBox.Items.Add("Növény");
            categoryBox.Items.Add("Keresztnév");
            categoryBox.Items.Add("Tárgy");            
        }

        /// <summary>
        /// Ellenőrzés után meghívja a controlGame függvényt
        /// ha rossz betűt írunk, akkor elkezdi rajzolni a fát
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendBtn_Click(object sender, EventArgs e) {
            string chosedWord = cWord.ToUpper();
            
            guessChar = guessLetter.Text.ToUpper();
            if (Regex.IsMatch(guessChar, "^[A-Za-záÁéÉíÍóÓöÖüÜőŐúÚűŰ]$"))
                controlGame(labels, chosedWord, guessChar);
            else
                MessageBox.Show("Csak betűket írhatsz be!");
            
            //rossz betűk megjelennek
            wrongLt.Visible = true;            
            int q = 0;
            for (int i = 0; i < wrongLetters.Count; i++) {
                Label wLabel = new Label();
                wLabel.Name = "wl" + i;
                wLabel.Text = wrongLetters[i];
                wLabel.ForeColor = Color.Red;
                wLabel.Location = new Point(324 + q, 120);
                this.Controls.Add(wLabel);
                wLabel.BringToFront();
                q += 20;
            }
            
            //akasztófa állásait kirajzolja
            if (wrongLetters.Count == 1)
                pictureBox1.Image = Properties.Resources.akasztofa01;
            else if (wrongLetters.Count == 2)
                pictureBox1.Image = Properties.Resources.akasztofa02;
            else if (wrongLetters.Count == 3)
                pictureBox1.Image = Properties.Resources.akasztofa03;
            else if (wrongLetters.Count == 4)
                pictureBox1.Image = Properties.Resources.akasztofa04;
            else if (wrongLetters.Count == 5)
                pictureBox1.Image = Properties.Resources.akasztofa05;
            else if (wrongLetters.Count == 6)
                pictureBox1.Image = Properties.Resources.akasztofa06;
            else if (wrongLetters.Count == 7)
                pictureBox1.Image = Properties.Resources.akasztofa07;
            else if (wrongLetters.Count == 8)
                pictureBox1.Image = Properties.Resources.akasztofa08;
            else if (wrongLetters.Count == 9)
                pictureBox1.Image = Properties.Resources.akasztofa09;
            else if (wrongLetters.Count == 10)
                pictureBox1.Image = Properties.Resources.akasztofa10;
            else if (wrongLetters.Count == 11) {
                pictureBox1.Image = Properties.Resources.akasztofa11;
                guessLetter.Enabled = false;
                MessageBox.Show("Meghaltál!\n"+
                                "-------------\n"+
                                "Ez volt a gonolt szó:\n\n"+
                                cWord.ToUpper(),"Game Over!");                
            }
            //minden beküldött betű után kipucolja az input mezőt
            guessLetter.Clear();
        }

        /// <summary>
        /// infó menüpont
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void infóToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show("Készítette: Cziner Ádám\n"+
                            "v1.0 verzió\n", "Akasztófa© v1.0");
        }

        /// <summary>
        /// help menü
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void helpToolStripMenuItem1_Click(object sender, EventArgs e) {
            MessageBox.Show("Akasztófa - Súgó\n" +
                            "------------------\n\n" +
                            "A játék elején választani kell egy kategóriát, amely alapján\n" +
                            "a gép véletlenszerűen választ egy szót, a kategóriának megfelelő txt fileból.\n" +
                            "Ezután megjelenik egy beviteli mező, amibe a magyar ábécé karaktereit beírva\n" +
                            "találgathatunk, hogy mi lehet a szó. Összesen 11-et hibázhatunk,\n" +
                            "ha ezt a határt túllépjük, vége a játéknak.", "Súgó");
        }

        
       
    }
}
