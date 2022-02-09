using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{
    public int[] intArray;

    public int numEnemies = 1;
    private float uplim = 5f;
    private float xLim = 10.8f;
    private float lowlim = -4f;

    public GameObject spherenemy;

    public GameObject cubenemy;

    public GameObject cilindenemy;
    public Material[] matArray;

    public GameObject capsulenemy;
    private float growtime = 1.5f;
    private Vector3 growing = new Vector3(0.2f, 0.2f, 0.2f);


    public GameObject[] goArray;
    private float time = 2f;

    public string[] strArray;
    private float strtime = 0.5f;

    void Start()
    {
        //Ejercicio1();
        //Ejercicio2();
        //Ejercicio3();
        //Ejercicio4();

        //Ejercicio5();
        //Ejercicio6();

        //Ejercicio7();


        //StartCoroutine(Ejercicio8());
        //StartCoroutine(Ejercicio9());
        //StartCoroutine(Ejercicio10());

        //Ejercicio1_while();
        //Ejercicio2_while();
        //Ejercicio3_while();
        //Ejercicio4_while();
        //Ejercicio5_while();
        //Ejercicio6_while();
        //Ejercicio7_while();
        //StartCoroutine(Ejercicio8_while());
        //StartCoroutine(Ejercicio9_while());
        StartCoroutine(Ejercicio10_while());
    }

    void Update()
    {
        
    }

    private void Ejercicio1()
    {
        Debug.Log("Los números pares del 0 al 100 son los siguientes:");
        for (int i = 0; i<=100; i = i+2)
        {
            Debug.Log(i); //imprimimos por pantalla el numero que contiene la variable i, luego antes de la siguiente iteración le sumamos 2 y volvemos a imprimir i por pantalla
        }
    }

    private void Ejercicio1_while()
    {
        Debug.Log("Los números pares del 0 al 100 son los siguientes:");
        int counter = 0;
        while(counter<=100) //hasta que nuestro indice llegue al 100 continuaremos buscando los multiplos de 2
        {
            if(counter%2 == 0) //si encuentra un numero multiplo de 2 lo imprimirá por pantalla
            {
                Debug.Log($"{counter}");
            }
            counter++;
        }
    }

    private void Ejercicio2()
    {
        Debug.Log("Todas las mañanas Ned Flanders dice:");
        for (int i = 0; i<20; i++)
        {
            Debug.Log("Hola, hola vecinito"); //hacemos 20 iteraciones imprimiendo el mensaje deseado por pantalla
        }
    }

    private void Ejercicio2_while()
    {
        int counter = 0;
        Debug.Log("Todas las mañanas Ned saluda diciendo:");
        while (counter < 20) //estaremos repitiendo el bucle hasta que el valor del contador llegue a 20
        {
            Debug.Log("Hola, hola vecinito!"); //en cada iteración imprimiremos el mensaje por consola.
            counter++; //subiremos 1 el valor del contador para continuar contando cuantas iteraciones llevamos.
        }
    }
    private void Ejercicio3()
    {
        Debug.Log("los multiplos de 3 entre el 0 y el 500 son:");
        int divisor = 3;
        for(int i = 0; i<=500; i++)
        {
            if(i%divisor == 0) //revisamos los numeros del 0 al 500, y si un numero detecta que es multiplo de 3 lo imprime por consola.
            {
                Debug.Log(i);
            }
        }
    }

    private void Ejercicio3_while()
    {
        int counter = 0;
        Debug.Log("buscaremos todos los multiplos de 3 que se encuetran entre el 0 y el 500:");
        while (counter < 500) //nuestra busqueda continuará hasta que nuestro contador llegue a 500
        {
            if(counter%3 == 0) //en el recorrido si encuentra un numero multiplo de 3 lo imprimirá por consola
            {
                Debug.Log(counter);
            }
            counter++; //sumamos una unidad al contador para continuar la busqueda
        }
    }

    private void Ejercicio4()
    {
        Debug.Log("Los numeros de tu Array son:");
        foreach (int num in intArray)
        {
            Debug.Log(num); //recorremos cada elemento del array y los imprimimos uno a uno por pantalla
        }
    }

    private void Ejercicio4_while()
    {
        int counter = 0;
        Debug.Log("Los numeros de tu Array son:");
        while (counter<intArray.Length) //recorreremos el array entero con este bucle
        {
            Debug.Log($"{intArray[counter]}"); //en cada elemento del array imprimimos su contenido por consola.
            counter++; //sumamos 1 al contador para seguir recorriendo el array
        }
    }
    private Vector3 RandomSpawnPosition()
    {
        return new Vector3(Random.Range(-xLim, xLim), Random.Range(lowlim, uplim), 0); //generamos una posición random dentro de los límites de la cámara
    }

    private void Ejercicio5()
    {
        Debug.Log("Se han construido nuevas estrellas de la muerte!");
        for (int i = 1; i<=numEnemies; i++)
        {
            Vector3 spawnPosition = RandomSpawnPosition(); //generamos una posición random
            Instantiate(spherenemy, spawnPosition, spherenemy.transform.rotation); //instanciamos tantos enemigos como el valor de numEnemies en una posición random cada uno
        }
       
    }

    private void Ejercicio5_while()
    {
        Debug.Log("Se han construido nuevas estrellas de la muerte!");
        int counter = 0;
        while(counter<numEnemies) //mientras el contador no alcance el numero de enemigos que queremos spawnear continua el bucle
        {
            Vector3 spawnPosition = RandomSpawnPosition(); //generamos una posición random en cada repetición.
            Instantiate(spherenemy, spawnPosition, spherenemy.transform.rotation); //instanciamos al enemigo tantas veces como iteraciones tenga el bucle
            counter++; //subimos el contador 1 unidad para continuar contando el numero de enemigos
        }
    }

    private void Ejercicio6()
    {
        Debug.Log("Magmafico, ahora hay cubos de magma");
        for (int i = 1; i <=numEnemies; i++)
        {
            Vector3 enemyposition = new Vector3(i, i, 0); //generamos el vector de posición que se utilizará en cada iteración del bucle, utilizando la variable i
            Instantiate(cubenemy, enemyposition, cubenemy.transform.rotation);  //instanciamos un enemy en la posoción especificada justo antes.
        }
    }

    private void Ejercicio6_while()
    {
        Debug.Log("Magmafico, ahora hay cubos de magma");
        int counter = 0;
        while(counter<numEnemies) //mientras el contador no alcance el numero de enemigos que queremos spawnear continua el bucle
        {
            Vector3 enemyposiion = new Vector3(counter, counter, 0); //generamos la posición de cada enemy en base a la variable counter para que se generen los enemigos formando una diagonal.
            Instantiate(cubenemy, enemyposiion, cubenemy.transform.rotation); //generamos 1 enemy en cada repetición del bucle.
            counter++;
        }
    }

    private void Ejercicio7()
    {
        foreach (Material mat in matArray)
        {
            Vector3 spawnpos = RandomSpawnPosition();
            GameObject cilinder = Instantiate(cilindenemy, spawnpos, cilindenemy.transform.rotation); //generamos un cilindro el cual guardamos en una variable llamada cilinder momentaniamente
            cilinder.GetComponent<MeshRenderer>().material = mat; //accedemos al cilinder que acabamos de crear y en su componente mesh renderer le cambiamos el material por uno del array matArray
            
        }
    }

    private void Ejercicio7_while()
    {
        int counter = 0;
        while(counter<matArray.Length) //recorreremos el matArray 
        {
            Vector3 spawnpos = RandomSpawnPosition();
            GameObject cilinder = Instantiate(cilindenemy, spawnpos, cilindenemy.transform.rotation); //generamos un cilindro y lo guardamos momentaniamente en una variable cilinder
            cilinder.GetComponent<MeshRenderer>().material = matArray[counter]; //utilizando la variable accedemos al mesh renderer del cilindro que hemos generado para cambiar su material
            counter++;
        }
    }

    private IEnumerator Ejercicio8()
    {
        Debug.Log("Hacemos aparecer una capsula y que crezca cada 1.5 segundos un poco");
        GameObject capsulem = Instantiate(capsulenemy, Vector3.zero, capsulenemy.transform.rotation);

        for (int i = 0; i<10; i++) //10 iteraciones en este bucle
        {
            yield return new WaitForSeconds(growtime); //espera cierto tiempo en cada iteración antes de continuar
            Debug.Log("Growing");
            capsulem.transform.localScale += growing; //y le subimos la escala 0.2 en cada iteración
           
        }
    }

    private IEnumerator Ejercicio8_while()
    {
        int counter = 0;
        Debug.Log("Hacemos aparecer una capsula y que crezca cada 1.5 segundos");
        GameObject capsulem = Instantiate(capsulenemy, Vector3.zero, capsulenemy.transform.rotation);
        
        while(counter<10) //hasta que el contador llegue a 10
        {
            yield return new WaitForSeconds(growtime); //espera cierto tiempo en cada iteración antes de continuar
            Debug.Log("Growing, como Tom Hanks en Big");
            capsulem.transform.localScale += growing; //en cada iteración subirá su escala 0.2
            counter++; //sumamos 1 al contador
        }
    }

    private IEnumerator Ejercicio9()
    {
        Debug.Log("Vamos a hacer aparecer al equipo");
        for(int i = 0; i<goArray.Length; i++) //recorremos todos los elementos del array goArray
        {
            goArray[i].SetActive(true); //activamos el elemento en el que nos encontramos del array
            Debug.Log($"tenemos a {goArray[i]}");
            yield return new WaitForSeconds(time); //esperamos cierto tiempo antes de realizar la siguiente iteración
        }
    }

    private IEnumerator Ejercicio9_while()
    {
        Debug.Log("Vamos a hacer aparecer al equipo");
        int counter = 0;
        while(counter<goArray.Length) //recorrido de todos los elementos del array goArray
        {
            goArray[counter].SetActive(true); //activamos el elemento en el que nos encontramos del array
            Debug.Log($"tenemos a {goArray[counter]}");
            yield return new WaitForSeconds(time); //esperamos cierto tiempo antes de realizar la siguiente iteración
            counter++;
        }
    }

    private IEnumerator Ejercicio10()
    {
        Debug.Log("Se necesitan 10 palabras para controlar al soldado de invierno");
        for (int i = 0; i<strArray.Length; i++) //recorriendo el array de strings de principio a fin
        {
            Debug.Log(strArray[i]); //imprimimos cada array por pantalla
            yield return new WaitForSeconds(strtime * i); //en cada iteración aumentamos el tiempo de espera entre cada string impreso por pantalla.
        }
        Debug.Log("Informe de misión 16 de diciembre de 1991");
    }

    private IEnumerator Ejercicio10_while()
    {
        int counter = 0;
        Debug.Log("Se necesitan 10 palabras para controlar al soldado de invierno");
        while(counter<strArray.Length) //recorriendo el array de strings de principio a fin
        {
            Debug.Log(strArray[counter]); //imprimimos cada array por pantalla
            yield return new WaitForSeconds(strtime * counter); //en cada iteración aumentamos el tiempo de espera entre cada string impreso por pantalla.
            counter++;
        }
        Debug.Log("Informe de misión 16 de diciembre de 1991");
    }

}
