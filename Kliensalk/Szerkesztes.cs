using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Text.Json;

namespace Kliensalk
{
    public partial class Szerkesztes : Form
    {
        public List<Booking> foglalasok = new List<Booking>();
        private Booking _booking;

        public Booking SzerkesztettFoglalas => _booking;

        public Szerkesztes(Booking booking)
        {
            InitializeComponent();
            _booking = booking;
            ToltseKi();
        }

        private async void Szerkesztes_Load(object sender, EventArgs e)
        {
            await IdopontokBetolt();
            ToltseListBox();
        }

        private async Task IdopontokBetolt()
        {
            var client = new HttpClient();

            var payload = new { u = "root", p = "HengereltFejek26" };
            var content = new StringContent(
                JsonSerializer.Serialize(payload),
                Encoding.UTF8,
                "application/json"
            );

            var loginResponse = await client.PostAsync(
                "http://74.178.92.39/DesktopModules/JwtAuth/API/mobile/login",
                content
            );
            loginResponse.EnsureSuccessStatusCode();

            var loginData = await loginResponse.Content.ReadFromJsonAsync<Loginresponse>();
            string accessToken = loginData!.AccessToken;

            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            var bookings = await client.GetFromJsonAsync<List<Booking>>(
                "http://74.178.92.39/DesktopModules/BookingModule/API/BookingsApi/GetAll?moduleId=0"
            );
            foglalasok = bookings!;
        }

        private void ToltseListBox()
        {
            List<int> osszes = new List<int> { 9, 10, 11, 12, 13, 14, 15, 16 };

            DateTime kivalasztottDatum = dateTstart.Value.Date;

            // Collect hours that are already booked on the selected date
            var foglaltOrak = foglalasok
                .Where(b => b.Start.Date == kivalasztottDatum)
                .Select(b => b.Start.Hour)
                .ToHashSet();

            // Remove currently edited booking's hour so it can be re-selected
            foglaltOrak.Remove(_booking.Start.Hour);

            comboBox1.Items.Clear();
            foreach (int ora in osszes)
            {
                if (!foglaltOrak.Contains(ora))
                {
                    comboBox1.Items.Add($"{ora}:00");
                }
            }

            // Pre-select the current booking's hour if it's on the same date
            if (_booking.Start.Date == kivalasztottDatum)
            {
                string kivalasztott = $"{_booking.Start.Hour}:00";
                int idx = comboBox1.Items.IndexOf(kivalasztott);
                if (idx >= 0)
                    comboBox1.SelectedIndex = idx;
            }
        }

        private void ToltseKi()
        {
            txtname.Text = _booking.Name;
            txtemail.Text = _booking.Email;
            txtphone.Text = _booking.PhoneNr;
            txtmegj.Text = _booking.Comment;
            dateTstart.Value = _booking.Start;
        }

        // Refresh listbox when the selected date changes
        private void dateTstart_ValueChanged(object sender, EventArgs e)
        {
            if (foglalasok.Count > 0)
                ToltseListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Kérjük válasszon időpontot!", "Figyelmeztetés",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Parse selected hour from listbox (e.g. "10:00" → 10)
            int kivalasztottOra = int.Parse(comboBox1.SelectedItem.ToString()!.Split(':')[0]);

            DateTime start = dateTstart.Value.Date.AddHours(kivalasztottOra);
            DateTime end = start.AddHours(1);

            _booking.Name = txtname.Text;
            _booking.Email = txtemail.Text;
            _booking.PhoneNr = txtphone.Text;
            _booking.Comment = txtmegj.Text;
            _booking.Start = start;
            _booking.End = end;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Can be used for live preview if needed
        }
    }
}