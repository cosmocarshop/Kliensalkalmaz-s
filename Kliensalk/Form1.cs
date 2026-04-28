
using System.Net.Http;
using System.Net.Http.Json;
using System.Reflection;
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

        private async void Szerkeszt_Click(object sender, EventArgs e)
        {
            if (bookingBindingSource.Current == null)
            {
                MessageBox.Show("Válassz ki valamit!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var kivalasztott = bookingBindingSource.Current as Booking;
                if (kivalasztott == null) return;

                // Open edit form with a COPY so cancel truly cancels
                var copy = new Booking
                {
                    BookingId = kivalasztott.BookingId,
                    ModuleId = kivalasztott.ModuleId,
                    Name = kivalasztott.Name,
                    Email = kivalasztott.Email,
                    PhoneNr = kivalasztott.PhoneNr,
                    Comment = kivalasztott.Comment,
                    Start = kivalasztott.Start,
                    End = kivalasztott.End,
                    Status = kivalasztott.Status,
                    ProductBvins = kivalasztott.ProductBvins,
                    SerializedProductBvins = kivalasztott.SerializedProductBvins
                };

                using var form = new Szerkesztes(copy);
                if (form.ShowDialog() != DialogResult.OK) return;

                try
                {
                    var client = new HttpClient();

                    // --- LOGIN ---
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
                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", loginData!.AccessToken);

                    // --- PUT UPDATE ---
                    var updateContent = new StringContent(
                        JsonSerializer.Serialize(form.SzerkesztettFoglalas),
                        Encoding.UTF8,
                        "application/json"
                    );

                    var response = await client.PutAsync(
                        "http://74.178.92.39/DesktopModules/BookingModule/API/BookingsApi/Update",
                        updateContent
                    );

                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Mentve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await adatok();
                        adatok2();
                    }
                    else
                    {
                        var err = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Hiba: {response.StatusCode}\n{err}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kivétel: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void Torles_Click(object sender, EventArgs e)
        {
            if (bookingBindingSource.Current == null)
            {
                MessageBox.Show("Válassz ki valamit!", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {


                var torlendo = bookingBindingSource.Current as Booking;
                if (torlendo == null) return;

                var confirm = MessageBox.Show(
                    $"Biztosan törlöd a foglalást?\n{torlendo.Name} - {torlendo.Start}",
                    "Törlés megerősítése",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );
                if (confirm != DialogResult.Yes) return;

                try
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

                    client.DefaultRequestHeaders.Authorization =
                        new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);


                    string url = $"http://74.178.92.39/DesktopModules/BookingModule/API/BookingsApi/Delete?moduleId=0&bookingId={torlendo.BookingId}";
                    var response = await client.DeleteAsync(url);


                    if (response.IsSuccessStatusCode)
                    {
                        MessageBox.Show("Törölve!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        await adatok();
                        await adatok2();
                    }
                    else
                    {
                        var err = await response.Content.ReadAsStringAsync();
                        MessageBox.Show($"Hiba a törlésnél: {response.StatusCode}\n{err}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kivétel: {ex.Message}", "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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


        }
        private async Task adatok2()
        {
            //Ne töltse be az előző foglalásokat, 
            foglalasok = foglalasok
                .Where(f => f.Start.Date >= DateTime.Now.Date)
                .ToList();

            //jelölje ki csak a jövőbeli foglalásokat
            var foglaltNapok = foglalasok
                .Select(d => d.Start.Date)
                .Distinct()
                .ToArray();

            monthCalendar1.BoldedDates = foglaltNapok;

            bookingBindingSource.DataSource = foglalasok;
            bookingBindingSource.ResetBindings(false);

            BeallitGridOszlopok();
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
            var kivalasztott = foglalasok
                .Where(x => x.Name.Contains(textBox1.Text))
                .ToList();
            bookingBindingSource.DataSource = kivalasztott;
            bookingBindingSource.ResetBindings(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string kulcs = "6a4d30fb-c55f-4250-83b9-4e67d8e48045";
            var kivalasztott = foglalasok
                .Where(x => x.ProductBvins.Contains(kulcs))
                .ToList();

            bookingBindingSource.DataSource = kivalasztott;
            bookingBindingSource.ResetBindings(false);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kulcs = "ba460cc2-a9d3-47e4-974f-bbc14aa2a313";
            var kivalasztott = foglalasok
                .Where(x => x.ProductBvins.Contains(kulcs))
                .ToList();

            bookingBindingSource.DataSource = kivalasztott;
            bookingBindingSource.ResetBindings(false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string kulcs = "2eda0eeb-5c1f-4dbb-a390-9c528d52dcd7";
            var kivalasztott = foglalasok
                .Where(x => x.ProductBvins.Contains(kulcs))
                .ToList();

            bookingBindingSource.DataSource = kivalasztott;
            bookingBindingSource.ResetBindings(false);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string kulcs = "b9f7bc5c-8efa-4a1f-92d0-e8763f8c894d";
            var kivalasztott = foglalasok
                .Where(x => x.ProductBvins.Contains(kulcs))
                .ToList();

            bookingBindingSource.DataSource = kivalasztott;
            bookingBindingSource.ResetBindings(false);
        }
        private void BeallitGridOszlopok()
        {
            dataGridView1.AutoGenerateColumns = true;

            if (dataGridView1.Columns["ProductBvins"] != null)
                dataGridView1.Columns["ProductBvins"].Visible = false;

            if (dataGridView1.Columns["SerializedProductBvins"] != null)
                dataGridView1.Columns["SerializedProductBvins"].Visible = false;

            if (dataGridView1.Columns["Termekek"] != null)
            {
                dataGridView1.Columns["Termekek"].HeaderText = "Termékek";
                dataGridView1.Columns["Termekek"].Visible = true;
            }
        }
    }
}
