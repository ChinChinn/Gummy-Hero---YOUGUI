using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitButton : MonoBehaviour
{
    public  void exitButtonPressed(){
        StartCoroutine("ExitGame");
    }
  IEnumerator ExitGame(){
      yield return new WaitForSeconds(2);
      Application.Quit();
      Debug.Log("Salir de la aplicacion");
  }
}
