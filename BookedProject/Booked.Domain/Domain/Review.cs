using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booked.Domain.Domain
{
	public class Review
	{
		public User User { get; set; }
		public string Desciption { get; set; }
		public int Rating { get; set; }
		
		public Review() { }
	}
}
