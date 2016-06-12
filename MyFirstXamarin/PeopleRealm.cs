using System;
using Realms;

namespace MyFirstXamarin
{
	public class PeopleRealm: RealmObject
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }
	}
}

