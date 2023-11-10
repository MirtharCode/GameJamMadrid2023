using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject canvasPausa;


    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (canvasPausa.activeSelf)
            {
                canvasPausa.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                canvasPausa.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }

    public void Reanudar()
    {
        canvasPausa.SetActive(false);
        Time.timeScale = 1;
    }

    public void Titulo()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void fight3()
    {
        SceneManager.LoadScene(7);
    }

    public void fight2()
    {
        SceneManager.LoadScene(5);
    }

    public void fight1()
    {
        SceneManager.LoadScene(3);
    }

    public void ContinuarIntroduccion()
    {
        SceneManager.LoadScene(2);
    }
}
