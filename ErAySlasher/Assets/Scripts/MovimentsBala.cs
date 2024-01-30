using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsBala : MonoBehaviour
{
    public float velocitatMissil = 0.01f;
    public GameObject player;
    private Rigidbody2D rb;
    private int punts = 2;
    string tag = "Player";
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag(tag);
    }

    // Update is called once per frame
    void Update()
    {
        if (player!=null)
        {
            Vector3 direccio = (player.transform.position - rb.transform.position);
            direccio.Normalize();
            //this.gameObject.transform.rotation = Quaternion.LookRotation(direccio);
            rb.velocity = direccio * velocitatMissil;
        }
    }
    /*
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if(collision.gameObject.tag == "bala")
        {
            GameManager controlador = FindObjectOfType<GameManager>();
            controlador.sumaScore(punts);

            Destroy(this.gameObject, 0.1f);
            Destroy(collision.gameObject);
        }
    }
    */
}
