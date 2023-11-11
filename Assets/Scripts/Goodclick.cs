using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Goodclick : MonoBehaviour
{
    [SerializeField] Button thisButton;
    [SerializeField] GameObject gameManager;
    [SerializeField] GameObject currentPoem;
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

        currentPoem = gameManager.transform.GetChild(0).GetChild(0).GetChild(0).gameObject;
    }

    void GoodClick()
    {
        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name.Contains("Tangana"))
            gameManager.transform.GetChild(0).GetChild(2).GetComponent<AtaqueEspecialCetangana>().energia += 15;
        else if (currentScene.name.Contains("Quevedo"))
            gameManager.transform.GetChild(0).GetChild(2).GetComponent<AtaqueEspecialQuevedo>().energia += 15;
        else if (currentScene.name.Contains("Isidro"))
            gameManager.transform.GetChild(0).GetChild(2).GetComponent<AtaqueEspecialIsidro>().energia += 15;


        gameManager.GetComponent<FillTheGap>().gapsSolved++;
        for (int i = 0; i < currentPoem.GetComponent<Poem>().transform.childCount; i++)
        {
            if (currentPoem.GetComponent<Poem>().transform.GetChild(i).GetComponent<Image>().color == currentUnsolvedGapColor
                && gameManager.GetComponent<FillTheGap>().gapsSolved < currentPoem.GetComponent<Poem>().transform.childCount
                && notSolvedYet)
            {
                currentPoem.GetComponent<Poem>().transform.GetChild(i).GetComponent<Image>().color = Color.white;
                currentPoem.GetComponent<Poem>().transform.GetChild(i).gameObject.GetComponent<Image>().enabled = false;
                currentPoem.GetComponent<Poem>().transform.GetChild(i + 1).GetComponent<Image>().color = currentUnsolvedGapColor;

                notSolvedYet = false;
            }
        }
        if (currentScene.name.Contains("Tangana"))
        {
            if (currentPoem.GetComponent<Poem>().transform.GetChild(1).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1b, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(2).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1c, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(3).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1d, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(4).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1e, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(5).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1f, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(6).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1g, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(7).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1h, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(8).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1i, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(9).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1j, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(10).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1k, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(11).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1l, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(12).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1m, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(13).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1n, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(14).GetComponent<Image>().color == currentUnsolvedGapColor)
            {
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap1o, gapPapa);
                gameManager.GetComponent<FillTheGap>().poem1Solved = true;
            }
        }

        else if (currentScene.name.Contains("Quevedo"))
        {
            if (currentPoem.GetComponent<Poem>().transform.GetChild(1).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2b, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(2).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2c, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(3).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2d, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(4).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2e, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(5).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2f, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(6).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2g, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(7).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2h, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(8).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2i, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(9).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2j, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(10).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2k, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(11).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2l, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(12).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2m, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(13).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2n, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(14).GetComponent<Image>().color == currentUnsolvedGapColor)
            {
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap2o, gapPapa);
                gameManager.GetComponent<FillTheGap>().poem2Solved = true;
            }
        }

        else if (currentScene.name.Contains("Isidro"))
        {
            if (currentPoem.GetComponent<Poem>().transform.GetChild(1).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3b, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(2).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3c, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(3).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3d, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(4).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3e, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(5).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3f, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(6).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3g, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(7).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3h, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(8).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3i, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(9).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3j, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(10).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3k, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(11).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3l, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(12).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3m, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(13).GetComponent<Image>().color == currentUnsolvedGapColor)
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3n, gapPapa);

            else if (currentPoem.GetComponent<Poem>().transform.GetChild(14).GetComponent<Image>().color == currentUnsolvedGapColor)
            {
                PoemGapActivation(gameManager.GetComponent<FillTheGap>().gap3o, gapPapa);
                gameManager.GetComponent<FillTheGap>().poem3Solved = true;
            }
        }
    }

    public void PoemGapActivation(GameObject nextGapToAppear, Transform where)
    {
        Destroy(GameObject.FindGameObjectWithTag("GapButton"));

        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name.Contains("Tangana"))
        {
            if (!gameManager.GetComponent<FillTheGap>().poem1Solved)
            {
                GameObject clon = Instantiate(nextGapToAppear, where);
                clon.transform.SetParent(where);
            }

            else
            {
                currentPoem.GetComponent<Poem>().transform.GetChild(currentPoem.GetComponent<Poem>().transform.childCount - 1).gameObject.SetActive(false);
                Debug.Log("Ganaste");
            }
        }

        else if (currentScene.name.Contains("Quevedo"))
        {
            if (!gameManager.GetComponent<FillTheGap>().poem2Solved)
            {
                GameObject clon = Instantiate(nextGapToAppear, where);
                clon.transform.SetParent(where);
            }

            else
            {
                currentPoem.GetComponent<Poem>().transform.GetChild(currentPoem.GetComponent<Poem>().transform.childCount - 1).gameObject.SetActive(false);
                Debug.Log("Ganaste");
            }
        }

        else if (currentScene.name.Contains("Isidro"))
        {
            if (!gameManager.GetComponent<FillTheGap>().poem3Solved)
            {
                GameObject clon = Instantiate(nextGapToAppear, where);
                clon.transform.SetParent(where);
            }

            else
            {
                currentPoem.GetComponent<Poem>().transform.GetChild(currentPoem.GetComponent<Poem>().transform.childCount - 1).gameObject.SetActive(false);
                Debug.Log("Ganaste");
            }
        }
    }
}
