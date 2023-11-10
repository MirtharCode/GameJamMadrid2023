using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Poem : MonoBehaviour
{
    [SerializeField] GameObject gameManager;
    [SerializeField] public List<GameObject> currentGaps;

    void Start()
    {
        gameManager = GameObject.FindGameObjectWithTag("GM");
        CollectingGaps();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void CollectingGaps()
    {

        while (currentGaps.Count != transform.childCount)
        {
            for (int i = 0; i < transform.childCount; i++)
            {
                currentGaps.Add(transform.GetChild(i).gameObject);
            }
        }
    }
}
