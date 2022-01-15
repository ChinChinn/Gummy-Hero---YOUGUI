using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundamentos : MonoBehaviour
{
    public int numero = 10; //Soy una variable entera
    public float otroNumero = 5.0f; //Soy una variable con punto flotante
    public bool state = false; //Soy una variable booleana

    public string nombre = "RicaRdo";


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Numero = " + numero);
        Debug.Log("Otro Numero = " + otroNumero);
        Debug.Log("State = " + state);
        Debug.Log("Mi nombre es: " + nombre.ToUpper());
        Debug.Log("Mi nombre es: " + nombre.ToLower());
        Debug.Log("La primera letra es: " + nombre[0]);
        Debug.Log(nombre + " tiene " + nombre.Length + " caracteres");
        Debug.Log("El ultimo caracter de " + nombre + " es: " + nombre[6]);
        Debug.Log("El ultimo caracter de " + nombre + " es: " + nombre[nombre.Length-1 ]);
        Debug.Log(nombre[0].ToString().ToUpper());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}


/*
Crear un nuevo script que se llame Challenge

* Crear una variable para su nombre
* Crear una variable para su apellido

* Mostrar su nombre en mayusculas
* Mostrar su apellido en minusculas

* Mostrar sus iniciales en mayusculas
* Mostrar la cantidad de letras de su nombre
* Mostrar la cantidad de letras de su apellido
* Mostrar la cantidad de letras de su nombre y apellido juntos

*/