using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Badclick : MonoBehaviour
{
    [SerializeField] Button thisButton;
    [SerializeField] GameObject gameManager;
    [SerializeField] AudioSource playerHit;

    private void Start()
    {
        thisButton = GetComponent<Button>();

        gameManager = GameObject.FindGameObjectWithTag("GM");
        thisButton.onClick.AddListener(BadClick);
        playerHit = GetComponent<AudioSource>();
    }

    public void BadClick()
    {
        Debug.Log("Resto 1 punto de vida a mi personaje");
        gameManager.transform.GetChild(0).GetChild(5).GetComponent<Vida>().vidaActual -= 1;
        playerHit.Play();
    }
}
