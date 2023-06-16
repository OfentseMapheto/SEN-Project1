using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Service
    {
		public int id;
		public string description;
		public string type;
		public string level;

		public Service(int id, string description, string type, string level)
		{
			this.id = id;
			this.description = description;
			this.type = type;
			this.level = level;
		}

		public int ID { get => id; set => id = value; }
		public string Description { get => description; set => description = value; }
		public string Type { get => type; set => type = value; }
		public string Level { get => level; set => level = value; }
	}
}
