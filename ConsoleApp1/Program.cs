//Un vendedor recibe un sueldo base más un 10% extra por comisión de su ventas,
//el vendedor desea saber cuánto dinero obtendrá por concepto de
//comisiones por las tres ventas que realiza en el mes y el total que
//recibirá en el mes tomando en cuenta su sueldo base y comisiones. 

public class TallerPunto3
{
    static void Main(string[] args)
    {
        decimal sumaVentas, sueldoBase, venta1, venta2, venta3, totalComision, salarioTotal;

        Console.Write("Ingrese sueldo:");
        sueldoBase = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese venta 1:");
        venta1 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese venta 2:");
        venta2 = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese venta 3:");
        venta3 = decimal.Parse(Console.ReadLine());

        sumaVentas = venta1 + venta2 + venta3;
        totalComision = sumaVentas * 10/100;
        salarioTotal = sueldoBase + totalComision;

        Console.WriteLine($"Su comision total es de:{totalComision}");
        Console.WriteLine($"Su salario total es de:{salarioTotal}");
    }
}