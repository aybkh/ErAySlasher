using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine;
using UnityEngine.UI;


public class movimentPlayer : MonoBehaviour
{
    public int vides = 10;
    public float velocitatMoviment = 8f;
    public float velocitatRotacio;
    public GameObject arma2;

    public baraDeVida baraVidaJugador;
    private float powerUpArma = 5f;
    // Start is called before the first frame update
    void Start()
    {
        baraVidaJugador.ConfigurarVidaMaxima(vides);
    }

    // Update is called once per frame
    void Update()
    {
        // Obtener valores de entrada para los ejes horizontal y vertical
        float entradaHoritzontal = Input.GetAxis("Horizontal");
        float entradaVertical = Input.GetAxis("Vertical");

        // Calcular la dirección de movimiento
        Vector3 moviment = new Vector3(entradaHoritzontal, entradaVertical, 0f).normalized;
        if (moviment != Vector3.zero)
        {
            // Calcular el ángulo en radianes basado en la entrada
            float angulObjetiu = Mathf.Atan2(moviment.y, moviment.x) * Mathf.Rad2Deg;

            // Rotar suavemente al jugador hacia el ángulo objetivo
            float angul = Mathf.MoveTowardsAngle(transform.eulerAngles.z, angulObjetiu, velocitatRotacio * Time.deltaTime);
            transform.rotation = Quaternion.Euler(0f, 0f, angul);
        }
                // Mover al jugador en la dirección calculada
        transform.position += moviment * velocitatMoviment * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemic1")
        {
            Debug.Log("Queden" + vides);
            vides--;
            baraVidaJugador.ActualizarVida(vides);
            if (vides <= 0)
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.tag == "Enemic2")
        {
            vides--;
            baraVidaJugador.ActualizarVida(vides);
            if (vides <= 0)
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.tag == "Destral")
        {
            vides--;
            baraVidaJugador.ActualizarVida(vides);
            if (vides <= 0)
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
            }
        }
        if (collision.gameObject.tag == "Enemic3")
        {
            vides = vides - 2;
            baraVidaJugador.ActualizarVida(vides);
            if (vides <= 0)
            {
                Destroy(this.gameObject);
            }
        }
        
        if (collision.gameObject.tag == "recollictable")
        {
            arma2.SetActive(true);
        }
        if (collision.gameObject.tag == "recollictable")
        {
            if (!arma2.activeSelf)
            {
                arma2.SetActive(true);
                // Invoca el método DesactivarArma2 después de 5 segundos
                Invoke("DesactivarArma2", powerUpArma);
            }
        }
    }
    
    // Método para desactivar arma2
    void DesactivarArma2()
    {
        arma2.SetActive(false);
    }
    public int Vides()
    {
        return vides;
    }
}
