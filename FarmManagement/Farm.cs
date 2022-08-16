using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace FarmManagement
{
    public class Farm
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,4)")]
        public decimal GPSPosition { get; set; }

        public int NoOfCages { get; set; }

        public byte[] Image { get; set; }

        public List<Worker> Workers { get; set; }
        
    }
}

