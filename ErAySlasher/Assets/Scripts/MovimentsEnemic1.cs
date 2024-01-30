using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsEnemic1 : MonoBehaviour
{
    public float velocitatBala = 2f;
    public GameObject player;
    private Rigidbody2D rb;
    string tag = "Player";
    public int videsEnemic = 3;
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
            rb.velocity = direccio * velocitatBala;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.gameObject.tag == "bala")
        {
            videsEnemic--;
            if(videsEnemic <=0)
            {
                Destroy(this.gameObject, 0.1f);
                Destroy(collision.gameObject);
            }
        }
    }
    
}