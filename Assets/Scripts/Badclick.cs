using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Badclick : MonoBehaviour
{
    [SerializeField] Button thisButton;
    [SerializeField] GameObject gameManager;

    private void Start()
    {
        thisButton = GetComponent<Button>();
        gameManager = GameObject.FindGameObjectWithTag("GM");
        thisButton.onClick.AddListener(BadClick);
    }

    public void BadClick()
    {
        Debug.Log("Resto 1 punto de vida a mi personaje");
    }
}
