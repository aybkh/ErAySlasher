using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBalas : MonoBehaviour
{
    public GameObject Bala; // El prefab de la bala
    public Transform Enemic1, Enemic2; // El objeto al que se disparará

    public float fireRate = 1f; // Velocidad de disparo en disparos por segundo
    private float tempsDispar = 0.3f; // Tiempo para el próximo disparo

    // Update is called once per frame
    void Update()
    {
        // Verificar si es tiempo de disparar
        if (Time.time >= tempsDispar)
        {
            // Disparar
            Shoot();
            // Actualizar el tiempo para el próximo disparo
            tempsDispar = Time.time + 1f / fireRate;
        }
    }

    void Shoot()
    {
        // Instanciar la bala
        GameObject bullet = Instantiate(Bala, transform.position, Quaternion.identity) ;
        // Calcular la dirección hacia el objetivo
        Vector3 direction = (Enemic1.position - transform.position).normalized;
        // Obtener el componente de movimiento de la bala y establecer su dirección
        MovimentsBala bulletMovement = bullet.GetComponent<MovimentsBala>();
        if (bulletMovement != null)
        {
            bulletMovement.SetDirection(direction);
        }
    }
}
