using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje1 : MonoBehaviour
{
    private Animator animator;
    private bool alternarAnimacion = true; // Inicialmente, alternamos a la primera animación.
    private float tiempoPasado = 0f;
    public float intervaloCambio = 2f; // Intervalo de tiempo en segundos para cambiar de animación.

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        ProcesarMovimiento();

        // Lleva un seguimiento del tiempo transcurrido.
        tiempoPasado += Time.deltaTime;

        // Verifica si ha pasado el intervalo de tiempo especificado.
        if (tiempoPasado >= intervaloCambio)
        {
            // Cambia la variable booleana para alternar entre animaciones.
            alternarAnimacion = !alternarAnimacion;

            // Establece la variable booleana en el Animator.
            animator.SetBool("IsAtacking", alternarAnimacion);

            // Reinicia el temporizador.
            tiempoPasado = 0f;
        }
    }

    private void ProcesarMovimiento()
    {
        float inputMovimiento = Input.GetAxis("Horizontal");
    }
}
