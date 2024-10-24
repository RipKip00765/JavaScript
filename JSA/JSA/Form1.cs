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
using System.Text.Json;
using Newtonsoft.Json;


namespace JSA
{
    public partial class Form1 : Form
    {
        public class Highscore
        {
            public string Score { get; set; }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReadJSON()
        {
            string FilePath = @"C:\Project\JS-Game\Score.json";

            string json = File.ReadAllText(FilePath);

            Highscore highscore = JsonConvert.DeserializeObject<Highscore>(json);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadJSON();
        }
    }
}
