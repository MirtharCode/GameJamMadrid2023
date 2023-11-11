using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtaqueEspecialCetangana : MonoBehaviour
{
    [SerializeField] public float energia = 100;
    public Image imagenDeRelleno; // Asigna la imagen de relleno en el Inspector
    public Animator animador;
    public Vida scriptVida;

    [SerializeField] AudioSource healSound;
    [SerializeField] Animator animator;

    private void Start()
    {
        healSound = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        RecargarEspecial();
        ActualizarImagenDeRelleno();
    }

    void RecargarEspecial()
    {
        energia += 3 * Time.deltaTime;

        if (energia > 100)
        {
            energia = 100;
        }
        if (energia < 0)
        {
            energia = 0;
        }
    }

    void ActualizarImagenDeRelleno()
    {
        float fillAmount = energia / 100f; // Normaliza la cantidad de energía entre 0 y 1
        imagenDeRelleno.fillAmount = fillAmount; // Asigna el valor a la imagen de relleno

        if (energia == 100)
            animator.SetBool("isFull", true);

    }

    public void resetearBarra()
    {
        if (energia == 100)
        {
            animator.SetBool("isFull", false);
            healSound.Play();
            energia = 0;
            animador.SetTrigger("IsEspecial"); // Activa la animación

            // Aumentar 30 puntos de vida
            scriptVida.vidaActual += 30;
            scriptVida.vidaActual = Mathf.Max(0f, scriptVida.vidaActual);


            animador.SetTrigger("IsEspecial"); // Activa la animación
        }
    }
}
