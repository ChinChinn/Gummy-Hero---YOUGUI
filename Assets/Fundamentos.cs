using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundamentos : MonoBehaviour
{
    public int numero = 10; //variable de entrada
    public float otroNumero = 5.0f; //variable con punto flotante 
    public bool state = false; //variable booleana
    public string nombre = "Ricardo";
    public string MiNombre = "Carlos";
    public string Apellido = "Polanco";

    void Start()
    {
        /*
        Debug.Log("Numero = " + numero);
        Debug.Log("Otro Numero = " + otroNumero);
        Debug.Log("State = " + state);
        Debug.Log("Mi nombre es: " + nombre.ToUpper());
        Debug.Log("Mi nombre es: " + nombre.ToLower());
        Debug.Log("La primera letra es: " + nombre[0]);
        Debug.Log(nombre + " tiene " + nombre.Length + " caracteres");
        Debug.Log("El ultimo caracter de " + nombre + " es: " + nombre[6]);
        Debug.Log("El ultimo caracter de " + nombre + " es: " + nombre[nombre.Length-1]);
        */

        Debug.Log("Mi nombre es: " + MiNombre.ToUpper());
        Debug.Log("Mi apellido es: " + Apellido.ToLower());
        Debug.Log("Mi nombre es: " + MiNombre);
        Debug.Log("Mi apellido es: " + Apellido);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
