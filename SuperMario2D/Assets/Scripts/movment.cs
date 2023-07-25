using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class movment : MonoBehaviour
{
    private Animator anim,animflag ;
   
    private Rigidbody2D rb;
    public float force;
    public bool isGrounded=true;
    private int counter=0;
    public Text scoreText;
    private GameObject[] go;
    public AudioSource coincollect;
    public AudioSource diesound;
    public AudioSource levComp;
    public AudioSource bgsound;
    private GameObject [] bgsounds;


    void Start()
    {

        
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        go= GameObject.FindGameObjectsWithTag("Pole");
        animflag=go[0].GetComponent<Animator>();
        bgsounds= GameObject.FindGameObjectsWithTag("bgs");
        bgsound = bgsounds[0].GetComponent<AudioSource>();



        scoreText = GameObject.Find("Score").GetComponent<Text>();
    }


    void Update()
    {
        if (transform.position.y> -5.7)
            isGrounded=false;
        else 
            isGrounded=true;

        anim.SetFloat("speed",Input.GetAxis("Horizontal"));


        if(Input.GetButtonDown("Jump") & (isGrounded))
        { 
        anim.SetTrigger("jump");
            rb.AddForce(Vector2.up*force);
        }

        transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * 10    , 0f, 0f);

        scoreText.text = counter.ToString();
    

}
    void OnCollisionEnter2D(Collision2D col)
    {
       
        if (col.gameObject.tag == "coin")
        {
            counter++;
            Destroy(col.gameObject);
            coincollect.Play(0);
        }

        if (col.gameObject.tag == "goomba")
        {
            SceneManager.LoadScene("Gameover");
            diesound.Play(0);
        }


        if (col.gameObject.tag == "Castle")
        {
            SceneManager.LoadScene("Win");
        }



        if (col.gameObject.tag == "Pole")
        {
            bgsound.Pause();

            levComp.Play(0);
            animflag.SetTrigger("f");

        }


    }





}
