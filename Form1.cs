using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace dicApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Hashtable hashtable = new Hashtable();

            hashtable.Add("pen", "কলম");
            hashtable.Add("book", "বই");

            string word = wordTextBox.Text.ToLower();

             foreach(string key in hashtable.Keys){
                 if(word.Equals(key)){
                    meanTextBox.Text = hashtable[key].ToString();
                     break;
                    }
                 else{
                    meanTextBox.Text = "Unknown";
                 }
             };
        }

       
    }
}
