using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class autoDisparo : MonoBehaviour
{
    public float disparo = 0.5f; // Disparo cada 0.5 segundos
    public int daño = 10;

    void Start()
    {
        InvokeRepeating("Shoot", 0f, disparo);
    }

    void Shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(transform.position, transform.forward, out hit))
        {
            if (hit.collider.CompareTag("Enemy"))
            {
                // Aplicar daño al enemigo
                mortEnemic videsEnemic = hit.collider.GetComponent<mortEnemic>();
                if (videsEnemic != null)
                {
                    videsEnemic.Daño(daño);
                }
            }
        }
    }
}
