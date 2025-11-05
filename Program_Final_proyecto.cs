//pido si se queiren meter al club, lo guardo en una funcion 
Console.WriteLine("Quieres formar parte de nuestro club de voley  (true) o (false)");
bool formar = Convert.ToBoolean(Console.ReadLine());

//hago un if que si dices que si te lleve a un procedimiento  y si dices que no, no te de opcion de nada
if (formar == true)
{
    edad();
}
else
{
    Console.WriteLine("Da igual, tu te lo peirdes :) ");
}



//creo el procedimiento, depende de la edad que tengas te dira algo
void edad()
{
    Console.WriteLine("¿Cuantos años tienes?");
    int años = Convert.ToInt32(Console.ReadLine());

    //creo una variable para que se llame respuesta que guarde un caracter
    //ya que despues lo  igualoo a nivel y asi la respuesta de nivel valdra ese carcater si pones a respeystanivel sera a
    char respuestaNivel;
    if (años <= 11 && años > 4)
    {
        Console.WriteLine("Eres infantil");
        respuestaNivel = nivel();

    }
    else if (años <= 15 && años > 11)
    {
        Console.WriteLine("Eres cadete");
        respuestaNivel = nivel();
    }
    else if (años < 19 && años > 15)
    {
        Console.WriteLine("Eres juvenil");
        respuestaNivel = nivel();
    }
    else if (años >= 19)
    {
        Console.WriteLine("Eres senior");
        respuestaNivel = nivel();
    }
    else

    {
        while (años < 4)
        {
            Console.WriteLine("No te puedes unir eres muy pequeño");
            break;
        }
        return;
    }

//he creado un menu con un sitch y dentro tiene distintos tipos de procedimeintos que más abajo estan creados
    switch (respuestaNivel)
    {
        case 'a':
            casoA();
            break;

        case 'b':
            casoB();
            break;

        case 'c':
            casoC();
            break;

    }
    

    //he creado una funcion que te pida el nivel así no lo tengo que poner en todo
    char nivel()
    {
        Console.WriteLine("¿Que nivel crees que tienes?");
        Console.WriteLine("a = alto");
        Console.WriteLine("b = medio");
        Console.WriteLine("c = bajo");
        char respuestaNivel = Convert.ToChar(Console.ReadLine());
        return respuestaNivel;
    }
}


// he creado un void para el primer caso
void casoA ()
{
    Console.WriteLine("Tu nivel es alto");
    Console.WriteLine("¿Podrias entrenar los Martes y Jueves de 20:00 a 21:30? s/n");
    char RespuestaHorartio = Convert.ToChar(Console.ReadLine());

// if para la repsuesta de si puede esos horarios
if (RespuestaHorartio == 's')
        {
         Console.WriteLine("¿Te gustaria tener vestuatio y casilla reservada? s/n");
        char vetuarioalto = Convert.ToChar(Console.ReadLine());

        //if para la respuesta si quiere vestuarios
        if (vetuarioalto == 's')
        {
           
                Console.WriteLine("Tu vestuario es premium, y la taquilla te sale gratis");
            Console.WriteLine("Introduce tus datos:");
            //creo una variable que signifique no, por que si luego quiero usarla me pondra que no existe en el contexto actual
            char respuestaCorrectos = 'n';
            do
            {

                Console.WriteLine("DNI:");
                string dnialto = Console.ReadLine();

                Console.WriteLine("Numero de tarjeta:");
                string tarjetaalto = Console.ReadLine();

                Console.Write("Tu DNI es " + dnialto);
                Console.Write(" y tu tarjeta " + tarjetaalto);

                Console.WriteLine(" ¿son correctos s/n?");
                // pongo que la respuesta de antes signifique lo que añadamos
                respuestaCorrectos = Convert.ToChar(Console.ReadLine());

            }

            //te va a pedir tus datos hasta que no pongas que si
            //he puesto fuera del do la variable que valga n así hace esto si no pones s solo n
            while (respuestaCorrectos != 's');    
              Console.WriteLine(" Perfecto ya estas apuntada/o");

        }

  //else para la respuesta si quiere vestuarios
        else
        {
            Console.WriteLine("Valee, da igual, entrenas los Martes y Jueves de 20:00 a 21:30 ");

        }
    }
// else para la repsuesta de si puede esos horarios, si no puede saldra esto
    else
        {
        Console.WriteLine("No tenemos otros horarios, otra vez sera.");
    } 
    }
//he creado una funcion en el caso B, al ser nivel medio te pide pagar


void casoB ()
//he reutilizado el mismo codigo de antes pero cambiando un par de cosas
{
    Console.WriteLine("Tu nivel es medio");
    Console.WriteLine("¿Podrias entrenar los martes y Jueves de 18:00 a 20:00? s/n");
    char RespuestaHorartio = Convert.ToChar(Console.ReadLine());

    // if para la repsuesta de si puede esos horarios
    if (RespuestaHorartio == 's')
    {
        Console.WriteLine("¿Te gustaria tener vestuatio y casilla reservada? (te costaria 10€ al ser nivel medio) s/n");
        char vetuarioalto = Convert.ToChar(Console.ReadLine());

        //if para la respuesta si quiere vestuarios
        if (vetuarioalto == 's')
        {
            //le pido los datos pero antes de eso al ser mediano le pido dinero
            Console.WriteLine("Tu vestuario es medio, y la taquilla te sale a 10€");
            Console.WriteLine("Introduce tus datos:");
            //creo una variable que signifique no, por que si luego quiero usarla me pondra que no existe en el contexto actual
            char respuestaCorrectos = 'n';
            do
            {

                Console.WriteLine("DNI:");
                string dniC = Console.ReadLine();

                Console.WriteLine("Numero de tarjeta:");
                string tarjetaC = Console.ReadLine();

                Console.Write("Tu DNI es " + dniC);
                Console.Write(" y tu tarjeta " + tarjetaC);

                Console.WriteLine(" ¿son correctos s/n?");
                // pongo que la respuesta de antes signifique lo que añadamos
                respuestaCorrectos = Convert.ToChar(Console.ReadLine());

            }

            //te va a pedir tus datos hasta que no pongas que si
            //he puesto fuera del do la variable que valga n así hace esto si no pones s solo n
            while (respuestaCorrectos != 's');
            Console.WriteLine(" Perfecto ya estas apuntada/o");

        }

        //else para la respuesta si quiere vestuarios
        else
        {
            Console.WriteLine("Valee, da igual, entrenas los Martes y Jueves de de 18:00 a 20:00 ");

        }
    }
    // else para la repsuesta de si puede esos horarios, si no puede saldra esto
    else
    {
        Console.WriteLine("No tenemos otros horarios, otra vez sera.");
    }
}


// y por ultimo  vuelvo a reutilizar el msimo codigo de antes pero cambiando todo a nivel bajo
void casoC ()
{
    //he reutilizado el mismo codigo de antes pero cambiando un par de cosas
    {
        Console.WriteLine("Tu nivel es bajo");
        Console.WriteLine("¿Podrias entrenar los martes y Jueves de 16:00 a 18:00? s/n");
        char RespuestaHorartio = Convert.ToChar(Console.ReadLine());

        // if para la repsuesta de si puede esos horarios
        if (RespuestaHorartio == 's')
        {
            Console.WriteLine("¿Te gustaria tener vestuatio y casilla reservada? (te costaria 20€ al ser nivel bajo) s/n");
            char vetuarioalto = Convert.ToChar(Console.ReadLine());

            //if para la respuesta si quiere vestuarios
            if (vetuarioalto == 's')
            {
                //le pido los datos pero antes de eso al ser mediano le pido dinero
                Console.WriteLine("Tu vestuario es bajo, y la taquilla te sale a 20€");
                Console.WriteLine("Introduce tus datos:");
                //creo una variable que signifique no, por que si luego quiero usarla me pondra que no existe en el contexto actual
                char respuestaCorrectos = 'n';
                do
                {

                    Console.WriteLine("DNI:");
                    string dniB = Console.ReadLine();

                    Console.WriteLine("Numero de tarjeta:");
                    string tarjetaB = Console.ReadLine();

                    Console.Write("Tu DNI es " + dniB);
                    Console.Write(" y tu tarjeta " + tarjetaB);

                    Console.WriteLine(" ¿son correctos s/n?");
                    // pongo que la respuesta de antes signifique lo que añadamos
                    respuestaCorrectos = Convert.ToChar(Console.ReadLine());

                }

                //te va a pedir tus datos hasta que no pongas que si
                //he puesto fuera del do la variable que valga n así hace esto si no pones s solo n
                while (respuestaCorrectos != 's');
                Console.WriteLine(" Perfecto ya estas apuntada/o");

            }

            //else para la respuesta si quiere vestuarios, al decir que no te dice directamemte los horarios que entrenas
            else
            {
                Console.WriteLine("Valee, da igual, entrenas los Martes y e 16:00 a 18:00 ");

            }
        }
        // else para la repsuesta de si puede esos horarios, si no puede saldra esto
        else
        {
            Console.WriteLine("No tenemos otros horarios, otra vez sera.");
        }
    }
}



  
