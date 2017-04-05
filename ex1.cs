using System;

namespace classes
{
	class MainClass
	{
		class Plane
		{
			public long number;
			public string type;
			public double resurs;
		
			public Plane() { 
				this.number = long.Parse(Console.ReadLine());
				this.type = Console.ReadLine();
				this.resurs = double.Parse(Console.ReadLine());
			}
		}
		class Request {
			public void show(Plane[] a)
			{
				for (int i = 0; i < a.Length; i++)
				{
					Console.WriteLine("{0} {1} {2}", a[i].number, a[i].type, a[i].resurs);
				}
			}
			public void resurs(Plane[] a)
			{
				for (int i = 0; i < a.Length; i++)
				{
					if (a[i].resurs > 200) { 
						Console.WriteLine("{0} {1} {2}", a[i].number, a[i].type, a[i].resurs); 
					}
				}
			}
		}
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Plane[] a = new Plane[n];
			for (int i = 0; i < n; i++) {
				a[i]=new Plane();
			}
			Console.WriteLine("All:");
			Request req=new Request();
			req.show(a);
			Console.WriteLine("Resurs:");
			req.resurs(a);
		}
	}
}
