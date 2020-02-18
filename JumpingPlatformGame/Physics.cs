using System;
namespace JumpingPlatformGame {
	static class IntExtensions
	{
		//public static Seconds Seconds(this int i)
		//{
		//	return new Seconds(i);
		//}
		public static Meters Meters(this int i)
		{
			return new Meters(i);
		}
		public static MeterPerSeconds MeterPerSeconds(this int i)
		{
			return new MeterPerSeconds(i);
		}
	}
	static class DoubleExtensions
	{
		public static MeterPerSeconds MeterPerSeconds(this double d)
		{
			return new MeterPerSeconds(d);
		}
		public static Seconds Seconds(this double i)
		{
			return new Seconds(i);
		}
	}
	struct Seconds
	{
		public double Value { get; private set; }
		public Seconds(double s)
		{
			Value = s;
		}
		public static Seconds operator +(Seconds s1, Seconds s2)
		{
			return new Seconds(s1.Value + s2.Value);
		}
	}
	struct Meters
	{
		public int Value;
		public Meters(int m)
		{
			Value = m;
		}
		public static Speed operator /(Meters m, Seconds s)
		{
			return new Speed((double)m.Value/s.Value);
		}
	}
	struct Speed
	{
		double Value;
		public Speed(double s)
		{
			Value = s;
		}
	}
	struct MeterPerSeconds
	{
		public double Value;
		public MeterPerSeconds(double value)
		{
			this.Value = value;
		}
	}
	class WorldPoint
	{
		public Meters X,Y;
		
	}
	class Movement
	{
		public Meters LowerBound, UpperBound;
		public MeterPerSeconds Speed;
		public Movement()
		{

		}
	}
}