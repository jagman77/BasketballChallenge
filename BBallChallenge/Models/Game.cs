using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BBallChallenge.Models
{
    public class Game
    {
        public int ID { get; set; }
        [DataType(DataType.Time)]
        public DateTime GameTime { get; set; }
        [DataType(DataType.Date)]
        public DateTime GameDate { get; set; }
        public string Venue { get; set; }
        public string Payee { get; set; }
        public float AmountPaid { get; set; }
    }
}
