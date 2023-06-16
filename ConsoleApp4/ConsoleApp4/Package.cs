using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class package
	{
	    int packageid;
		string description;
		string state;
		string performance;


		public package(int packageid, string description, string state, string performance)
		{
			this.packageid = packageid;
			this.description = description;
			this.state = state;
			this.performance = performance;
		}

		public int ID { get => packageid; set => packageid = value; }
		public string Description { get => description; set => description = value; }
		public string State { get => state; set => state = value; }
		public string Performance { get => performance; set => performance = value; }
	}
}
    

