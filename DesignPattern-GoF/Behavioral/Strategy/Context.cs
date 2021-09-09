using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_GoF.Behavioral.Strategy
{
	public class Context
	{
		IStrategy strategy;

		public Context(IStrategy strategy)
		{
			this.strategy = strategy;
		}

		public void CallAlgorithm()
		{
			Console.WriteLine(this.strategy.Algorithm());
		}
	}
}