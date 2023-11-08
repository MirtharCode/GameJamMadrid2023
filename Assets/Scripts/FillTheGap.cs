using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class FillTheGap : MonoBehaviour
{

    [SerializeField] public List<GameObject> currentGaps;
    [SerializeField] public List<GameObject> currentButtons;
    [SerializeField] public GameObject gapFather;
    [SerializeField] public GameObject buttonFather;
    [SerializeField] public int gapsSolved = 0;

    [SerializeField] public bool poem1; [SerializeField] public bool poem2; [SerializeField] public bool poem3; [SerializeField] public bool poem4; [SerializeField] public bool poem5;

    [SerializeField] public GameObject gap1a; [SerializeField] public GameObject gap1b; [SerializeField] public GameObject gap1c; [SerializeField] public GameObject gap1d;
    [SerializeField] public GameObject gap1e; [SerializeField] public GameObject gap1f; [SerializeField] public GameObject gap1g; [SerializeField] public GameObject gap1h;
    [SerializeField] public GameObject gap1i; [SerializeField] public GameObject gap1j; [SerializeField] public GameObject gap1k; [SerializeField] public GameObject gap1l;
    [SerializeField] public GameObject gap1m; [SerializeField] public GameObject gap1n; [SerializeField] public GameObject gap1o;

    [SerializeField] public bool gap1Solved = false; [SerializeField] public bool gap2Solved = false; [SerializeField] public bool gap3Solved = false; [SerializeField] public bool gap4Solved = false;
    [SerializeField] public bool gap5Solved = false; [SerializeField] public bool gap6Solved = false; [SerializeField] public bool gap7Solved = false; [SerializeField] public bool gap8Solved = false;
    [SerializeField] public bool gap9Solved = false; [SerializeField] public bool gap10Solved = false; [SerializeField] public bool gap11Solved = false; [SerializeField] public bool gap12Solved = false;
    [SerializeField] public bool gap13Solved = false; [SerializeField] public bool gap14Solved = false; [SerializeField] public bool gap15Solved = false;

    [SerializeField] public bool gap1Active = false; [SerializeField] public bool gap2Active = false; [SerializeField] public bool gap3Active = false; [SerializeField] public bool gap4Active = false;
    [SerializeField] public bool gap5Active = false; [SerializeField] public bool gap6Active = false; [SerializeField] public bool gap7Active = false; [SerializeField] public bool gap8Active = false;
    [SerializeField] public bool gap9Active = false; [SerializeField] public bool gap10Active = false; [SerializeField] public bool gap11Active = false; [SerializeField] public bool gap12Active = false;
    [SerializeField] public bool gap13Active = false; [SerializeField] public bool gap14Active = false; [SerializeField] public bool gap15Active = false;

    void Start()
    {
        CollectingGaps();
        Poem1();
    }


    void Update()
    {

    }

    public void CollectingGaps()
    {
        currentGaps.Clear();

        while (currentGaps.Count != gapFather.gameObject.transform.childCount)
        {
            for (int i = 0; i < gapFather.gameObject.transform.childCount; i++)
            {
                currentGaps.Add(gapFather.transform.GetChild(i).gameObject);
            }
        }
    }

    public void CollectingButtons()
    {
        currentButtons.Clear();

        while (currentButtons.Count != buttonFather.gameObject.transform.childCount)
        {
            for (int i = 0; i < buttonFather.gameObject.transform.childCount; i++)
            {
                currentButtons.Add(buttonFather.transform.GetChild(i).gameObject);
            }
        }
    }

    public void Poem1()
    {
        gap1Active = true;
        GameObject clon = Instantiate(gap1a, buttonFather.transform);
        clon.transform.SetParent(buttonFather.transform);
        currentGaps[0].GetComponent<Image>().color = Color.blue;
    }
}
