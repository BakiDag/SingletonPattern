using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton {
	class UserContext2 {

		/// <summary>
		/// spaete Initialisierung
		/// </summary>
		
		static UserContext2 instance;

		#region
		//props
		public int UserId { get; private set; }

		public string Username { get; private set; }

		//Methods as example
		public void Load() {
			//TODO: Load the data from somewhere
		}
		#endregion

		private UserContext2 () { } //Constructor immer privat

		public static UserContext2 Instance {//public natuerlich damit man extern darauf zugreift
			get {
			if (instance==null) 
				instance = new UserContext2(); //spaete Initialisierung
				
			return instance;
			}
		}
		
	}
}


//siehe Main
