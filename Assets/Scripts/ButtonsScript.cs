using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonsScript : MonoBehaviour
{
    [SerializeField] GameObject gameManager;

    private void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GM");
    }
    
    
    public void GoodClick()
    {
        Debug.Log("Sumo +10 al contador");

        for (int i = 0; i < gameManager.GetComponent<FillTheGap>().currentGaps.Count; i++)
        {
            if (gameManager.GetComponent<FillTheGap>().currentGaps[i].GetComponent<Image>().color == Color.blue
                && gameManager.GetComponent<FillTheGap>().gapsSolved < gameManager.GetComponent<FillTheGap>().currentGaps.Count)
            {
                gameManager.GetComponent<FillTheGap>().currentGaps[i].GetComponent<Image>().color = Color.white;
                gameManager.GetComponent<FillTheGap>().currentGaps[i].SetActive(false);
                gameManager.GetComponent<FillTheGap>().currentGaps[i + 1].GetComponent<Image>().color = Color.blue;
                gameManager.GetComponent<FillTheGap>().gapsSolved++;
            }

            else
            {
                Debug.Log("Ganaste");
            }
        }
    }

    public void BadClick()
    {
        Debug.Log("Resto 1 punto de vida a mi personaje");
    }
}
