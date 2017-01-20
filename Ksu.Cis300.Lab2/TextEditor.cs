/*Ksu.Cis300.Lab2.cs
 * Author: Harris Schrick
 */
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ksu.Cis300.Lab2
{
    ///Text Editor form and components
    public partial class TextEditor : Form
    {
        public TextEditor()
        {
            InitializeComponent();
        }

        //opens file selection from computer.
        private void uxOpen_Click(object sender, EventArgs e)
        {
            if (OpenFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Can't open file " + OpenFile.FileName);
            }
        }

        //saves and or overwrites file to one that already exists.
        private void uxSaveAs_Click(object sender, EventArgs e)
        {
            if (SaveFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Can't write to file " + SaveFile.FileName);
            }
        }
        
    }
}
