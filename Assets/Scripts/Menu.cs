using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void Jugar()
    {
        SceneManager.LoadScene(1);
    }

    public void Salir()
    {
        Debug.Log("Salir...");
        Application.Quit();
    }

    public void Creditos()
    {
        SceneManager.LoadScene(9);
    }

    public void Volvermenu()
    {
        SceneManager.LoadScene(0);
    }
}
