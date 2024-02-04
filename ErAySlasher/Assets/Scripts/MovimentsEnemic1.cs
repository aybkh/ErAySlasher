using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsEnemic1 : MonoBehaviour
{
    public float velocitatEnemic = 1f;
    public GameObject player;
    private Rigidbody2D rb;
    string ttag = "Player";
    public int videsEnemic = 3;

    public GameObject prefabRecogibleSalud;
    public float probabilidadDeCaída = 0.3f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag(ttag);
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
            videsEnemic--;
            
            if(videsEnemic <=0)
            {
                if (Random.value <= probabilidadDeCaída)
                {
                    DejarRecogibleSalud();
                    Destroy(this.gameObject, 0.1f);
                    Destroy(collision.gameObject);
                }
                
            }
        }
    }

    void DejarRecogibleSalud()
    {
        // Instanciar el prefab del recogible de salud en la posición del enemigo
        Destroy(Instantiate(prefabRecogibleSalud, transform.position, Quaternion.identity), 10.0f);
    }
}
