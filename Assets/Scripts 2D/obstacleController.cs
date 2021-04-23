using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float speed = -1f;

    private void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //Función para mover las nubes con velocidad speed
        rb2d.velocity = new Vector2(speed, 0);
        //Función para recolocar nube
        if (transform.position.x < -12.5f)
            //transform.position = new Vector2(12.5f, transform.position.y);
            Destroy(this.gameObject);
    }
}
