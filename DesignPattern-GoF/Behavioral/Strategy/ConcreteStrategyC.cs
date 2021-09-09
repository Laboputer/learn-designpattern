using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_GoF.Behavioral.Strategy
{
	public class ConcreteStrategyC : IStrategy
	{
		public object Algorithm()
		{
			return "Concrete Strategy C";
		}
	}
}