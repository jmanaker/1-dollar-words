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
            float sum = 0;
            bool persist = true;
            foreach(char character in wordBox.Text.ToLower())
            {
                try
                {
                    checked
                    {
                        //in case Ys are only vowels when not at the beginning of a word
                        if (character != 'y' || neg == YType.always || !persist)
                        {
                            sum += letters[character];
                        }
                        else
                        {
                            sum -= letters[character];
                        }
                    }
                    persist = char.IsWhiteSpace(character);
                }
                catch (NullReferenceException)
                {
                    //Do nothing...
                }
                catch (OverflowException)
                {
                    MessageBox.Show("Error: too large a value.  ", "Warning");
                }
            }
            value.Text = "Your word or phrase has a value of $" + (sum / 100).ToString() + ".  ";
        }
        private void showCharacters(object sender, EventArgs e)
        {
            letters = new Character(letters).ShowDialog();
        }

        private void askVowels(object sender, EventArgs e)
        {
            ySettings.Enabled = 
                (MessageBox.Show("Do you want vowels to be negative (default)?", "Vowels?", MessageBoxButtons.YesNo) == DialogResult.No);
            if (ySettings.Enabled)
            {
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
            else
            {
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
