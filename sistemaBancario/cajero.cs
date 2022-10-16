
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace sistemaBancario
{
    internal class cajero : caja
    {

        // Declaracion de Atributos Cajero

        private String cedula { get; set; }
        private String nombre { get; set; }
        private String telefono { get; set; }
        private String direccion { get; set; }

        //Metodo Constructor

        public cajero(String cedula, String nombre, String telefono, String direccion)
        {
            this.cedula = cedula;
            this.nombre = nombre;
            this.telefono = telefono;
            this.direccion = direccion;

        }

        public cajero()
        {

        }

        //Creacion de Intefaces

        interface ICajero1
        {
            void emisionTarjetas();
        }

        interface ICajero2
        {
            void emisionChequeras();
            void emisionBonos();
        }

        interface ICajero3
        {
            void creditosHipotecarios();
            void creditosVehiculos();
        }

        //Metodos de la Clase Cajero
        //Pagos de Servicios, Depositos y Cambio de Cheques

        public void pagoServicios()
        {

            Console.WriteLine("PRUEBA PAGO DE SERVICIOS");

        }

        public void deposito()
        {

            Console.WriteLine("Ingrese la cuenta a la que va a depositar: \n" +
                "Cuenta: 001-XXXXXXX-X\n");
            String cuenta = Console.ReadLine();
            Console.WriteLine("Ingrese el monto a depositar: ");
            float monto = float.Parse(Console.ReadLine());
            Console.WriteLine("Realizando Deposito... Espere por favor...");
            Console.WriteLine("Deposito a la cuenta: " + cuenta + " por un monto de: " + monto + "\n" + "Se realizo correctamente.");
        }

        public void cambioCheque()
        {

            Console.WriteLine("Ingrese el numero del cheque que desea cambiar: \n" +
                "N° Cheque: X-XXXXXXX\n");
            String cheque = Console.ReadLine();
            Console.WriteLine("Ingrese el monto del cheque a cambiar: ");
            float monto = float.Parse(Console.ReadLine());
            Console.WriteLine("Realizando Cambio de Cheque... Espere por favor...");
            Console.WriteLine("El cambio del cheque N°: " + cheque + " por un monto de: " + monto + "\n" + "Se realizo correctamente.");

        }



        //Clase Cajero1

        public class cajero1 : cajero, ICajero1
        {
            public cajero1()
            {

            }

            //Metodo de Emision de Tarjetas
            public void emisionTarjetas()
            {
                Console.WriteLine("Se esta emitiendo una tarjeta... Por favor, espere...");
                Console.WriteLine("Tarjeta emitida, Satisfactoriamente");

            }

        }

        public class cajero2 : cajero, ICajero2
        {
            public cajero2()
            {

            }

            //Metodo de Emision de Tarjetas
            public void emisionChequeras()
            {
                Console.WriteLine("PRUEBA DE EMISION DE CHEQUERAS");
            }
            public void emisionBonos()
            {
                Console.WriteLine("PRUEBA DE EMISION DE BONOS");
            }

        }

        public class cajero3 : cajero, ICajero3
        {
            public cajero3()
            {

            }

            //Metodo de Emision de Tarjetas
            public void creditosHipotecarios()
            {
                Console.WriteLine("PRUEBA DE CREDITOS HIPOTECARIOS");
            }
            public void creditosVehiculos()
            {
                Console.WriteLine("PRUEBA DE CREDITOS VEHICULOS");
            }
        }

    }

}
