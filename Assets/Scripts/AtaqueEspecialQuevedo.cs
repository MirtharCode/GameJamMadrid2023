using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtaqueEspecialQuevedo : MonoBehaviour
{
    [SerializeField] public float energia = 100;
    public Image imagenDeRelleno; // Asigna la imagen de relleno en el Inspector
    public Animator animador;
    public Vida scriptVida;

    [SerializeField] Animator animator;

    private void Start()
    {
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
            energia = 0;
            animador.SetTrigger("IsEspecial"); // Activa la animación

            StartCoroutine(PausarReduccionDeVidaDurante4Segundos());
        }
    }

    private IEnumerator PausarReduccionDeVidaDurante4Segundos()
    {
        scriptVida.puedeReducirVida = false; // Pausa la reducción de vida

        // Espera 4 segundos
        yield return new WaitForSeconds(4.0f);

        scriptVida.puedeReducirVida = true; // Reanuda la reducción de vida
    }

}
