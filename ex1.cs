using System;

namespace classes
{
	class MainClass
	{
		class Plane
		{
			public long name;
			public string type;
			public double resurs;
		
			public Plane() { 
				this.name = long.Parse(Console.ReadLine());
				this.type = Console.ReadLine();
				this.resurs = double.Parse(Console.ReadLine());
			}
			public void show()
			{
				Console.WriteLine("{0} {1} {2}",this.name,this.type,this.resurs);
			}
		}
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			Plane[] a = new Plane[n];
			for (int i = 0; i < n; i++) {
				a[i]=new Plane();
			}
			for (int i = 0; i < n; i++) {
				a[i].show();
			}
		}
	}
}
