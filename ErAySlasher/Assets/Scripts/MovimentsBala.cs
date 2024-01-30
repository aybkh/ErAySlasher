using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsBala : MonoBehaviour
{
    public float speed = 10f; // Velocidad de la bala

    private Vector3 direction; // Direcci�n de movimiento de la bala

    // M�todo para establecer la direcci�n de la bala
    public void SetDirection(Vector3 dir)
    {
        direction = dir;
    }

    // Update is called once per frame
    void Update()
    {
        // Mover la bala en su direcci�n
        transform.Translate(direction * speed * Time.deltaTime, Space.World);
    }
}
