namespace Buchungsatz_Trainer
{
    public partial class Form1 : Form
    {
        FormStatistiken dialogStatistiken = new FormStatistiken();
        FormEinstellungen dialogEinstellungen = new FormEinstellungen();
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            labelTitel.Visible = false;
            buttonStart.Visible = false;
            buttonStatistiken.Visible = false;
            buttonEinstellungen.Visible = false;
            comboBoxSoll.Visible = true;
            comboBoxHaben.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;

            buttonHauptmenue.Visible = true;
            buttonWeiter.Visible = true;
            labelBuchungssatz.Visible = true;
            labelGesch�ftsfall.Visible = true;
            labelInhaltGesch�ftsfall.Visible = true;
            labelInhaltGesch�ftsfall.Text = "Irgendein Gesch�ftsfall aus .json Datei!";

            int ergebnis = GenerateNumber(1, 30);
            string x = ergebnis.ToString();
            labelTest.Text = x;
        }

        private void buttonStatistiken_Click(object sender, EventArgs e)
        {
            dialogStatistiken.Show();
        }

        private void buttonEinstellungen_Click(object sender, EventArgs e)
        {
            dialogEinstellungen.Show();
        }

        int GenerateNumber(int from, int to)
        {
            Random cube = new Random();
            int ergebnis = cube.Next(from, to);
            return ergebnis;
        }

        private void buttonHauptmenue_Click(object sender, EventArgs e)
        {
            labelTitel.Visible = true;
            buttonStart.Visible = true;
            buttonStatistiken.Visible = true;
            buttonEinstellungen.Visible = true;
            comboBoxSoll.Visible = false;
            comboBoxHaben.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;

            buttonHauptmenue.Visible = false;
            buttonWeiter.Visible = false;
            labelBuchungssatz.Visible = false;
            labelGesch�ftsfall.Visible = false;
            labelInhaltGesch�ftsfall.Visible = false;
            //Inhalt auf Variablen speichern
        }

        private void buttonWeiter_Click(object sender, EventArgs e)
        {
            //Inhalt auf Variablen speichern
            //L�sung anzeigen
            //Felder leeren
        }
    }
}