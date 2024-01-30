using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsBala : MonoBehaviour
{
    /*public float speed = 10f; // Velocidad de la bala

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
    }*/
    public float velocitatProjectil;
    public GameObject Enemic1, Enemic2;
    private Rigidbody2D rb;
    string tag = "Enemic1";
    string tag2 = "Enemic2";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Enemic1 = GameObject.FindGameObjectWithTag(tag);
        Enemic2 = GameObject.FindGameObjectWithTag(tag2);
    }

    // Update is called once per frame
    private void Update()
    {
        if (Enemic1 != null)
        {
            Vector3 direccio = (Enemic1.transform.position - rb.transform.position).normalized;
            /*gameObject.transform.rotation = Quaternion.LookRotation(direccio);*/
            rb.velocity = direccio * velocitatProjectil;
        }
        if (Enemic2 != null)
        {
            Vector3 direccio = (Enemic2.transform.position - rb.transform.position).normalized;
            /*gameObject.transform.rotation = Quaternion.LookRotation(direccio);*/
            rb.velocity = direccio * velocitatProjectil;
        }
    }
}
