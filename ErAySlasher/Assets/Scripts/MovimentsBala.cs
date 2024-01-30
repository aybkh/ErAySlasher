using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsBala : MonoBehaviour
{
    public float speed = 10f; // Velocidad de la bala

    private Vector3 direction; // Dirección de movimiento de la bala

    // Método para establecer la dirección de la bala
    public void SetDirection(Vector3 dir)
    {
        direction = dir;
    }

    // Update is called once per frame
    void Update()
    {
        // Mover la bala en su dirección
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
