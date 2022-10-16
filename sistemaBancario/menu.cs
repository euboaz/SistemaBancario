
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static sistemaBancario.cajero;

namespace sistemaBancario
{
    internal class menu
    {
        //Declaracion de variables

        int seleccion = 0;
        public int bucle = 1;

        //Metodo Constructor

        public menu()
        {
        }

        //Metodos de la Clase Menu

        //Creacion de Objeto Cajeros
        cajero1 cajero1 = new cajero1();
        cajero2 cajero2 = new cajero2();
        cajero3 cajero3 = new cajero3();

        //Menu de Cliente

        public void menuCliente()
        {

            do
            {
                Console.WriteLine("***** Bienvenido al Sistema de Banca en Linea para Clientes *****\n" +
                "Por favor, seleccione el cajero para realizar su tramite: \n" +
                "Todos los cajeros realizan: Pagos de Servicios, Depositos y Cambio de Cheques\n" +
                "1) Cajero N°1 (Emision de Tarjetas)\n" +
                "2) Cajero N°2 (Emision de Chequeras y Bonos)\n" +
                "3) Cajero N°3 (Creditos)\n" +
                "4) Regresar al Menu Principal\n");
                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {

                    case 1:
                        do
                        {
                            Console.WriteLine("***** Menu de Cajero 1 *****\n" +
                "Por favor, seleccione el tramite a realizar: \n" +
                "Todos los cajeros realizan: Pagos de Servicios, Depositos y Cambio de Cheques\n" +
                "1) Emision de Tarjetas\n" +
                "2) Pago de Servicios\n" +
                "3) Depositos\n" +
                "4) Cambio de Cheques\n" +
                "5) Regresar al Menu Principal\n");
                            seleccion = int.Parse(Console.ReadLine());

                            switch (seleccion)
                            {


                                case 1:
                                    cajero1.emisionTarjetas();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 2:
                                    cajero1.pagoServicios();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 3:
                                    cajero1.deposito();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 4:
                                    cajero1.cambioCheque();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 5:
                                    bucle = 2;
                                    break;

                            }
                        } while (bucle == 1);

                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("***** Menu de Cajero 2 *****\n" +
                "Por favor, seleccione el tramite a realizar: \n" +
                "Todos los cajeros realizan: Pagos de Servicios, Depositos y Cambio de Cheques\n" +
                "1) Emision de Chequeras\n" +
                "2) Emision de Bonos \n" +
                "3) Pago de Servicios\n" +
                "4) Depositos\n" +
                "5) Cambio de Cheques\n" +
                "6) Regresar al Menu Principal\n");
                            seleccion = int.Parse(Console.ReadLine());

                            switch (seleccion)
                            {


                                case 1:
                                    cajero2.emisionChequeras();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 2:
                                    cajero2.emisionBonos();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 3:
                                    cajero2.pagoServicios();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 4:
                                    cajero2.deposito();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 5:
                                    cajero2.cambioCheque();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 6:
                                    bucle = 2;
                                    break;

                            }
                        } while (bucle == 1);

                        break;

                    case 3:
                        do
                        {
                            Console.WriteLine("***** Menu de Cajero 3 *****\n" +
                "Por favor, seleccione el tramite a realizar: \n" +
                "Todos los cajeros realizan: Pagos de Servicios, Depositos y Cambio de Cheques\n" +
                "1) Credito Hipotecario\n" +
                "2) Credito Vehiculos \n" +
                "3) Pago de Servicios\n" +
                "4) Depositos\n" +
                "5) Cambio de Cheques\n" +
                "6) Regresar al Menu Principal\n");
                            seleccion = int.Parse(Console.ReadLine());

                            switch (seleccion)
                            {


                                case 1:
                                    cajero3.creditosHipotecarios();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 2:
                                    cajero3.creditosVehiculos();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 3:
                                    cajero3.pagoServicios();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 4:
                                    cajero3.deposito();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 5:
                                    cajero3.cambioCheque();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 6:
                                    bucle = 2;
                                    break;

                            }
                        } while (bucle == 1);
                        break;

                    case 4:
                        bucle = 2;
                        break;


                    default:
                        Console.WriteLine("Por favor ingrese una opcion valida con valores del 1 al 4");
                        Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                        bucle = int.Parse(Console.ReadLine());

                        break;



                }
            } while (bucle == 1);

        }

        //Menu de Cajero
        public void menuCajero()
        {

            do
            {
                Console.WriteLine("***** Bienvenido al Sistema de Banca en Linea para Cajeros *****\n" +
                "Por favor, seleccione el perfil que va a utilizar: \n" +
                "1) Cajero N°1 (Emision de Tarjetas)\n" +
                "2) Cajero N°2 (Emision de Chequeras y Bonos)\n" +
                "3) Cajero N°3 (Creditos)\n" +
                "4) Regresar al Menu Principal\n");
                seleccion = int.Parse(Console.ReadLine());

                switch (seleccion)
                {

                    case 1:
                        do
                        {
                            Console.WriteLine("***** Menu de Cajero 1 *****\n" +
                "Por favor, seleccione la accion a realizar: \n" +
                "1) Abrir Caja\n" +
                "2) Emision de Tarjetas\n" +
                "3) Pago de Servicios\n" +
                "4) Depositos\n" +
                "5) Cambio de Cheques\n" +
                "6) Cerrar Caja\n" +
                "7) Regresar al Menu Principal\n");
                            seleccion = int.Parse(Console.ReadLine());

                            switch (seleccion)
                            {


                                case 1:
                                    cajero1.abrirCaja();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 2:
                                    cajero1.emisionTarjetas();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 3:
                                    cajero1.pagoServicios();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 4:
                                    cajero1.deposito();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 5:
                                    cajero1.cambioCheque();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;


                                case 6:
                                    cajero1.cerrarCaja();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 7:
                                    bucle = 2;
                                    break;

                            }
                        } while (bucle == 1);

                        break;

                    case 2:
                        do
                        {
                            Console.WriteLine("***** Menu de Cajero 2 *****\n" +
                "Por favor, seleccione la accion a realizar: \n" +
                "1) Abrir Caja\n" +
                "2) Emision de Chequeras\n" +
                "3) Emision de Bonos\n" +
                "4) Pago de Servicios\n" +
                "5) Depositos\n" +
                "6) Cambio de Cheques\n" +
                "7) Cerrar Caja\n" +
                "8) Regresar al Menu Principal\n");
                            seleccion = int.Parse(Console.ReadLine());

                            switch (seleccion)
                            {


                                case 1:
                                    cajero2.abrirCaja();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 2:
                                    cajero2.emisionChequeras();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 3:
                                    cajero2.emisionBonos();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 4:
                                    cajero2.pagoServicios();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 5:
                                    cajero2.deposito();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;


                                case 6:
                                    cajero2.cambioCheque();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 7:
                                    cajero2.cerrarCaja();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 8:
                                    bucle = 2;
                                    break;

                            }
                        } while (bucle == 1);

                        break;

                    case 3:
                        do
                        {
                            Console.WriteLine("***** Menu de Cajero 3 *****\n" +
                "Por favor, seleccione la accion a realizar: \n" +
                "1) Abrir Caja\n" +
                "2) Credito Hipotecario\n" +
                "3) Credito Vehiculo\n" +
                "4) Pago de Servicios\n" +
                "5) Depositos\n" +
                "6) Cambio de Cheques\n" +
                "7) Cerrar Caja\n" +
                "8) Regresar al Menu Principal\n");
                            seleccion = int.Parse(Console.ReadLine());

                            switch (seleccion)
                            {


                                case 1:
                                    cajero3.abrirCaja();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 2:
                                    cajero3.creditosHipotecarios();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 3:
                                    cajero3.creditosVehiculos();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 4:
                                    cajero2.pagoServicios();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 5:
                                    cajero2.deposito();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;


                                case 6:
                                    cajero2.cambioCheque();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 7:
                                    cajero2.cerrarCaja();
                                    Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                                    bucle = int.Parse(Console.ReadLine());
                                    seleccion = 0;
                                    break;

                                case 8:
                                    bucle = 2;
                                    break;

                            }
                        } while (bucle == 1);
                        break;

                    case 4:
                        bucle = 2;
                        break;


                    default:
                        Console.WriteLine("Por favor ingrese una opcion valida con valores del 1 al 4");
                        Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                        bucle = int.Parse(Console.ReadLine());

                        break;



                }
            } while (bucle == 1);

        }


        //Metodo de Seleccion de Menu

        public void seleccionMenu()
        {

            do
            {
                Console.WriteLine("***** Bienvenido al Menu Principal del Sistema de Banca en Linea *****\n" +
                "Ingrese su tipo de Usuario:\n" +
                "1) Cajero\n" +
                "2) Cliente\n" +
                "3) Salir\n"
                );
                seleccion = int.Parse(Console.ReadLine());
                menu seleccionMenu = new menu();
                switch (seleccion)
                {

                    case 1:
                        seleccionMenu.menuCajero();
                        break;

                    case 2:
                        seleccionMenu.menuCliente();
                        break;

                    case 3:
                        bucle = 2;
                        break;

                    default:
                        Console.WriteLine("***Ingrese una opcion valida***");
                        Console.WriteLine("Desea continuar:\n 1) SI   2)NO");
                        bucle = int.Parse(Console.ReadLine());
                        break;


                }
            } while (bucle == 1);

        }
    }
}
