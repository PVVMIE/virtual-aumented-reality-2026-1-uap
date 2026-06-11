using UnityEngine;

public class EcodexManager : MonoBehaviour
{
    [Header("Configuracion de Pantallas")]
    public GameObject canvasMenu;
    public GameObject targetLata;
    public GameObject panelPokedex;

    [Header("Configuracion de Sonido")]
    public AudioSource audioSource;
    public AudioClip clickSound;

    // Metodo para ir del Menu al Escaner
    public void AbrirEscanear()
    {
        ReproducirSonido();
        canvasMenu.SetActive(false);
        targetLata.SetActive(true);
        // El panel Pokedex se activará solo cuando Vuforia detecte la lata
    }

    // Metodo para regresar al Menu Principal
    public void VolverAlMenu()
    {
        ReproducirSonido();
        canvasMenu.SetActive(true);
        targetLata.SetActive(false);
        panelPokedex.SetActive(false);
    }

    // Metodo para el feedback auditivo (Criterio 4 de la rubrica)
    private void ReproducirSonido()
    {
        if (audioSource != null && clickSound != null)
        {
            audioSource.PlayOneShot(clickSound);
        }
    }
}