using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsBala1 : MonoBehaviour
{
    public float velocitatBala = 0.01f;
    public GameObject bala;
    private Rigidbody2D rbi;
    private int punts = 2;
    string taga = "Enemic";
    // Start is called before the first frame update
    void Start()
    {
        rbi = GetComponent<Rigidbody2D>();
        bala = GameObject.FindGameObjectWithTag(taga);
    }

    // Update is called once per frame
    void Update()
    {
        if (bala!=null)
        {
            Vector3 direccio = (bala.transform.position - rbi.transform.position);
            direccio.Normalize();
            //this.gameObject.transform.rotation = Quaternion.LookRotation(direccio);
            rbi.velocity = direccio * velocitatBala;
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
