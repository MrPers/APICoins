﻿using System.ComponentModel.DataAnnotations;

namespace MailGraphAnalysis.Models
{
    public class CoinExchangeVM
    {
        [Required]
        //public int Id { get; set; }
        public float Prices { get; set; }
        public float VolumeTraded { get; set; }
        public long Time { get; set; }
    }
}