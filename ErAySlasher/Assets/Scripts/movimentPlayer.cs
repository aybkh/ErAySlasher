using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.Events;
using UnityEngine;


public class movimentPlayer : MonoBehaviour
{
    public float vides { get; set; } = 10;
    public float videsA;
    public float velocitatMoviment = 8f;
    public float velocitatRotacio;
    // Start is called before the first frame update
    void Start()
    {
        videsA = vides;
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
    public void RestaurarSalud(int cantitat)
    {
        vides++;
        vides = Mathf.Min(vides, 10);
    }

   
    public UnityEvent OnHealthChanged;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "Enemic1")
        {
            videsA = vides--;
            if (vides <= 0)
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
            }
            OnHealthChanged.Invoke();
        }
        
    }


    public float misVides
    {
        get { return videsA; }
    }



}
