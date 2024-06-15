using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _1._00_words
{
    public partial class WordForm : Form
    {
        SortedList<char, int> letters = new SortedList<char, int>();
        YType neg = YType.sometimes;
        public WordForm()
        {
            InitializeComponent();
            letters['a'] = -1;
            letters['b'] = 2;
            letters['c'] = 3;
            letters['d'] = 4;
            letters['e'] = -5;
            letters['f'] = 6;
            letters['g'] = 7;
            letters['h'] = 8;
            letters['i'] = -9;
            letters['j'] = 10;
            letters['k'] = 11;
            letters['l'] = 12;
            letters['m'] = 13;
            letters['n'] = 14;
            letters['o'] = -15;
            letters['p'] = 16;
            letters['q'] = 17;
            letters['r'] = 18;
            letters['s'] = 19;
            letters['t'] = 20;
            letters['u'] = -21;
            letters['v'] = 22;
            letters['w'] = 23;
            letters['x'] = 24;
            letters['y'] = -25;
            letters['z'] = 26;
        }
        public void calculate()
        {
            int sum = 0;
            string text = wordBox.Text.ToLower();
            for(int index = 0; index < text.Length; index++)
            {
                char character = text[index];
                try
                {
                    checked
                    {
                        if (character != 'y' || (neg != YType.sometimes || text[index - 1] != ' '))
                        //in case Ys are only vowels when not at the beginning of a word
                        {
                            sum += letters[character];
                        }
                        else
                        {
                            sum -= letters[character];
                        }
                    }
                }
                catch (IndexOutOfRangeException error)
                {
                    sum += (character != 'y' || neg != YType.sometimes ? 1 : -1) * letters[character];
                }
                catch (NullReferenceException error)
                {
                }
                catch (OverflowException error)
                {
                    MessageBox.Show("Error: too large a value.  ", "Warning");
                }
            }
            value.Text = "Your word or phrase has a value of $" + (((float)sum) / 100).ToString() + ".  "
                ;
        }
        private void showCharacters(object sender, EventArgs e)
        {
            letters = new Character(letters).ShowDialog();
        }

        private void askVowels(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Do you want vowels to be negative (default)?",
                "Vowels?", MessageBoxButtons.YesNo) == DialogResult.No))
            {
                ySettings.Enabled = false;
                if (letters['a'] > 0)
                {
                    letters['a'] *= -1;
                    letters['e'] *= -1;
                    letters['i'] *= -1;
                    letters['o'] *= -1;
                    letters['u'] *= -1;
                    letters['y'] *= -1;
                }
            }
            else
            {
                ySettings.Enabled = true;
                if (letters['a'] < 0)
                {
                    letters['a'] *= -1;
                    letters['e'] *= -1;
                    letters['i'] *= -1;
                    letters['o'] *= -1;
                    letters['u'] *= -1;
                    letters['y'] *= -1;
                }
            }
        }

        private void showAbout(object sender, EventArgs e)
        {
            new About().Show();
        }

        private void showY(object sender, EventArgs e)
        {
            neg = new Y(neg).ShowDialog();
        }

        private void CheckCalc(object sender, KeyPressEventArgs e)
        {
            if (wordBox.ContainsFocus && (e.KeyChar == '\r' || e.KeyChar == '\n'))
            {
                calculate();
                e.Handled = true;
            }
        }
    }
}
