using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton {
	class UserContext {

		/// <summary>
		/// fruehe Initialisierung
		/// </summary>
		///
		static UserContext instance = new UserContext();// frueh initialisiert, nicht erst durch if Abfrage spaeter

		#region
		//props
		public int UserId { get; private set; }

		public string Username { get; private set; }

		//Methods as example
		public void Load() {
			//TODO: Load the data from somewhere
		}
		#endregion
		private UserContext() { }

		public static UserContext Instance{ //public natuerlich damit man extern darauf zugreift
			get {
				return instance;
			}
		}		
	}
}

//siehe Main
