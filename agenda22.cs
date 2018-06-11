/// <summary></summary>
using System;
using System.IO;
using System.Windows.Forms;

namespace sIrc
{
    public partial class agenda22 : Form
    {
        private System.Speech.Synthesis.SpeechSynthesizer kn = new System.Speech.Synthesis.SpeechSynthesizer();
        private int hj;

        public agenda22()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var kg = DateTime.Now;

            label2.Text = kg.ToString("dd.MM");
            label1.Text = kg.ToString("HH.mm");

            if (comboBox1.Items.Contains(label2.Text + label1.Text))
            {
                if (File.Exists(label2.Text + label1.Text + ".txt"))
                {
                    hj++;
                    var fty = File.ReadAllText(label2.Text + label1.Text + ".txt");
                    if (hj <= 1)
                    {
                        kn.SpeakAsync("alarm alarm un alarm a été detecter regarde le rappel important inscrit dans lagenda alarm alarm alarm alarm alarm un alarm a été detecter regarde le rappel important inscrit dans lagenda alarm alarm alarm");

                        MessageBox.Show("RAPPEL  .il est " + label1.Text + " et " + fty);
                    }
                }
            }
        }

        private void agenda22_Load(object sender, EventArgs e)
        {
            panel1.BringToFront();
            if (File.Exists("agend.txt"))
            {
                string[] gfd = File.ReadAllLines("agend.txt");

                foreach (string fb in gfd)
                    comboBox1.Items.Add(fb.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox1.Text + textBox2.Text);
            File.WriteAllText(textBox1.Text + textBox2.Text + ".txt", richTextBox1.Text);
            if (File.Exists("agend.txt"))
            {
                File.AppendAllText("agend.txt", textBox1.Text + textBox2.Text + Environment.NewLine);
            }
            else
            {
                File.WriteAllText("agend.txt", textBox1.Text + textBox2.Text + Environment.NewLine);
            }

            MessageBox.Show("added");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "disable1")
            {
                panel1.Visible = false;
            }
            else
            {
                MessageBox.Show("pass desactive");
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            File.Delete("agend.txt");
            MessageBox.Show("deleted");
        }

        private void button4_Click(object sender, EventArgs e) => hj = 0;

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}// --------------------------------------------------------------------------------

/// <summary>
///
/// </summary>
// --------------------------------------------------------------------------------
