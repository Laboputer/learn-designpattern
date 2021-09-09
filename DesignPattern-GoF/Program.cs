using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern_GoF
{
	class Program
	{
		static void Main(string[] args)
		{
			// Strategy
			new Behavioral.Strategy.Context(new Behavioral.Strategy.ConcreteStrategyA()).CallAlgorithm();

		}
	}
}
