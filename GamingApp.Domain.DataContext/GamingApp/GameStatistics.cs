﻿using System;
using System.ComponentModel.DataAnnotations;

namespace GamingApp.Domain.DataContext.GamingApp
{
    public partial class GameStatistics
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)]
        public string Player1Name { get; set; }

        [StringLength(50)]
        public string Player2Name { get; set; }

        [StringLength(50)]
        public string PlayerWinner { get; set; }

        public DateTime? TimeStamp { get; set; }

        [StringLength(50)]
        public string FinalScore { get; set; }
    }
}
