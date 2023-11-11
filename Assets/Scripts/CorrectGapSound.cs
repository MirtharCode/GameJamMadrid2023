using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CorrectGapSound : MonoBehaviour
{
    [SerializeField] AudioSource correct;
    [SerializeField] bool onceUponATimeIWasBlue = false;
    [SerializeField] bool onlyOnce = false;

    [SerializeField] GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GM");
        correct = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        ColorChanged();
    }

    void ColorChanged()
    {
        if (GetComponent<Image>().color == gameManager.GetComponent<FillTheGap>().currentUnsolvedGapColor)
            onceUponATimeIWasBlue = true;

        else if (GetComponent<Image>().color == Color.white && !onlyOnce && onceUponATimeIWasBlue)
        {
            onlyOnce = true;
            onceUponATimeIWasBlue = false;
            correct.Play();
        }
    }
}
