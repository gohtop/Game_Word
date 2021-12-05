using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        static string[] words;
        static string current_word;
        static string show_text;
        static int lives;
        static PictureBox[] lives_image;

        public Form2()
        {
            InitializeComponent();
            words = new string[] { " новый год ", " дед мороз ", " елка " };
            lives_image = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            current_word = "";
            show_text = "";
            lives = lives_image.Length;
        }

        void start_game(TextBox wordArea)
        {
            Random random = new Random();
            int number = random.Next(0, words.Length);
            current_word = words [number];
            show_text = get_show_text(current_word);
            wordArea.Text = show_text;
            lives = lives_image.Length;
        }

        void start_game(TextBox wordArea, PictureBox[] lives_image)
        {
            start_game(wordArea);
            Image image = Properties.Resources.pic;
            for (int i = 0; i < lives_image.Length; i++) 
            {
                lives_image[i].Image = image;
            }
        }

        string get_show_text(string word)
        {

        }

        bool is_contains(string word, char sumbol)
        {

        }

        string get_new_show_text(string word, char sumbol, string old_show_text)
        {

        }

        void button_sumbol_click(TextBox wordArea, char sumbol, Button cur_butten, Button startButton)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}