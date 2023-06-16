using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Contract
    {
		int id;
		string type;
		string availability;
		int duration;
		double cost;

		public Contract(int id, string type, string availability, int duration, double cost, )
		{
			this.id = id;
			this.type = type;
			this.availability = availability;
			this.duration = duration;
			this.cost = cost;

		}

		public int ID { get => id; set => id = value; }
		public string Type { get => type; set => type = value; }
		public string Availability { get => availability; set => availability = value; }
		public int Duration { get => duration; set => duration = value; }
		public double Cost { get => cost; set => cost = value; }

		public void DeleteContract(int id)
		{

		}

		public void UpdateContract(int id)
		{

		}

		public void ContractProfit(double cost)
		{

		}
	}
}
