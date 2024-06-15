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
    internal partial class Y : Form
    {
        internal Y(YType start)
        {
            InitializeComponent();
            switch (start)
            {
                case YType.always:
                    alwaysVowel.Checked = true;
                    break;
                case YType.never:
                    neverVowel.Checked = true;
                    break;
                case YType.sometimes:
                    sometimesVowel.Checked = true;
                    break;
            }
        }
        new public YType ShowDialog()
        {
            base.ShowDialog();
            if (alwaysVowel.Checked)
            {
                return YType.always;
            }
            if (neverVowel.Checked)
            {
                return YType.never;
            }
            return YType.sometimes;
        }
        void exit(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
