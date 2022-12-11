using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Verzeri
{
    public partial class Form1 : Form
    {
        private Visualizzatore visualizzatore;
        int id = 1;
        Verifica verifica;
        public Form1()
        {
            InitializeComponent();
            visualizzatore = new Visualizzatore();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        Verifica v;
        private void button1_Click(object sender, EventArgs e)
        {
             v = new Verifica(id, textBox2.Text, float.Parse(textBox3.Text), textBox4.Text);
            visualizzatore.Aggiungi(v);
            MessageBox.Show("elemento aggiunto correttamente");
            id++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=(visualizzatore.Visualizza());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            v.modifica(int.Parse(textBox6.Text));
            MessageBox.Show("elemento modificato correttamente");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float f = visualizzatore.Media(textBox1.Text);
            MessageBox.Show(""+f);
        }
    }
}
