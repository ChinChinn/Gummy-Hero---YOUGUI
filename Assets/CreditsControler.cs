using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreditsControler : MonoBehaviour
{
    public CanvasGroup canvasGroup;

    public Animator animator;

    StartScreenControler menu;

    void Start(){
        canvasGroup.alpha = 0;
        animator.SetBool("Open", false);
        menu = GameObject.FindGameObjectWithTag("Menu").GetComponent<StartScreenControler>();
    }

    public void showCredits(){
        canvasGroup.alpha = 1;
        animator.SetBool("Open", true);
        StartCoroutine("esperarCreditos");
    }

    IEnumerator esperarCreditos(){
        yield return new WaitForSeconds(5);
        animator.SetBool("Open", false);
        canvasGroup.alpha = 0;
        menu.setAnimatorValue(true);
    }
}   
