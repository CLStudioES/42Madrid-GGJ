using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameController : MonoBehaviour
{
    public playerController player;
    //Creamos una variable de tipo texto llamada points
    public Text points;
    //Hacemos la llamada a los botones
    public Button reloadButton;
    public Button exitButton;

    void Update()
    {
        //Modificamos la variable points y le damos el valor de points del objeto player. Después lo pasamos a String ya que está como tipo int.
        points.text = player.points.ToString();
        //Sistema de visualizacion de botones al morir
        if (player.dead == false)
        {

            reloadButton.gameObject.SetActive(false);
            exitButton.gameObject.SetActive(false);

        }

        else if(player.dead == true)
        {
            reloadButton.gameObject.SetActive(true);
            exitButton.gameObject.SetActive(true);
        }
    }

    //SISTEMA DE REPLAY Y CIERRE
    public void reloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void closeGame()
    {
        Application.Quit();
    }
}
