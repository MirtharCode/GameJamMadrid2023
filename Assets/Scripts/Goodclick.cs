using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goodclick : MonoBehaviour
{
    [SerializeField] Button thisButton;
    [SerializeField] GameObject gameManager;
    [SerializeField] bool notSolvedYet;

    private void Start()
    {
        notSolvedYet = true;
        thisButton = GetComponent<Button>();
        gameManager = GameObject.FindGameObjectWithTag("GM");
        thisButton.onClick.AddListener(GoodClick);
    }

    void GoodClick()
    {
        Debug.Log("Sumo +10 al contador");
        gameManager.GetComponent<FillTheGap>().gapsSolved++;
        for (int i = 0; i < gameManager.GetComponent<FillTheGap>().currentGaps.Count; i++)
        {
            if (gameManager.GetComponent<FillTheGap>().currentGaps[i].GetComponent<Image>().color == Color.blue
                && gameManager.GetComponent<FillTheGap>().gapsSolved < gameManager.GetComponent<FillTheGap>().currentGaps.Count
                && notSolvedYet)
            {
                Debug.Log(gameManager.GetComponent<FillTheGap>().currentGaps[i].name);
                gameManager.GetComponent<FillTheGap>().currentGaps[i].GetComponent<Image>().color = Color.white;
                gameManager.GetComponent<FillTheGap>().currentGaps[i].SetActive(false);
                gameManager.GetComponent<FillTheGap>().currentGaps[i + 1].GetComponent<Image>().color = Color.blue;

                notSolvedYet = false;
            }
        }

        if (gameManager.GetComponent<FillTheGap>().currentGaps[1].GetComponent<Image>().color == Color.blue)
            Gap2();
        else if (gameManager.GetComponent<FillTheGap>().currentGaps[2].GetComponent<Image>().color == Color.blue)
            Gap3();


        Debug.Log("Ganaste");
    }

    public void Gap2()
    {
        GameObject clon = Instantiate(gameManager.GetComponent<FillTheGap>().gap1b, gameManager.GetComponent<FillTheGap>().buttonFather.transform);
        clon.transform.SetParent(gameManager.GetComponent<FillTheGap>().buttonFather.transform);
    }

    public void Gap3()
    {
        GameObject clon = Instantiate(gameManager.GetComponent<FillTheGap>().gap1c, gameManager.GetComponent<FillTheGap>().buttonFather.transform);
        clon.transform.SetParent(gameManager.GetComponent<FillTheGap>().buttonFather.transform);
    }
}
