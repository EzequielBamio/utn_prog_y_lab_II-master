using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Por teclado se ingresa el valor hora, el nombre, la antigüedad (en años) y la cantidad de horas
            trabajadas en el mes de N empleados de una fábrica.
            Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el
            valor hora por la cantidad de horas trabajadas), hay que sumarle la cantidad de años trabajados
            multiplicados por $ 150, y al total de todas esas operaciones restarle el 13% en concepto de
            descuentos.
            Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en
            bruto, el total de descuentos y el valor neto a cobrar de todos los empleados ingresados.
            Nota: Utilizar estructuras repetitivas y selectivas.*/
            int valorHora;
            int horasTrabajadasMes;
            int antiguedad;
            string nombre;
            int importeTotalHorasTrabajadas;
            int importePorAniosTrabajados;
            int importeTotal;
            int totalConDescuento;
            Console.WriteLine("INGRESE VALOR HORA: ");
            int.TryParse(Console.ReadLine(), out valorHora);
            Console.WriteLine("INGRESE NOMBRE: ");
            nombre = Console.ReadLine();
            Console.WriteLine("INGRESE ANTIGUEDAD (EN AÑOS): ");
            int.TryParse(Console.ReadLine(), out antiguedad);
            Console.WriteLine("INGRESE CANTIDAD DE HORAS TRABAJADAS EN EL MES: ");
            int.TryParse(Console.ReadLine(), out horasTrabajadasMes);

            importeTotalHorasTrabajadas = valorHora * horasTrabajadasMes;
            importePorAniosTrabajados = antiguedad * 150;
            importeTotal = importeTotalHorasTrabajadas + importePorAniosTrabajados;
            totalConDescuento = importeTotal - ((importeTotal * 13) / 100);
            Console.WriteLine("[+] TICKED EMPLEADOS DE FABRICA: ");
            Console.WriteLine("[+] NOMBRE: {0}", nombre);
            Console.WriteLine("[+] ANTIGUEDAD: {0}", antiguedad);
            Console.WriteLine("[+] VALOR p/HORA: {0}", valorHora);
            Console.WriteLine("[+] TOTAL A COBRAR: {0}", importeTotal);
            Console.WriteLine("[+] TOTAL CON DESCUENTOS: {0}", totalConDescuento);

            Console.ReadLine();
        }
    }
}
