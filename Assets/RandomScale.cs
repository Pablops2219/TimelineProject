    using System;
using Unity.VisualScripting;
using UnityEngine;

public class RandomScale : MonoBehaviour
{
    [Header("Explosion Settings")]
    public ParticleSystem explosionEffect; // Arrastra tu sistema de partículas aquí.

    public void OnSignalReceived()
    {
        Debug.Log("¡Señal recibida! Ejecutando acción...");
        TriggerExplosion();
    }

    private void ChangeColor()
    {
        Renderer renderer = GetComponent<Renderer>();
        if (renderer != null)
        {
            renderer.material.color = UnityEngine.Random.ColorHSV();
        }
    }

    private void TriggerExplosion()
    {
        if (explosionEffect != null)
        {
            // Instancia el sistema de partículas en la posición del objeto.
            ParticleSystem instance = Instantiate(explosionEffect, transform.position, Quaternion.identity);
            instance.Play();

            // Destruir el sistema de partículas después de que termine.
            Destroy(instance.gameObject, instance.main.duration);
        }
        else
        {
            Debug.LogWarning("No se ha asignado un sistema de partículas para la explosión.");
        }
    }
    
}
