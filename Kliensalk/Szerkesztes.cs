namespace Kliensalk
{
    public partial class Szerkesztes : Form
    {
        private Booking _booking;

        public Booking SzerkesztettFoglalas => _booking;
        public Szerkesztes(Booking booking)
        {
            InitializeComponent();
            _booking = booking;
            ToltseKi();
        }
        private void ToltseKi()
        {
            txtname.Text = _booking.Name;
            txtemail.Text = _booking.Email;
            txtphone.Text = _booking.PhoneNr;
            txtmegj.Text = _booking.Comment;
            dateTstart.Value = _booking.Start;
            dateTend.Value = _booking.End;
        }

        private void Szerkesztes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            _booking.Name = txtname.Text;
            _booking.Email = txtemail.Text;
            _booking.PhoneNr = txtphone.Text;
            _booking.Comment = txtmegj.Text;
            _booking.Start = dateTstart.Value;
            _booking.End = dateTend.Value;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
