using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationcontrol : MonoBehaviour
{
    public Animator anim;
    

    void Start()
    {

        anim = GetComponent<Animator>();
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter2D(Collision2D col)
    {


        if (col.gameObject.tag == "Mario")
        {
            anim.SetTrigger("f");
            Debug.Log("activate");
        }

    }

}
