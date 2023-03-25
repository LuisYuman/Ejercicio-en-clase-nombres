void adivinar()
{
    const int oportunidades = 4;
    int NumeroCPU, NumeroUsuario;
    byte Intentos, BanderaControl;
    string linea;
    //generar numero del 1 al 20 unicamente
    Random ran = new Random();

    //do tarea, como generar numero del 1 al 20 sin que entre en el while
    //{

        NumeroCPU= Convert.ToInt32(ran.Next(0, 21));
        //Console.WriteLine(NumeroCPU);

    //} while (!((NumeroCPU >= 1) & (NumeroCPU <= 20)));

    //proceso
    Intentos = 1;
    BanderaControl= 0;

    do
    {
        Console.WriteLine("Estoy pensando en un numero, cual sera?");
        linea = Console.ReadLine();

        NumeroUsuario= Convert.ToInt32(linea);

        if (NumeroCPU == NumeroUsuario)
        {
            Console.WriteLine("Adivinaste");
            BanderaControl = 1;
        }
        else
        {
            if (NumeroUsuario > NumeroCPU)
            {
                Console.WriteLine("Te pasaste, numero grande");
            } else
            {
                Console.WriteLine("Te faltó, numero pequeño");
            }
            Intentos ++;
        }
    } while (((Intentos <= oportunidades) & (BanderaControl == 0)));

    if(BanderaControl ==0)
    {
        Console.WriteLine("El numero fue: " + NumeroCPU);
    }
}

void mayor_menor()
{
    int mayor = 0;
    int menor = 10;
    int numero = 0;
    Random random = new Random();
    for(int i = 0; i < 5; i++)
    {
        numero = random.Next(10);
        Console.WriteLine(numero);

        if(numero > mayor)
        {
            mayor = numero;
        }

        if(numero < menor)
        {
            menor = numero;
        }
    }
    Console.WriteLine("El mayor es: " + mayor);
    Console.WriteLine("El menor es: " + menor);
}


void catcher ()
{
    int cantidad = 0;
    Console.WriteLine("Ingrese una cantidad");
    try
    {
        cantidad = int.Parse(Console.ReadLine());
        //cantidad = cantidad / 0;
    }catch(FormatException fex)
    {
        Console.WriteLine("Ingreso mal el numero"+ fex.Message);
    }catch(Exception ex)
    {
        Console.WriteLine("Hay un error de otro tipo"+ ex.Message);
    }

    if (cantidad > 0)
    {
        Console.WriteLine("cantidad ingresada: " + cantidad);
    }
}

void ejemploarreglo()
{
    int rifa, rifa1;
    int[] numero = new int[7];

    int suma = 0;
     double prom;
    numero[0] = 45;
    numero[1] = 50;
    numero[2] = 68;
    numero[3] = 70;
    numero[4] = 86;
    numero[5] = 92;
    numero[6] = 69;

    int elementos = 10;

    string[] nombres = new string[elementos];
    nombres[0] = "Maria";
    nombres[1] = "Juan";
    nombres[2] = "Pedro";
    nombres[3] = "Luis";
    nombres[4] = "Fer";
    nombres[5] = "Vane";
    nombres[6] = "David";
    nombres[7] = "Ado";
    nombres[8] = "Aracely";
    nombres[9] = "Keylie";

    Random ran = new Random();
    rifa = Convert.ToInt32(ran.Next(0, 10));
    Random ran1 = new Random();
    rifa1 = Convert.ToInt32(ran1.Next(0, 10));

    if (rifa >= 0 & rifa <= 9)
    {
        Console.WriteLine("El ganador del primer premio esta en la posicion: " + nombres[rifa]);
    }
    if (rifa1 != rifa)
    {
        Console.WriteLine("El ganador del segundo premio esta en la posicion: " + nombres[rifa1]);
    }



   // for (int i = 0;i < elementos; i++)
    //{

        //suma = suma + numero[i];
        
       // Console.WriteLine(nombres[i]);
    //}
    //prom = suma / elementos;

    //Console.WriteLine("Sumatoria: "+ prom);

}
ejemploarreglo();