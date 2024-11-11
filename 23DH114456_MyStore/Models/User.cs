﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _23DH114456_MyStore.Models
{
    using System;
    using System.Collections.Generic;
    using System.Web.Services.Description;

    public partial class User
	{
		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
		public User() {
			this.Customers = new HashSet<Customer>();
		}
		public string Username {  get; set; }
		public string Password { get; set; }
		public string UserRole { get; set; }

		[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
		public virtual ICollection<Customer> Customers { get; set; }
	}
}