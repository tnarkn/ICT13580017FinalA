using System;
using SQLite;
namespace ICT13580017FinalA.Models
{
    public class Product
    {
        [PrimaryKey, AutoIncrement]
		public int Id { get; set; }
		public int Age { get; set; }
		public int phone { get; set; }
        public int total { get; set; }

        [NotNull]
        [MaxLength(200)]
        public string Name { get; set; }
        public string lastName { get; set; }
        public string department { get; set; }
        public string email { get; set; }
        public string descriptionEditor { get; set; }

        [NotNull]
        [MaxLength(100)]
        public decimal sex { get; set; }
        public decimal salary { get; set; }



    }
}
