using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recollectables : MonoBehaviour
{   //public int QuantsVides = 1;
    //    public GameObject arma2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            
            //// sumar una vida al jugador)
            //movimentPlayer saludJugador = collision.GetComponent<movimentPlayer>();
            //if (saludJugador != null)
            //{
            //    saludJugador.RestaurarVida(QuantsVides);
            //}
            Destroy(gameObject);
        }
    }
}
