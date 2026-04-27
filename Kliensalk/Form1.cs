
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Policy;
using System.Text;
using System.Text.Json;

namespace Kliensalk
{
    public partial class Form1 : Form
    {
        public List<Booking> foglalasok = new List<Booking>();
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = bookingBindingSource;
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await adatok();
            await adatok2();
        }

        private void Szerkeszt_Click(object sender, EventArgs e)
        {
            if (bookingBindingSource.Current == null)
            {
                MessageBox.Show("Válassz ki valamit!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Torles_Click(object sender, EventArgs e)
        {
            if (bookingBindingSource.Current == null)
            {
                MessageBox.Show("Válassz ki valamit!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public async Task adatok()
        {
            var client = new HttpClient();

            // --- 1. LOGIN ---
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

            // --- 2. SET BEARER TOKEN ---
            client.DefaultRequestHeaders.Authorization =
                new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

            // --- 3. GET BOOKINGS ---
            var bookings = await client.GetFromJsonAsync<List<Booking>>(
                "http://74.178.92.39/DesktopModules/BookingModule/API/BookingsApi/GetAll?moduleId=0"
            );
            foglalasok = bookings!;
            MessageBox.Show($"Loaded {foglalasok.Count} bookings");

        }
        private async Task adatok2()
        {
            //Ne töltse be az előző foglalásokat, 
            foglalasok = foglalasok
                .Where(f => f.Start >= DateTime.Now)
                .ToList();

            //jelölje ki csak a jövőbeli foglalásokat
            var foglaltNapok = foglalasok
                .Select(d => d.Start.Date)
                .Distinct()
                .ToArray();

            monthCalendar1.BoldedDates = foglaltNapok;

            bookingBindingSource.DataSource = foglalasok;
            bookingBindingSource.ResetBindings(false);
        }

        private async void Frissit_Click(object sender, EventArgs e)
        {
            await adatok();
            await adatok2();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            var kivalasztott = foglalasok
                .Where(x => x.Start.Date == monthCalendar1.SelectionStart.Date)
                .ToList();

            bookingBindingSource.DataSource = kivalasztott;
            bookingBindingSource.ResetBindings(false);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var kivalasztott = foglalasok
            //    .Where(x => x.OszlopNev.Contains(textBox1.Text))
            //    .ToList();
            //bindingSource1.DataSource = kivalasztott;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //var uniqueList = foglalasok
            //    .GroupBy(x => x.TargetColumn)
            //    .Select(group => group.First())
            //    .ToList();

            //bindingSource1.DataSource = uniqueList;
        }
    }
}
