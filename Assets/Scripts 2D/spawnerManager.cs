using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerManager : MonoBehaviour
{
    public GameObject[] obstacle;

    private void Update()
    {
        //Invocamos la funcion cada 1.5-4 segundos
        Invoke("obstacleSpawn", Random.Range(1.5f, 4f));
    }

    //Función para generar obstáculos aleatoriamente
    private void obstacleSpawn()
    {
        //Cancelamos invocacion para que no se repita y creamos objeto en el vector específico
        CancelInvoke();
        Instantiate(obstacle[Random.Range(0,2)], new Vector3(12.5f, -3.7f, 0), Quaternion.identity);
    }

}
