using System;
using System.ComponentModel.DataAnnotations;
using Entities.Abstract;

namespace Entities.Concrete
{
	public class deneme : IEntity
	{
        [Key]
		public string tckno { get; set; }

		public string isim { get; set; }

		public string adres { get; set; }

		
	
	}
}

