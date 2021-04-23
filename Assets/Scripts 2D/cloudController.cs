using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private float speed;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        //Establecemos un rango de velocidad de movimeinto aleatorio
        speed = Random.Range(-0.5f, -1f);
    }


    private void FixedUpdate()
    {
        //Función para mover las nubes con velocidad aleatoria
        rb2d.velocity = new Vector2(speed, 0);
        //Función para recolocar nube
        if (transform.position.x < -12.5f)
            transform.position = new Vector2(12.5f, transform.position.y);
    }
}
