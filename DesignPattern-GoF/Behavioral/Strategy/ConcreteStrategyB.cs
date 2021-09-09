using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_GoF.Behavioral.Strategy
{
	public class ConcreteStrategyB : IStrategy
	{
		public object Algorithm()
		{
			return "Concrete Strategy B";
		}
	}
}
