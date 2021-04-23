using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed = -1f;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }


    private void FixedUpdate()
    {
        //Función para mover las nubes con velocidad aleatoria
        rb2d.velocity = new Vector2(speed, 0);
        //Función para recolocar nube
        if (transform.position.x <= -19.9f)
            transform.position = new Vector2(20f, transform.position.y);
    }
}

