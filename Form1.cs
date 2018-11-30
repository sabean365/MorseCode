using System;
using System.Windows.Forms;

namespace MorseCode
{


    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Method to convert string input to Morse Code.
        public void ConvertLetter(string txt)
        {
            //Declare character array
            char[] ch = { ' ', ',', '.', '?', '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B',
            'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };

            //Declare morse code array
            string[] morse = { " ", "--..--", ".-.-.-", "..--..", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...",
                "---..", "----.", ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---",
                ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.."};

            //Initialize variables
            string textToConvert = txt;
            string morseText = "";

            //Iterate through string input
            for (int i = 0; i < textToConvert.Length; i++)
            {
                //Iterate through morse code array
                for (int j = 0; j < 40; j++)
                {
                    //If statement to compare string character to character array
                    if (textToConvert[i] == ch[j])
                    {
                        //Add Morse Code to text with a space to separate code (3 spaces will separate word)
                        morseText += (morse[j] + " ");
                   
                    }
                }
                //Display morse code
                morseCodeConvertedLabel.Text = morseText;
            } 
           
        }

        //Code for button click
        private void convertButton_Click(object sender, EventArgs e)
        {
            //Get user input
            string textToConvert = stringTextBox.Text.ToUpper();

            //Call ConvertLetter method, passing in the user input
            ConvertLetter(textToConvert);
            
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the form
            this.Close();
        }
    }
}
