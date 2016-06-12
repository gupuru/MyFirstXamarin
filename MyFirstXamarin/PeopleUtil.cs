using System;
using System.Collections.Generic;
using Realms;

namespace MyFirstXamarin
{
	public class PeopleUtil
	{

		public PeopleUtil()
		{
		}

		public void write(List<People> people)
		{
			var realm = Realm.GetInstance();
			realm.Write(() =>
			{
				foreach (People p in people)
				{
					var myPeople = realm.CreateObject<PeopleRealm>();
					myPeople.FirstName = p.FirstName;
					myPeople.LastName = p.LastName;
				}
						
			});

		}

		public List<People> read()
		{
			List<People> people = new List<People>();
			var realm = Realm.GetInstance();
			var e = realm.All<PeopleRealm>();
			foreach (var p in e)
			{
				People pe = new People();
				pe.FirstName = p.FirstName;
				pe.LastName = p.LastName;

				people.Add(pe);
			}
			return people;

		}

	}
}

