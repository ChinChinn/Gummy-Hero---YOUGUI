using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fundamentos : MonoBehaviour
{
     public int numero = 0; // Soy una variable entera
     public float otroNumero = 5.0f; //Soy una varaible llamada float.

    public bool state = false; //Soy una variable booleana.

    public string nombre = "PerkZ";
    // Start is called before the first frame update
    void Start()
    {
       

         Debug.Log("Numero " + numero);
         Debug.Log("Otro Numero " + otroNumero);
         Debug.Log("State "+  state);
         Debug.Log("Mi nombre es: " + nombre.ToUpper());
         Debug.Log("Mi nombre es: " + nombre.ToLower());
         Debug.Log("La primera letra es: " + nombre[0]);
         Debug.Log(nombre + " tiene " + nombre.Length + " caracteres ");
         Debug.Log("El ultimo caracter de " + nombre + " es " +  nombre.Substring(nombre.Length - 1, 1));
        // [nombre.length-1] mas facil.


    }

    // Update is called once per frame
    void Update()
    {
       
    }
}