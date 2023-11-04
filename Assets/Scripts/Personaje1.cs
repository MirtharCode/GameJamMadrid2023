using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje1 : MonoBehaviour
{
    private Animator animator;

    public float intervalo = 0.5f;
    private float tiempoPasado = 0.0f;

    void Start()
    {
        animator = GetComponent<Animator>();
    }
        
    void Update()
    {
        tiempoPasado += Time.deltaTime;

        if (tiempoPasado >= intervalo)
        {
            if(intervalo < 0.5f)
            {
                animator.SetBool("isAtaquing", true);
            }

            else
            {
                animator.SetBool("isEspecial", false);
            }
            Debug.Log("Acción realizada cada " + intervalo + " segundos.");

            tiempoPasado = 0.0f; // Reinicia el contador de tiempo.
        }
    }
}
