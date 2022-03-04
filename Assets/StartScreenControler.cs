using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartScreenControler : MonoBehaviour
{
    public CanvasGroup canvasGroup;
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        canvasGroup.alpha = 0;
        animator.SetBool("Open", true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setAnimatorValue(bool status){
        animator.SetBool("Open", status);
    }
}
