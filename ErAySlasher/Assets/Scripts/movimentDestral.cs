using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentDestral : MonoBehaviour
{
    public float velocitatDestral = 1f;
    public GameObject player;
    private Rigidbody2D rb;
    string tag = "Player";
    
    
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
            rb.velocity = direccio * velocitatDestral;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "bala")
        {
            Destroy(this.gameObject, 0.1f);
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject, 0.1f);
        }
        if (collision.gameObject.tag == "foc")
        {
            Destroy(this.gameObject, 0.1f);
        }
    }
}
