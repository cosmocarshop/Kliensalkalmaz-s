using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kliensalk
{
    public class Booking
    {
        public int BookingId { get; set; }
        public int ModuleId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNr { get; set; }
        public string? Comment { get; set; }
        public int Status { get; set; }
        public List<string> ProductBvins { get; set; }
        public string SerializedProductBvins { get; set; }

        private static readonly Dictionary<string, string> TermekNevek = new()
        {
            { "6a4d30fb-c55f-4250-83b9-4e67d8e48045", "Belső tisztítás" },
            { "ba460cc2-a9d3-47e4-974f-bbc14aa2a313", "Külső mosás" },
            { "2eda0eeb-5c1f-4dbb-a390-9c528d52dcd7", "Kerámia bevonat" },
            { "b9f7bc5c-8efa-4a1f-92d0-e8763f8c894d", "Teljes autópolírozás" }

        };

        public string Termekek => string.Join(", ",
            ProductBvins
                .Select(p => TermekNevek.TryGetValue(p.Trim(), out var nev) ? nev : p)
                .ToList()
        );
    }
}
