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
            words = new string[] { " НОВЫЙ ГОД ", " ДЕД МОРОЗ ", " ЕЛКА ", " КАРНАВАЛ ", " ЕЛОЧНАЯ ИГРУШКА "," РОЖДЕСТВО " , " ПОДАРОК "};
            lives_image = new PictureBox[] { pictureBox2, pictureBox3, pictureBox4, pictureBox5, pictureBox6, pictureBox7 };
            current_word = "";
            show_text = "";
            lives = lives_image.Length;

            start_game(textBox1, lives_image);
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
            string result = "";
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] != ' ')
                {
                    result += '*';
                }
                else
                {
                    result += ' ';
                }
            }
            return result;
        }

        bool is_contains (string word, char sumbol)
        {
            for (int i = 0; i < word.Length; i++) 
            {
                if (word[i] == sumbol) 
                {
                    return true;
                }
            } 
                return false;
        }

        string get_new_show_text (string word, char sumbol, string old_show_text)
        {
            string new_show_text = "";
            for(int i = 0; i < word.Length; i++)
            {
                if (word[i] == sumbol)
                {
                    new_show_text += sumbol;
                }
                else
                {
                    new_show_text += old_show_text[i];
                }
            }
            return new_show_text ;
        }

        void button_sumbol_click(TextBox wordArea, char sumbol, Button cur_button, Button startButton)
        {
            bool is_contain = is_contains(current_word, sumbol);
            if (is_contain)
            {
                show_text = get_new_show_text(current_word, sumbol, show_text);
                wordArea.Text = show_text;
            }
            else
            {
                lives--;
                lives_image[lives].Image = null;
            }
            if (lives == 0)
            {
                using (LoseField loseField = new LoseField())
                {
                    loseField.ShowDialog();
                }
                startButton.PerformClick();
            }
            else if(!is_contains(show_text , '*'))
            {
                using (WinField win = new WinField())
                {
                    win.ShowDialog();
                }
            }
            cur_button.Enabled = false; 
            

          

        }
        private void button3_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Д', button3, startgame);
        }

        private void button26_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'П', button17, startgame);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'В', button14, startgame);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Х', button6, startgame);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'О', button10, startgame);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'С', button5, startgame);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'А', button2, startgame);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Б', button13, startgame);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Г', button25, startgame);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Е', button12, startgame);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Ж', button15, startgame);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'З', button24, startgame);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'И', button4, startgame);
        }

        private void button34_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Й', button34, startgame);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'К', button11, startgame);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Л', button16, startgame);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'М', button23, startgame);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Н', button1, startgame);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Р', button22, startgame);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Т', button9, startgame);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'У', button18, startgame);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Ф', button21, startgame);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Ц', button8, startgame);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Ч', button19, startgame);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Ш', button20, startgame);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Щ', button7, startgame);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Ъ', button28, startgame);
        }

        private void button29_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Ы', button29, startgame);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Ь', button30, startgame);
        }

        private void button31_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Э', button31, startgame);
        }

        private void button32_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Ю', button32, startgame);
        }

        private void button33_Click(object sender, EventArgs e)
        {
            button_sumbol_click(textBox1, 'Я', button33, startgame);
        }
    }
}