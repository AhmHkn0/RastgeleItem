namespace RastgeleItem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox1.Text)) { 
                listBox1.Items.Insert(0, textBox1.Text);
                label1.Text = "\"" + textBox1.Text + "\" eklendi.";
                textBox1.Text = "";
            } else
            {
                label1.Text = "Bo� se�enek belirtemezsiniz.";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 0)
            {
                label1.Text = "\""+ listBox1.Items[0] + "\" ��kar�ld�.";
                listBox1.Items.RemoveAt(0);
            } else
            {
                label1.Text = "Liste zaten bo�.";
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 1)
            {
                var random = new Random();
                int index = random.Next(0, listBox1.Items.Count);

                sonuc.Text = "Sonu�: " + listBox1.Items[index];
            } else
            {
                label1.Text = "Listede 1 se�enek var ya da bo�. �nce listeye se�enekler ekleyin.";
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(this, new EventArgs());
            }
        }
    }
}