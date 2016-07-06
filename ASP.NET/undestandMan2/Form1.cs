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

namespace understandHangman
{
    public partial class Form1 : Form
    {
        int guessNumber = 1; //Ökar med 1 för varje felgissing så att nästa bild visas.

        char guess; 	//char innehåller ETT tecken och här lagras den bokstav som du gissar på.

        string rightAnswer = null; //Här lagras rätt ord. Här försvinner bokstäver när du gissar rätt.	

        string rightAnswer2 = null; //Här lagras också rätt ord men denna här försvinner inte bokstäver. Denna 
                                    //variabel används när vi gissar på hela ordet
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGissa_Click(object sender, EventArgs e)
        {
             guess = char.Parse(txtGuess.Text);
            //---  if guess innehåller >1 tecken

            /*'if(guess.le>1)
                {
                MessageBox.Show("Du bör ange bara en bokstav", "Fel!", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }*/
            //

            //Här gör man sin gissning med en bokstav.
            txtGuess.Clear();

            //För varje gissning som är fel så blir man mer hängd. 
            //guessNumber ökar med ett för varje felgissning så   att rätt bild laddas.

            if (!rightAnswer.Contains(guess) && guessNumber == 1)
                try { pictureBox1.Load("fel1.gif"); }
                catch (ArgumentNullException){ }
            if (!rightAnswer.Contains(guess) && guessNumber == 2)
                pictureBox1.Load("fel2.gif");
            if (!rightAnswer.Contains(guess) && guessNumber == 3)
                pictureBox1.Load("fel3.gif");
            if (!rightAnswer.Contains(guess) && guessNumber == 4)
                pictureBox1.Load("fel4.gif");

            if (!rightAnswer.Contains(guess) && guessNumber == 5)  //Efter 5 gissningar så är man hängd              
            {
                pictureBox1.Load("fel5.gif");
                btnGissa.Enabled = false;
                lblSlutResultat.Text = "Sorry, du är hängd! Rätt svar var " + rightAnswer2;
            }


            if (!rightAnswer.Contains(guess)) //Om gissningen INTE är rätt ökas guessNumber för nästa bild.               
                guessNumber++;


            else if (rightAnswer.Contains(guess)) //Om gissningen ÄR rätt så minskas bokstäver att gissa på.
            {
                //Om ordet innehåller mer än en bokstav av samma sort, ser denna till att alla visas. 
                while (rightAnswer.IndexOf(guess) != -1)
                {

                    lblShowLetters.Text += guess.ToString();

                    int index = rightAnswer.IndexOf(guess); //Tar reda på indexet för bokstaven du gissade på

                    if (index != -1) //Om det inte är tomt på bokstäver
                    {

                        if (rightAnswer.Length == 1)
                            btnGissa.Enabled = false;

                        rightAnswer = rightAnswer.Remove(index, 1); //"Index" är numret för bokstaven, "1" är hur 
                    }               //många bokstäver som ska tas bort                       
                    else
                        btnGissa.Enabled = false;

                }//End of while
                 //Det rätta svaret lägg i en variabel för att minska för varje rätt bokstav.

                rightAnswer = txtTheWord.Text;

                //Rätt svar läggs även i en variabel som INTE minskar. Denna variabel visas om man gissar rätt ord.

                rightAnswer2 = txtTheWord.Text;

                txtTheWord.Clear();
            }
        }

        private void btnGissaHelaOrdet_Click(object sender, EventArgs e)
        {
            if (txtGuessTheWord.Text.Equals(rightAnswer2))
                lblSlutResultat.Text = "Du gissade rätt ord: " + rightAnswer2;
            else
            {
                pictureBox1.Load("fel5.gif");
                btnGissa.Enabled = false;
                lblSlutResultat.Text = "Sorry, du är hängd! Rätt svar var " + rightAnswer2;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnNyttOrd_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == false & radioButton2.Checked == false)
            {
                MessageBox.Show("Var snäll och välja ett språk", "Välj språk", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

            //Det rätta svaret lägg i en variabel för att minska för varje rätt bokstav.

            //rightAnswer = txtTheWord.Text;

            //Rätt svar läggs även i en variabel som INTE minskar. Denna variabel visas om man gissar rätt ord.

            //rightAnswer2 = txtTheWord.Text;
            // txtTheWord.Clear();---//
            // ny kod för att geninera ett ord
            else
            {
                if (radioButton1.Checked)
                { rightAnswer = returnWordSwedish(); }
                //-Anropar metoden som returnerar ett slumpvalt ord.
                else { rightAnswer = returnWordRussian(); }
                rightAnswer2 = rightAnswer; //-Sätter rightAnswer2 till samma som rightAnswer.

                //Vi går till metoden returnWordSwedish som returnerar ett slumpmässigt valt ord.Samma ord läggs i rightAnswer2.
                txtTheWord.Text = rightAnswer;
            }//end else
          }

        private void nySpel_Click(object sender, EventArgs e)
        {
            lblSlutResultat.Text = "";
            lblShowLetters.Text = "";
            txtGuessTheWord.Clear();
            txtTheWord.Clear();
            //pictureBox1.Image = null;
            Graphics g = pictureBox1.CreateGraphics();
            g.Clear(Color.White);
            //g.DrawImage();
            pictureBox1.Load("Galge.gif");
        }

        private void btnGo_Click(object sender, EventArgs e)
       {   // --http://csharphelper.com/blog/2014/09/generate-random-strings-in-c/
           /* stWords.Items.Clear();

            // Get the number of words and letters per word.
           // int num_letters = int.Parse(txtNumLetters.Text);
           // int num_words = int.Parse(txtNumWords.Text);

            // Make an array of the letters we will use.
            char[] letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();

            // Make a random number generator.
            Random rand = new Random();

            // Make the words.
           // for (int i = 1; i <= num_words; i++)
           /* {
                // Make a word.
                string word = "";
                for (int j = 1; j <= num_letters; j++)
                {
                    // Pick a random number between 0 and 25
                    // to select a letter from the letters array.
                    int letter_num = rand.Next(0, letters.Length - 1);

                    // Append the letter.
                    word += letters[letter_num];
                }

                // Add the word to the list.
                lstWords.Items.Add(word);
            }*/
        }

        string returnWordSwedish()
        {
            Random rnd1 = new Random();
            string[] allLines = File.ReadAllLines("C:/Users/elev10/mittproject/ASP.NET/undestandMan2/Bibliotek/svenska.txt");
            string rightWord = allLines[rnd1.Next(allLines.Length)];
            return rightWord;
        }
        string returnWordRussian()
        {
            Random rnd1 = new Random();
            string[] allLines = File.ReadAllLines("C:/Users/elev10/mittproject/ASP.NET/undestandMan2/Bibliotek/ryska.txt");
            string rightWord = allLines[rnd1.Next(allLines.Length)];
            return rightWord;
        }

        private void txtTheWord_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
