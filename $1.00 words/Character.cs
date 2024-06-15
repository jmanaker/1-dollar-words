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
    internal partial class Character : Form
    {
        SortedList<char, int> letters;
        internal Character(SortedList<char, int> characters)
        {
            InitializeComponent();
            letters = characters;
            idRemove.Items.Clear();
            idRemove.Items.AddRange(letters.Keys.Cast<object>().ToArray<object>());
            value.SelectAll();
            idRemove.SelectedIndex = 0;
        }

        new public SortedList<char, int> ShowDialog()
        {
            base.ShowDialog();
            return letters;
        }
        private void destroy(object sender, EventArgs e)
        {
            letters.Remove((char)idRemove.SelectedItem);
            idRemove.Items.Remove(idRemove.SelectedItem);
        }

        private void create(object sender, EventArgs e)
        {
            try
            {
                if (idAdd.Text.Length != 1)
                {
                    throw new InvalidOperationException();
                }
                else
                {
                    letters.Add(idAdd.Text[0], int.Parse(value.Text));
                    idRemove.Items.Add(idAdd.Text[0]);
                }
            }
            catch (FormatException error)
            {
                MessageBox.Show("Error: the value is not an integer.  ", "Typo");
            }
            catch (InvalidOperationException error)
            {
                MessageBox.Show("Error: the \"character\" is not just one character.  ", "Typo");
            }
        }
        private void charmap(object sender, LinkLabelLinkClickedEventArgs e)
        {
            showSpecial.LinkVisited = true;
            try
            {
                System.Diagnostics.Process.Start("%SystemRoot%System32\\charmap.exe");
            }
            catch
            {
                MessageBox.Show("Error: You do not have sufficient privileges to open charmap.", "Priv" +
                    "ileges error.");
            }
        }

        private void exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
