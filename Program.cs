using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea_1_Gerardo_Saenz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarea 1: Aumento Salarial");
            int cantidad_op = 0;
            int cantidad_tc = 0;
            int cantidad_pr = 0;
            double acumulado_op = 0;
            double acumulado_tc = 0;
            double acumulado_pr = 0;
            double promedio_op = 0;
            double promedio_tc = 0;
            double promedio_pr = 0;
            while (true)
            {
                Console.Write("Digite 1. Calcular aumento 2. Salir :");
                string entrada = Console.ReadLine();
                if(int.TryParse(entrada, out int seleccion))
                { 
                    if (seleccion == 1)
                    {
                        Console.Write("Ingrese su cédula:");
                        string cedula = Console.ReadLine();
                        Console.Write("Ingrese su nombre completo:");
                        string nombre = Console.ReadLine();
                        Console.Write("Digite: 1 Operario  2 Técnico  3 Profesional");
                        int trabajador = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese la cantidad de horas laboradas:");
                        int canthora = int.Parse(Console.ReadLine());
                        Console.Write("Ingrese el precio por hora laborada:");
                        double valorhora = double.Parse(Console.ReadLine());
                        if (trabajador==1)
                        { 
                            double salario_ordinario_op = valorhora*canthora;
                            double aumento_op = valorhora*canthora*0.15;
                            double salario_bruto_op= salario_ordinario_op+aumento_op;
                            double deduccion_op = salario_bruto_op * 0.0917;
                            double salario_neto_op = salario_bruto_op - deduccion_op;
                            cantidad_op = cantidad_op+1;
                            acumulado_op = acumulado_op + salario_neto_op;
                            promedio_op = acumulado_op / cantidad_op;
                            Console.WriteLine($"Cédula: {cedula}");
                            Console.WriteLine($"Nombre Empleado: {nombre}");
                            Console.WriteLine($"Tipo de Empleado: Operario");
                            Console.WriteLine($"Salario por Hora: {valorhora}");
                            Console.WriteLine($"Cantidad de Horas: {canthora}");
                            Console.WriteLine($"Salario Ordinario: {salario_ordinario_op}");
                            Console.WriteLine($"Aumento: {aumento_op}");
                            Console.WriteLine($"Salario Bruto: {salario_bruto_op}");
                            Console.WriteLine($"Deducción CCSS: {deduccion_op}");
                            Console.WriteLine($"Salario Neto: {salario_neto_op}");
                        }
                        if (trabajador == 2)
                        {
                            double salario_ordinario_tc = valorhora * canthora;
                            double aumento_tc = valorhora * canthora * 0.1;
                            double salario_bruto_tc = salario_ordinario_tc + aumento_tc;
                            double deduccion_tc = salario_bruto_tc * 0.0917;
                            double salario_neto_tc = salario_bruto_tc - deduccion_tc;
                            cantidad_tc = cantidad_tc+1;
                            acumulado_tc = acumulado_tc + salario_neto_tc;
                            promedio_tc = acumulado_tc / cantidad_tc;
                            Console.WriteLine($"Cédula: {cedula}");
                            Console.WriteLine($"Nombre Empleado: {nombre}");
                            Console.WriteLine($"Tipo de Empleado: Técnico");
                            Console.WriteLine($"Salario por Hora: {valorhora}");
                            Console.WriteLine($"Cantidad de Horas: {canthora}");
                            Console.WriteLine($"Salario Ordinario: {salario_ordinario_tc}");
                            Console.WriteLine($"Aumento: {aumento_tc}");
                            Console.WriteLine($"Salario Bruto: {salario_bruto_tc}");
                            Console.WriteLine($"Deducción CCSS: {deduccion_tc}");
                            Console.WriteLine($"Salario Neto: {salario_neto_tc}");
                        }
                        if (trabajador == 3)
                        {
                            double salario_ordinario_pr = valorhora * canthora;
                            double aumento_pr = valorhora * canthora * 0.05;
                            double salario_bruto_pr = salario_ordinario_pr + aumento_pr;
                            double deduccion_pr = salario_bruto_pr * 0.0917;
                            double salario_neto_pr = salario_bruto_pr - deduccion_pr;
                            cantidad_pr = cantidad_pr+1;
                            acumulado_pr = acumulado_pr + salario_neto_pr;
                            promedio_pr = acumulado_pr / cantidad_pr;
                            Console.WriteLine($"Cédula: {cedula}");
                            Console.WriteLine($"Nombre Empleado: {nombre}");
                            Console.WriteLine($"Tipo de Empleado: Profesional");
                            Console.WriteLine($"Salario por Hora: {valorhora}");
                            Console.WriteLine($"Cantidad de Horas: {canthora}");
                            Console.WriteLine($"Salario Ordinario: {salario_ordinario_pr}");
                            Console.WriteLine($"Aumento: {aumento_pr}");
                            Console.WriteLine($"Salario Bruto: {salario_bruto_pr}");
                            Console.WriteLine($"Deducción CCSS: {deduccion_pr}");
                            Console.WriteLine($"Salario Neto: {salario_neto_pr}");
                        }


                }
                if (seleccion == 2) 
                {
                    Console.WriteLine($"Cantidad Empleados Tipo Operarios: {cantidad_op}");
                    Console.WriteLine($"Acumulado Salario Neto para Operarios: {acumulado_op}");
                    Console.WriteLine($"Promedio Salario Neto para Operarios: {promedio_op}");
                    Console.WriteLine($"Cantidad Empleados Tipo Técnico: {cantidad_tc}");
                    Console.WriteLine($"Acumulado Salario Neto para Técnicos:{acumulado_tc} ");
                    Console.WriteLine($"Promedio Salario Neto para Técnicos:{promedio_tc} ");
                    Console.WriteLine($"Cantidad Empleados Tipo Profesional:{cantidad_pr} ");
                    Console.WriteLine($"Acumulado Salario Neto para Profesional: {acumulado_pr}");
                    Console.WriteLine($"Promedio Salario Neto para Profesionales: {promedio_pr}");

                }

                    Console.Read();
        
                }
            }

        }
    }
}
