using UnityEngine;
using UnityEngine.UI;

public class Vida : MonoBehaviour
{
    public Image barraCompleta; // Asigna la imagen de fondo en el Inspector.
    public Image barraActual; // Asigna la imagen de relleno en el Inspector.
    public float intervaloBajarVida = 2f; // Intervalo de tiempo para reducir la vida en segundos.
    public float cantidadBajarVida = 10f; // Cantidad de vida a reducir.
    public Animator animadorGameOver; // Asigna el Animator que controla la animación de Game Over en el Inspector.

    private float tiempoPasado = 0f;
    private float vidaActual = 100f; // Valor inicial de la vida.
    private bool vidaCero = false;

    void Start()
    {
        // Configura las imágenes en su estado inicial.
        barraCompleta.fillAmount = 1f; // Barra completa al inicio.
        barraActual.fillAmount = 1f; // Barra actual al inicio.
    }

    void Update()
    {
        if (!vidaCero) // Verifica si la vida no ha llegado a cero.
        {
            tiempoPasado += Time.deltaTime;

            if (tiempoPasado >= intervaloBajarVida)
            {
                ReducirVida();
                tiempoPasado = 0f; // Reinicia el temporizador.
            }
        }
    }

    void ReducirVida()
    {
        // Disminuye la vida según la cantidad especificada.
        vidaActual -= cantidadBajarVida;

        // Asegura que la vida no sea menor que 0.
        vidaActual = Mathf.Max(0f, vidaActual);

        // Calcula la fracción de vida restante y actualiza las imágenes.
        float fraccionVida = vidaActual / 100f;
        barraActual.fillAmount = fraccionVida;

        // Verifica si la vida ha llegado a cero.
        if (vidaActual <= 0)
        {
            vidaCero = true;
            // Inicia la animación de Game Over.
            animadorGameOver.SetTrigger("Game Over"); // Asegúrate de tener un trigger llamado "Game Over" en tu Animator.
        }
    }
}
