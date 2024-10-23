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


namespace JSA
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
        private void buttonReadJson_Click(object sender, EventArgs e)
        {
            // Pad naar het JSON bestand
            string jsonFilePath = @"C:\path\to\your\file\data.json";

            // Controleer of het bestand bestaat
            if (File.Exists(jsonFilePath))
            {
                try
                {
                    // Lees de inhoud van het JSON-bestand
                    string jsonData = File.ReadAllText(jsonFilePath);

                    // Deserializeer de JSON naar een C# object
                    Person person = JsonSerializer.Deserialize<Person>(jsonData);

                    // Toon de gegevens in de TextBox
                    textBoxOutput.Text = $"Name: {person.Name}\r\nAge: {person.Age}\r\nEmail: {person.Email}";
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Fout bij het lezen van JSON: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("JSON-bestand niet gevonden.");
            }
        }
    }
}
