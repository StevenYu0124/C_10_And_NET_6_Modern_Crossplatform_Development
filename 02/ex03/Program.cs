class Program{
    static void Main(string[] args){
        Console.WriteLine("------------------------------------------------------------------------------");
        Console.WriteLine("Type\tByte(s)\t{0,30}\t{1,30}","Min","Max");
        Console.WriteLine("------------------------------------------------------------------------------");
        Console.WriteLine("{0}\t{1}\t{2,30}\t{3,30}", typeof(sbyte).Name, sizeof(sbyte), sbyte.MinValue, sbyte.MaxValue);
        Console.WriteLine("{0}\t{1}\t{2,30}\t{3,30}", typeof(byte).Name, sizeof(byte), byte.MinValue, byte.MaxValue);
        Console.WriteLine("{0}\t{1}\t{2,30}\t{3,30}", typeof(short).Name, sizeof(short), short.MinValue, short.MaxValue);
        Console.WriteLine("{0}\t{1}\t{2,30}\t{3,30}", typeof(ushort).Name, sizeof(ushort), ushort.MinValue, ushort.MaxValue);
        Console.WriteLine("{0}\t{1}\t{2,30}\t{3,30}", typeof(int).Name, sizeof(int), int.MinValue, int.MaxValue);
        Console.WriteLine("{0}\t{1}\t{2,30}\t{3,30}", typeof(uint).Name, sizeof(uint), uint.MinValue, uint.MaxValue);
        Console.WriteLine("{0}\t{1}\t{2,30}\t{3,30}", typeof(long).Name, sizeof(long), long.MinValue, long.MaxValue);
        Console.WriteLine("{0}\t{1}\t{2,30}\t{3,30}", typeof(ulong).Name, sizeof(ulong), ulong.MinValue, ulong.MaxValue);
        Console.WriteLine("{0}\t{1}\t{2,30}\t{3,30}", typeof(float).Name, sizeof(float), float.MinValue, float.MaxValue);
        Console.WriteLine("{0}\t{1}\t{2,30}\t{3,30}", typeof(double).Name, sizeof(double), double.MinValue, double.MaxValue);
        Console.WriteLine("{0}\t{1}\t{2,30}\t{3,30}", typeof(decimal).Name, sizeof(decimal), decimal.MinValue, decimal.MaxValue);
        Console.WriteLine("------------------------------------------------------------------------------");
    }
}

