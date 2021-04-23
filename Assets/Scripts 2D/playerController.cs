using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este script se encarga de albergar las funciones de control del player
public class playerController : MonoBehaviour
{
    //Declaramos las variables y los "componentes"
    [SerializeField]
    private bool grounded;
    [SerializeField]
    private float jumpPower = 3f;

    public bool dead;
    public int points;

    private Rigidbody2D rb2d;
    private Animator anim;
    private inputController input;


    void Start()
    {
        //Inicializamos los componentes
        rb2d = GetComponent<Rigidbody2D>();
        input = GetComponent<inputController>();
        anim = GetComponent<Animator>();

        //Inicializamos animaciones y les asignamos un nombre de variable para trabajar con ellas desde Unity
        anim.SetBool("Grounded", grounded);
        //inicializamos variables
        points = 0;
        dead = false;
        Time.timeScale = 1;
    }

    private void Update()
    {
        //PROVISIONAL-> Si muere paramos todo
        if (dead == true)
            Time.timeScale = 0;
    }

    //FUNCIONES DE MOVIMIENTO
    //Funcion de salto
    public void jumpPlayer()
    {
        if (grounded == true)
            rb2d.AddForce(Vector2.up * jumpPower, ForceMode2D.Impulse);
    }

    //SISTEMA DE COLISIONES
    //Las siguientes dos funciones controlarán el bool grounded para ver si el Player puede saltar o no->
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
            grounded = false;
    }
    //<-Hasta aquí
    //La siguiente colisión controla si el player choca contra algún objeto con el tab "Obstacle"
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Debug.Log("Muerto");
            dead = true;
        }
    }


    //SISTEMA DE TRIGGERS
    private void OnTriggerEnter2D(Collider2D trigger)
    {
        //Comprobamos si llega al trigger del cactus (Checker) y sumamos un punto.
        if (trigger.gameObject.tag == "Checker")
        {
            points++;
            Debug.Log("Points: " + points);
        }

    }





}
