using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goodclick : MonoBehaviour
{
    [SerializeField] Button thisButton;
    [SerializeField] GameObject gameManager;
    [SerializeField] bool notSolvedYet;
    [SerializeField] Transform gapPapa;
    [SerializeField] Color currentUnsolvedGapColor;

    private void Start()
    {
        notSolvedYet = true;
        thisButton = GetComponent<Button>();
        gameManager = GameObject.FindGameObjectWithTag("GM");
        gapPapa = gameManager.GetComponent<FillTheGap>().buttonFather.transform;
        currentUnsolvedGapColor = gameManager.GetComponent<FillTheGap>().currentUnsolvedGapColor;
        thisButton.onClick.AddListener(GoodClick);
    }

    void GoodClick()
    {

        Debug.Log("Sumo +10 al contador");
        gameManager.GetComponent<FillTheGap>().gapsSolved++;
        for (int i = 0; i < gameManager.GetComponent<FillTheGap>().currentGaps.Count; i++)
        {
            if (gameManager.GetComponent<FillTheGap>().currentGaps[i].GetComponent<Image>().color == currentUnsolvedGapColor
                && gameManager.GetComponent<FillTheGap>().gapsSolved < gameManager.GetComponent<FillTheGap>().currentGaps.Count
                && notSolvedYet)
            {
                gameManager.GetComponent<FillTheGap>().currentGaps[i].GetComponent<Image>().color = Color.white;
                gameManager.GetComponent<FillTheGap>().currentGaps[i].SetActive(false);
                gameManager.GetComponent<FillTheGap>().currentGaps[i + 1].GetComponent<Image>().color = currentUnsolvedGapColor;

                notSolvedYet = false;
            }
        }

        if (gameManager.GetComponent<FillTheGap>().currentGaps[1].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1b, gapPapa);
        }

        else if (gameManager.GetComponent<FillTheGap>().currentGaps[2].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1c, gapPapa);
        }
        else if (gameManager.GetComponent<FillTheGap>().currentGaps[3].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1d, gapPapa);
        }

        else if (gameManager.GetComponent<FillTheGap>().currentGaps[4].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1e, gapPapa);
        }
        else if (gameManager.GetComponent<FillTheGap>().currentGaps[5].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1f, gapPapa);
        }

        else if (gameManager.GetComponent<FillTheGap>().currentGaps[6].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1g, gapPapa);
        }

        else if (gameManager.GetComponent<FillTheGap>().currentGaps[7].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1h, gapPapa);
        }

        else if (gameManager.GetComponent<FillTheGap>().currentGaps[8].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1i, gapPapa);
        }

        else if (gameManager.GetComponent<FillTheGap>().currentGaps[9].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1j, gapPapa);
        }

        else if (gameManager.GetComponent<FillTheGap>().currentGaps[10].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1k, gapPapa);
        }

        else if (gameManager.GetComponent<FillTheGap>().currentGaps[11].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1l, gapPapa);
        }

        else if (gameManager.GetComponent<FillTheGap>().currentGaps[12].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1m, gapPapa);
        }

        else if (gameManager.GetComponent<FillTheGap>().currentGaps[13].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1n, gapPapa);
        }

        else if (gameManager.GetComponent<FillTheGap>().currentGaps[14].GetComponent<Image>().color == currentUnsolvedGapColor)
        {
            Poem1GapActivation(gameManager.GetComponent<FillTheGap>().gap1o, gapPapa);
            gameManager.GetComponent<FillTheGap>().poem1Solved = true;
        }
    }

    public void Poem1GapActivation(GameObject nextGapToAppear, Transform where)
    {
        Destroy(GameObject.FindGameObjectWithTag("GapButton"));

        if (!gameManager.GetComponent<FillTheGap>().poem1Solved)
        {
            GameObject clon = Instantiate(nextGapToAppear, where);
            clon.transform.SetParent(where);
        }

        else
        {
            gameManager.GetComponent<FillTheGap>().currentGaps[gameManager.GetComponent<FillTheGap>().currentGaps.Count - 1].SetActive(false);
            Debug.Log("Ganaste");
        }
    }
}
