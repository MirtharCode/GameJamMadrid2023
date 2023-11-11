using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FillTheGap : MonoBehaviour
{

    [SerializeField] public GameObject gapFather;
    [SerializeField] public GameObject buttonFather;
    [SerializeField] public int gapsSolved = 0;
    [SerializeField] public Color currentUnsolvedGapColor;


    [SerializeField] public GameObject gap1a; [SerializeField] public GameObject gap1b; [SerializeField] public GameObject gap1c; [SerializeField] public GameObject gap1d;
    [SerializeField] public GameObject gap1e; [SerializeField] public GameObject gap1f; [SerializeField] public GameObject gap1g; [SerializeField] public GameObject gap1h;
    [SerializeField] public GameObject gap1i; [SerializeField] public GameObject gap1j; [SerializeField] public GameObject gap1k; [SerializeField] public GameObject gap1l;
    [SerializeField] public GameObject gap1m; [SerializeField] public GameObject gap1n; [SerializeField] public GameObject gap1o;

    [SerializeField] public GameObject gap2a; [SerializeField] public GameObject gap2b; [SerializeField] public GameObject gap2c; [SerializeField] public GameObject gap2d;
    [SerializeField] public GameObject gap2e; [SerializeField] public GameObject gap2f; [SerializeField] public GameObject gap2g; [SerializeField] public GameObject gap2h;
    [SerializeField] public GameObject gap2i; [SerializeField] public GameObject gap2j; [SerializeField] public GameObject gap2k; [SerializeField] public GameObject gap2l;
    [SerializeField] public GameObject gap2m; [SerializeField] public GameObject gap2n; [SerializeField] public GameObject gap2o;

    [SerializeField] public GameObject gap3a; [SerializeField] public GameObject gap3b; [SerializeField] public GameObject gap3c; [SerializeField] public GameObject gap3d;
    [SerializeField] public GameObject gap3e; [SerializeField] public GameObject gap3f; [SerializeField] public GameObject gap3g; [SerializeField] public GameObject gap3h;
    [SerializeField] public GameObject gap3i; [SerializeField] public GameObject gap3j; [SerializeField] public GameObject gap3k; [SerializeField] public GameObject gap3l;
    [SerializeField] public GameObject gap3m; [SerializeField] public GameObject gap3n; [SerializeField] public GameObject gap3o;

    [SerializeField] public GameObject poem1; [SerializeField] public GameObject poem2; [SerializeField] public GameObject poem3;

    [SerializeField] public bool poem1Solved = false; [SerializeField] public bool poem2Solved = false; [SerializeField] public bool poem3Solved = false;

    void Start()
    {
        currentUnsolvedGapColor = new Color(0.2196079f, 0.3294118f, 0.6588235f, 1);

        Scene currentScene = SceneManager.GetActiveScene();

        if (currentScene.name.Contains("Tangana"))
            Poem1();
        else if (currentScene.name.Contains("Quevedo"))
            Poem2();
        else if (currentScene.name.Contains("Isidro"))
            Poem3();


    }

    public void Poem1()
    {
        GameObject poemClon = Instantiate(poem1, gapFather.transform);
        poemClon.transform.SetParent(gapFather.transform);

        GameObject buttonClon = Instantiate(gap1a, buttonFather.transform);
        buttonClon.transform.SetParent(buttonFather.transform);
        Debug.Log(GameObject.FindGameObjectWithTag("Poem").name);
        GameObject.FindGameObjectWithTag("Poem").transform.GetChild(0).GetComponent<Image>().color = currentUnsolvedGapColor;
    }

    public void Poem2()
    {
        GameObject poemClon = Instantiate(poem2, gapFather.transform);
        poemClon.transform.SetParent(gapFather.transform);

        GameObject buttonClon = Instantiate(gap2a, buttonFather.transform);
        buttonClon.transform.SetParent(buttonFather.transform);
        Debug.Log(GameObject.FindGameObjectWithTag("Poem").name);
        GameObject.FindGameObjectWithTag("Poem").transform.GetChild(0).GetComponent<Image>().color = currentUnsolvedGapColor;
    }

    public void Poem3()
    {
        GameObject poemClon = Instantiate(poem3, gapFather.transform);
        poemClon.transform.SetParent(gapFather.transform);

        GameObject buttonClon = Instantiate(gap3a, buttonFather.transform);
        buttonClon.transform.SetParent(buttonFather.transform);
        Debug.Log(GameObject.FindGameObjectWithTag("Poem").name);
        GameObject.FindGameObjectWithTag("Poem").transform.GetChild(0).GetComponent<Image>().color = currentUnsolvedGapColor;
    }


}
