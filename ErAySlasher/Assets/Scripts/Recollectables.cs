using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recollectables : MonoBehaviour
{   public int cantidadDeSalud = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    void OnTriggerEnter2D(Collider2D collisio)
    {
        if (collisio.CompareTag("Player"))
        {
            // Aplicar la salud al jugador (o realizar otras acciones)
            movimentPlayer saludJugador = collisio.GetComponent<movimentPlayer>();
            if (saludJugador != null)
            {
                saludJugador.RestaurarSalud(cantidadDeSalud);
            }
            Destroy(gameObject);
        }
    }
}
