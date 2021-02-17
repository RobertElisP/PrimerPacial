using System;

namespace Examen_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;
            string answer;
            int c1000;
            int c500;
            int c200;
            int c100;
            float CAN;
            int operacion;
            int milesDispo = 18;
            int quinitoDispo = 19;
            int docientoDispo = 23;
            int cienDispo = 50;
            string TipoBanco;
            string Monto;
            c1000 = 0;
            c500 = 0;
            c200 = 0;
            c100 = 0;


            while (repeat){

                Console.Clear();
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine("Bienvenido, Favor de llenar el formulario");
                Console.WriteLine("");
                Console.WriteLine("Tipo de Banco: ");
                Console.WriteLine("A) FDP INVERSMENTS ");
                Console.WriteLine("B) Otros");
                Console.WriteLine("C) Salir");
                TipoBanco = Console.ReadLine().ToUpper();

                if (TipoBanco == "A")
                {
                    Console.WriteLine("Nota: Recuerde que su limite diario es de 2000$ pesos dominicanos");
                    Console.WriteLine("");
                    Console.WriteLine("Escriba el monto retirar: ");
                    Monto = Console.ReadLine();
                    CAN = float.Parse(Monto);

                    if (CAN <= 20000)
                    {
                        if ((CAN <= 100) && c200 <= 200)
                        {
                            c100 = ((int)CAN / 100);

                            cienDispo = cienDispo - c100;
                            if (cienDispo != 0)
                            {
                                Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                Console.WriteLine("Solo tiene {0} de 100 disponible", cienDispo);

                            }
                            else
                            {
                                Console.WriteLine("Actualmente no tiene papeletas de 100 disponible");
                            }

                        }

                        if ((CAN >= 200) && CAN < 500)
                        {
                            c200 = ((int)CAN / 200);


                            int temp = c200 * 200;

                            operacion = int.Parse(Monto) - temp;
                            docientoDispo = docientoDispo - c200;
                            if (docientoDispo != 0)
                            {
                                Console.WriteLine("Usted se le ha facilitado " + c200 + " de 200");
                                if (cienDispo != 0)
                                {
                                    if (operacion > 99 && operacion == 100 && operacion < 101)
                                    {
                                        c100 = ((int)operacion / 100);
                                        Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Actualmente no tiene papeletas de 100 disponible");
                                }
                            }
                            else
                            {
                                Console.WriteLine("Actualmente no tiene papeletas de 200 disponible");
                            }

                        }

                        if ((CAN >= 500) && CAN <= 999)
                        {
                            c500 = ((int)CAN / 500);

                            quinitoDispo = quinitoDispo - c500;

                            if (quinitoDispo != 0)
                            {
                                int temp = c500 * 500;

                                operacion = int.Parse(Monto) - temp;


                                Console.WriteLine("Usted se le ha facilitado " + c500 + " de 500");

                                if (operacion == 100)
                                {
                                    c100 = ((int)operacion / 100);
                                    cienDispo = cienDispo - c100;
                                    if (cienDispo != 0)
                                    {
                                        Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Usted no cuenta con papeletas de 100 disponible");
                                    }

                                }


                                if (operacion >= 200 && operacion < 500)
                                {
                                    c200 = ((int)operacion / 200);
                                    docientoDispo = docientoDispo - c200;
                                    if (docientoDispo != 0)
                                    {
                                        Console.WriteLine("Usted se le ha facilitado " + c200 + " de 200");
                                        int temp2 = (c200 * 200) + temp;
                                        int operacion2 = int.Parse(Monto) - temp2;
                                        if (operacion2 > 99 && operacion2 == 100 && operacion2 < 101)
                                        {
                                            c100 = ((int)operacion2 / 100);
                                            Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Usted no cuenta con papeletas de 200 disponible");
                                    }
                                }

                            }
                            else
                            {
                                Console.WriteLine("Actualmente no tiene papeletas de 500 disponible");
                            }
                        }

                        if ((CAN >= 1000) && (CAN <= 20000))
                        {
                            c1000 = ((int)CAN / 1000);
                            milesDispo = milesDispo - c1000;
                            if (milesDispo != 0)
                            {
                                Console.WriteLine("Usted se le ha facilitado " + c1000 + " de 1000");
                                int temp = c1000 * 1000;
                                operacion = int.Parse(Monto) - temp;


                                if (operacion == 100)
                                {
                                    c100 = ((int)operacion / 100);
                                    cienDispo = cienDispo - c100;
                                    if (cienDispo != 0)
                                    {
                                        Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Usted no cuenta con papeletas de 100 disponible");
                                    }

                                }

                                if (operacion >= 200 && operacion < 500)
                                {
                                    c200 = ((int)operacion / 200);
                                    docientoDispo = docientoDispo - c200;
                                    if (docientoDispo != 0)
                                    {
                                        Console.WriteLine("Usted se le ha facilitado " + c200 + " de 200");
                                        int temp2 = (c200 * 200) + temp;
                                        int operacion2 = int.Parse(Monto) - temp2;
                                        if (operacion2 > 99 && operacion2 == 100 && operacion2 < 101)
                                        {
                                            c100 = ((int)operacion2 / 100);
                                            Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("Usted no cuenta con papeletas de 200 disponible");
                                    }
                                }
                                if (operacion >= 500 && operacion < 999)
                                {
                                    c500 = ((int)operacion / 500);
                                    quinitoDispo = quinitoDispo - c500;
                                    if (quinitoDispo != 0)
                                    {
                                        Console.WriteLine("Usted se le ha facilitado " + c500 + " de 500");
                                        int temp2 = (c500 * 500) + temp;
                                        int operacion2 = int.Parse(Monto) - temp2;

                                        if (operacion2 >= 200 & operacion2 < 500)
                                        {
                                            c200 = ((int)operacion2 / 200);
                                            docientoDispo = docientoDispo - c200;
                                            if (docientoDispo != 0)
                                            {
                                                Console.WriteLine("Usted se le ha facilitado " + c200 + " de 200");

                                                int temp3 = (c200 * 200) - operacion2;
                                                var t = Math.Abs(temp3);


                                                if (t > 99 && t == 100 && t < 101)
                                                {
                                                    c100 = ((int)t / 100);
                                                    Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                                }
                                            }
                                            else
                                            {
                                                Console.WriteLine("Actualmente no tiene papeletas de 200 disponible");
                                            }
                                        }

                                        if (operacion2 > 99 && operacion2 == 100 && operacion2 < 101)
                                        {
                                            c100 = ((int)operacion2 / 100);
                                            Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                        }

                                    }
                                    else
                                    {
                                        Console.WriteLine("Actualmente no tiene papeletas de 500 disponible");
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Actualmente no tiene papeletas de 1000 disponible");
                            }
                        }

                        Console.WriteLine("");
                        Console.WriteLine("Desea sacar otro monto? ");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "S")
                        {

                        }
                        else if (answer == "N")
                        {
                            repeat = false;
                        }
                    }
                    else {
                        Console.WriteLine("Usted No puede Solicitar mas de 20000");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "S")
                        {

                        }
                        else if (answer == "N")
                        {
                            repeat = false;
                        }
                    }

                }
                else if (TipoBanco == "B")
                {

                    Console.WriteLine("Nota: Recuerde que su limite diario es de 2000$ pesos dominicanos");
                    Console.WriteLine("");
                    Console.WriteLine("Escriba el monto retirar: ");
                    Monto = Console.ReadLine();
                    CAN = float.Parse(Monto);

                    if (CAN <= 10000)
                    {
                        if ((CAN <= 100) && c200 <= 200)
                        {
                            c100 = ((int)CAN / 100);
                            Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                        }

                        if ((CAN >= 200) && CAN < 500)
                        {
                            c200 = ((int)CAN / 200);


                            int temp = c200 * 200;

                            operacion = int.Parse(Monto) - temp;

                            if (operacion > 99 && operacion == 100 && operacion < 101)
                            {
                                c100 = ((int)operacion / 100);
                                Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                            }

                            Console.WriteLine("Usted se le ha facilitado " + c200 + " de 200");
                        }

                        if ((CAN >= 500) && CAN <= 999)
                        {
                            c500 = ((int)CAN / 500);


                            int temp = c500 * 500;

                            operacion = int.Parse(Monto) - temp;
                            Console.WriteLine("Usted se le ha facilitado " + c500 + " de 500");

                            if (operacion == 100)
                            {
                                c100 = ((int)operacion / 100);
                                Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                            }
                            if (operacion >= 200 && operacion < 500)
                            {
                                c200 = ((int)operacion / 200);
                                Console.WriteLine("Usted se le ha facilitado " + c200 + " de 200");
                                int temp2 = (c200 * 200) + temp;
                                int operacion2 = int.Parse(Monto) - temp2;
                                if (operacion2 > 99 && operacion2 == 100 && operacion2 < 101)
                                {
                                    c100 = ((int)operacion2 / 100);
                                    Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                }
                            }



                        }


                        if ((CAN >= 1000) && (CAN <= 10000))
                        {
                            c1000 = ((int)CAN / 1000);
                            int temp = c1000 * 1000;
                            operacion = int.Parse(Monto) - temp;
                            if (operacion == 100)
                            {
                                c100 = ((int)operacion / 100);
                                Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                            }

                            if (operacion >= 200 && operacion < 500)
                            {
                                c200 = ((int)operacion / 200);
                                Console.WriteLine("Usted se le ha facilitado " + c200 + " de 200");
                                int temp2 = (c200 * 200) + temp;
                                int operacion2 = int.Parse(Monto) - temp2;
                                if (operacion2 > 99 && operacion2 == 100 && operacion2 < 101)
                                {
                                    c100 = ((int)operacion2 / 100);
                                    Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                }
                            }
                            if (operacion >= 500 && operacion < 999)
                            {
                                c500 = ((int)operacion / 500);
                                Console.WriteLine("Usted se le ha facilitado " + c500 + " de 500");
                                int temp2 = (c500 * 500) + temp;
                                int operacion2 = int.Parse(Monto) - temp2;

                                if (operacion2 >= 200 & operacion2 < 500)
                                {
                                    c200 = ((int)operacion2 / 200);
                                    Console.WriteLine("Usted se le ha facilitado " + c200 + " de 200");

                                    int temp3 = (c200 * 200) - operacion2;
                                    var t = Math.Abs(temp3);


                                    if (t > 99 && t == 100 && t < 101)
                                    {
                                        c100 = ((int)t / 100);
                                        Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                    }
                                }

                                if (operacion2 > 99 && operacion2 == 100 && operacion2 < 101)
                                {
                                    c100 = ((int)operacion2 / 100);
                                    Console.WriteLine("Usted se le ha facilitado " + c100 + " de 100");
                                }
                            }
                            Console.WriteLine("Usted se le ha facilitado " + c1000 + " de 1000");

                        }
                        Console.WriteLine("");
                        Console.WriteLine("Desea sacar otro monto? ");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "S")
                        {

                        }
                        else if (answer == "N")
                        {
                            repeat = false;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Usted No puede Solicitar mas de 1000");
                        answer = Console.ReadLine().ToUpper();
                        if (answer == "S")
                        {

                        }
                        else if (answer == "N")
                        {
                            repeat = false;
                        }
                    }

                }
                else
                {

                }

            }

            Console.ReadKey();




        }
    }
}
