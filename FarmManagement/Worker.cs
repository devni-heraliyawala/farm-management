using System;
namespace FarmManagement
{
    public class Worker
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public byte[]? Image { get; set; }

        public int Age { get; set; }

        public string Email { get; set; } = string.Empty;

        public string WorkerPosition { get; set; } = string.Empty;

        public DateTime CertifiedUntil { get; set; }
    }
}

