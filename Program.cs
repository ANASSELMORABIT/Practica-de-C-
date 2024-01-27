internal class Program
{
    private static void Main(string[] args)
    {
        // /*Tarea1*/
        int [][] FILAO ={
            new int [] {1,1,1},
            new int [] {1,0,1,1},
            new int [] {0,0,1,1,1},
            new int [] {1,1,1,1,1},
            new int [] {0,1,0,1,1}
        };
        int Total_vendidas = 0;
        int Total_disponibles = 0;
        for (int i=0;i<5;i++){
            for (int j =0;j< FILAO[i].Length;j++){
               if (FILAO[i][j]==1){
                   Total_vendidas++;
               }
               else if (FILAO[i][j]==0){
                   Total_disponibles++;
               }
            } 
        }
        Console.WriteLine("Total vendidas {0} Total disponibles {1}",Total_vendidas,Total_disponibles);
        /*Tarea2*/
        string [][] hoteles = {
            new string[] { "O", "X", "X", "X", "X" },
            new string[] { "X", "X", "X", "O", "X" },
            new string[] { "X", "X", "X", "X", "X" },
            new string[] { "X", "O", "X", "X", "X" },
            new string[] { "X", "X", "X", "X", "X" },
            new string[] { "O", "X", "X", "X", "X" },
            new string[] { "X", "O", "X", "X" },
            new string[] { "X", "X", "X" }
        };
        int opcion;
        int planta;
        int habitacion;
        Console.WriteLine(" la opcion (1) para mostrar las habitaciones disponibles.\n la opcion (2) para hacer una reserva.\n la opcion (3) para borrar una reserva.\n la opcion (4) para cerrar el programa");
        do{
            Console.WriteLine("Ingresa una opcion");
            opcion = Convert.ToInt32(Console.ReadLine());
        }while(opcion<1 || opcion>4); /* para que el usuario ingresa un valor valida*/
        switch (opcion){
            case 1:
                /*habitaciónes disponibles*/
                Console.WriteLine("Habitaciónes disponibles");
                for (int i=0;i<8;i++){
                    for (int j=0;j< hoteles[i].Length;j++){
                        if (hoteles[i][j]=="O"){
                        Console.WriteLine("La planta {0} la habitación {1} se encuentra disponible",i+1,j+1);
                        }
                    }
                }
                break;
            case 2:
                /*Realizar reserv*/
                Console.WriteLine("Ingresa el numero de planta y de habitación que quieres reservar");
                do{
                    Console.WriteLine("Ingresa una planta");
                    planta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa una habitación");
                    habitacion = Convert.ToInt32(Console.ReadLine());
                }while(planta<1 || planta>8 ||  habitacion>hoteles[planta-1].Length || habitacion<1 || hoteles[planta-1][habitacion-1]=="X");/* Para que el usuario ingrese un valor correcto*/
                Console.WriteLine("La habitación {0} de la planta {1} ha sido reservada",habitacion,planta);
                hoteles[planta-1][habitacion-1]="X"; /* para hacer una reserva*/
                break;
            case 3: /*Modificar o borrar una habitación*/
                Console.WriteLine("Ingresa el numero de planta y de habitación que quieres  borrar");
                do{
                    Console.WriteLine("Ingresa una planta");
                    planta = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Ingresa una habitación");
                    habitacion = Convert.ToInt32(Console.ReadLine());
                }while(planta<1 || planta>8 ||  habitacion>hoteles[planta-1].Length || habitacion<1 || hoteles[planta-1][habitacion-1]=="O");/* Para que el usuario ingrese un valor correcto y para que la habitación no este disponible porque borramos solo las reservas de las habitaciones ocupadas*/
                hoteles[planta-1][habitacion-1]="O"; /* para borrar una reserva*/
                break;
            default:
                break;
        }
        /*Tarea3*/
        int[,] ventas = {
            { 10, 5, 8, 12 },
            { 7, 15, 20, 10 },
            { 5, 3, 6, 8 },
            { 12, 8, 10, 18 },
            { 6, 10, 15, 7 }
        };
        int [] Total_sections = new int[5];
        int Total=0;
        int i,j;
        for ( i =0; i<5; i++){
            for ( j =0; j<4; j++){
                Total += ventas[i,j];
            }
            Total_sections[i]=Total;
        }
        Console.WriteLine("Las ventas totales por sección son:");
        for (i=0; i<5; i++){
            Console.WriteLine("La sección {0} tiene un total de {1} ",i+1,Total_sections[i]);
        }
        /*Tarea4*/
        bool[,] asistencia = {
            { true, false, true, true, false },
            { true, true, true, true, true },
            { false, false, true, true, false },
            { true, true, true, false, true },
            { true, false, true, false, true }
        };
        int estudiante,dia;
        do{
            Console.WriteLine("Ingresa el numero de estudiante");
            estudiante = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingresa el dia");
            dia = Convert.ToInt32(Console.ReadLine());
        } while(estudiante<1 || estudiante>5 || dia<1 || dia>5);
        if(asistencia[estudiante-1,dia-1] == true){
            Console.WriteLine("el estudiante {0} asistio el dia {1}",estudiante,dia);
        }else{
            Console.WriteLine("el estudiante {0} no asistio el dia {1}",estudiante,dia);   
        }
        /*Tarea5*/
        int[][] matriz = {
        new int[] { 1, 2, 3 },
        new int[] { 4,5},
        new int[] { 5, 6, 7}
        };
        
        int [] sumar_columnas = new int [3];
        int [] sumar_filas = new int [3]; /* esto es para la suma de las filas y columnas*/
        int sumar_c=0; /* esto es para la suma de las columnas*/
        int sumar_f=0; /* esto es para la suma de las filas*/
        int i,j,L;
        int K=0; /*este variable es para la suma de las columnas*/
        for(j=0;j<3;j++){
            for(i=0;i<3;i++){
                if(K<=matriz[i].Length-1){ /*este condición es para verificar que no se salga del arreglo de la columna , y el -1 es para que podemos hacer la suma*/
                    sumar_c+=matriz[i][K]; /* por ejemplo cuando el K=0 y la i=0,este significa que matriz[0].Length=3, y el K=0, la suma de la columna es la suma de todos los elementos de la columna 0*/
                }
            }
            sumar_columnas[K]=sumar_c;
            sumar_c=0;
            K++; /* este parte para pasar a la siguiente columna*/
            for(L=0;L<matriz[j].Length;L++){ /* este bucle es para la suma de las filas*/
                    sumar_f+=matriz[j][L];
                }
            sumar_filas[j]=sumar_f;
            sumar_f=0;
        }
        for(i=0;i<3;i++){
            Console.WriteLine("La suma de la columna {0} es {1}",i+1,sumar_columnas[i]);
            Console.WriteLine("La suma de la fila {0} es {1}",i+1,sumar_filas[i]);
        }

    }
}