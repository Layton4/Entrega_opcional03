using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bucles : MonoBehaviour
{
    public int[] intArray;
   
    void Start()
    {
        //Ejercicio1();
        //Ejercicio2();
        //Ejercicio3();
        Ejercicio4();
    }

    void Update()
    {
        
    }

    private void Ejercicio1()
    {
        Debug.Log("Los números pares del 0 al 100 son los siguientes:");
        for (int i = 0; i<=100; i = i+2)
        {
            Debug.Log(i);
        }
    }

    private void Ejercicio2()
    {
        Debug.Log("Todas las mañanas Ned Flanders dice:");
        for (int i = 0; i<20; i++)
        {
            Debug.Log("Hola, hola vecinito");
        }
    }

    private void Ejercicio3()
    {
        Debug.Log("los multiplos de 3 entre el 0 y el 500 son:");
        int divisor = 3;
        for(int i = 0; i<=500; i++)
        {
            if(i%divisor == 0)
            {
                Debug.Log(i);
            }
        }
    }

    private void Ejercicio4()
    {
        foreach(int num in intArray)
        {
            Debug.Log("Los numeros de tu Array son:");
            Debug.Log(num);
        }
    }


}
