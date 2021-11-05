using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Challenge : MonoBehaviour
{
    // Start is called before the first frame update
    public string nombre = "Lulu";
    public string apellido = "Vazquez";

    
  

    void Start()
    {
        int i = 7;
        int a = 4;
        int c = a + i;


        Debug.Log("Mi nombre es: " + nombre.ToUpper());
        Debug.Log("Mi apellido es: " + apellido.ToLower());

        Debug.Log("Mis iniciales de mi nombre son: " + nombre[0].ToString().ToUpper());
        Debug.Log("Mis iniciales de mi apellido son: " + apellido[0].ToString().ToUpper());

         Debug.Log(nombre + " tiene " + nombre.Length + " caracteres ");
         Debug.Log(apellido + " tiene " + apellido.Length + " caracteres ");
         Debug.Log("Ambos tienen en total " + c );            


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
