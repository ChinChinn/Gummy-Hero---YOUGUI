using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameScreenControler : MonoBehaviour
{
    // Start is called before the first frame update

    public Animator animator;
    void Start()
    {
        animator.SetBool("Open", false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void setAnimatorValue(bool status){
        animator.SetBool("Open", status);
    }
}
