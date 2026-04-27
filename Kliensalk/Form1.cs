namespace Kliensalk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adatok();
        }

        private void Szerkeszt_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current == null)
            {
                MessageBox.Show("Válassz ki valamit!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Torles_Click(object sender, EventArgs e)
        {
            if (bindingSource1.Current == null)
            {
                MessageBox.Show("Válassz ki valamit!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void adatok()
        {
            List<DateTime> foglalasok = new List<DateTime>()
            {
                new DateTime(2025, 12, 22, 10, 0, 0),
                new DateTime(2026, 4, 28, 14, 0, 0),
                new DateTime(2026, 4, 25, 9, 0, 0)
            };
            //Ne töltse be az előző foglalásokat, 
            for (int i = 0; i < foglalasok.Count(); i++)
            {
                if (foglalasok[i] >= DateTime.UtcNow)
                {

                }
                else
                {
                    foglalasok.RemoveAt(i);
                }

            }
            //jelölje ki csak a jövőbeli foglalásokat
            var foglaltNapok = foglalasok
                .Select(d => d.Date)
                .Distinct()
                .ToArray();

            monthCalendar1.BoldedDates = foglaltNapok;
        }

        private void Frissit_Click(object sender, EventArgs e)
        {
            adatok();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var kivalasztott = foglalasok
                .Where(x => x.Date == monthCalendar1.SelectionStart.Date)
                .ToList();

            bindingSource1.DataSource = kivalasztott;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var kivalasztott = foglalasok
                .Where(x => x.OszlopNev.Contains(textBox1.Text))
                .ToList();
            bindingSource1.DataSource = kivalasztott;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var uniqueList = foglalasok
                .GroupBy(x => x.TargetColumn)
                .Select(group => group.First())
                .ToList();

            bindingSource1.DataSource = uniqueList;
        }
    }
}
