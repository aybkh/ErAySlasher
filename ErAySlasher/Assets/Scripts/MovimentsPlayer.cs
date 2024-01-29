using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsPlayer : MonoBehaviour
{
    public int vides = 3;
    public float velocitatPlayer;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(0, velocitatPlayer*Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(0, -velocitatPlayer * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(-velocitatPlayer * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(velocitatPlayer * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(new Vector3(0, velocitatPlayer * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(new Vector3(0, -velocitatPlayer * Time.deltaTime, 0));
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(new Vector3(-velocitatPlayer * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(new Vector3(velocitatPlayer * Time.deltaTime, 0, 0));
        }
        /*if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, 100));
        }*/

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.tag == "enemic")
        {
            vides--;
            if(vides==0)
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
            }
        }

        
        
        if (collision.gameObject.tag == "missil")
            {
            Destroy(collision.gameObject);
            vides--;
            if (vides == 0)
            {
                Destroy(this.gameObject);
                Destroy(collision.gameObject);
            }
        }

        if (collision.gameObject.tag == "Planeta")
        {
            vides=0;
            Destroy(this.gameObject);
        }
        if (collision.gameObject.tag == "Cor")
        {
            Destroy(collision.gameObject);
            vides++;
        }

    }
    public int misVides()
    {
        return vides;
    }
}
