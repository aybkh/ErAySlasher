using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsEnemic1 : MonoBehaviour
{
    public float velocitatEnemic = 1f;
    public GameObject player;
    private Rigidbody2D rb;
    string tag = "Player";
    
    private int punts = 1;

    public GameObject prefabRecollictable;
    //public float probabilidadDeCaída = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag(tag);
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 direccio = (player.transform.position - rb.transform.position);
            direccio.Normalize();
            //this.gameObject.transform.rotation = Quaternion.LookRotation(direccio);
            rb.velocity = direccio * velocitatEnemic;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.gameObject.tag == "bala")
        {
            GameManager controlador = FindObjectOfType<GameManager>();
            controlador.sumaScore(punts);

            this.gameObject.SetActive(false);

            controlador.EnemigoDestruido();
            
            Destroy(this.gameObject, 0.1f);
            Destroy(collision.gameObject);
            GameManager EnmMatats = FindObjectOfType<GameManager>();
            
            if (EnmMatats.DonarPunts() % 10 == 0)
            {
                DeixarRecollictable();
                Destroy(this.gameObject, 0.1f);
                Destroy(collision.gameObject);
                
            }
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject, 0.1f);
        }
    }
    
    void DeixarRecollictable()
    {
        // Instanciar el prefab del recogible de salud en la posición del enemigo
        Destroy(Instantiate(prefabRecollictable, transform.position, Quaternion.identity), 10.0f);
    }
}
