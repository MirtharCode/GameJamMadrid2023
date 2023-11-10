using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

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

    [SerializeField] public GameObject poem1; [SerializeField] public GameObject poem2; [SerializeField] public GameObject poem3;
    [SerializeField] public GameObject poem4; [SerializeField] public GameObject poem5; [SerializeField] public GameObject poem6;
    [SerializeField] public GameObject poem7; [SerializeField] public GameObject poem8; [SerializeField] public GameObject poem9;
    [SerializeField] public GameObject poem10; [SerializeField] public GameObject poem11; [SerializeField] public GameObject poem12;

    [SerializeField] public bool poem1Solved = false; [SerializeField] public bool poem2Solved = false; [SerializeField] public bool poem3Solved = false;
    [SerializeField] public bool poem4Solved = false; [SerializeField] public bool poem5Solved = false; [SerializeField] public bool poem6Solved = false;
    [SerializeField] public bool poem7Solved = false; [SerializeField] public bool poem8Solved = false; [SerializeField] public bool poem9Solved = false;
    [SerializeField] public bool poem10Solved = false; [SerializeField] public bool poem11Solved = false; [SerializeField] public bool poem12Solved = false;

    void Start()
    {
        currentUnsolvedGapColor = new Color(0.2196079f, 0.3294118f, 0.6588235f, 1);
        Poem1();


    }


    void Update()
    {

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

        GameObject buttonClon = Instantiate(gap1a, buttonFather.transform);
        buttonClon.transform.SetParent(buttonFather.transform);
        poemClon.GetComponent<Poem>().currentGaps[0].GetComponent<Image>().color = currentUnsolvedGapColor;
    }


}
