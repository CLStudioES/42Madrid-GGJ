using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este Script se encarga de controloar todos los inputs de teclado y de llamar a las funciones consecuentes
public class inputController : MonoBehaviour
{
    //Guardamos el objeto player para acceder a él
    private playerController player;

    private void Start()
    {
        //Inicializamos los componentes
        player = GetComponent<playerController>();
    }

    private void FixedUpdate()
    {
        //Control del input SPACE para llamar a la función del salto del player
        if (Input.GetKey(KeyCode.Space))
            player.jumpPlayer();

    }
}
