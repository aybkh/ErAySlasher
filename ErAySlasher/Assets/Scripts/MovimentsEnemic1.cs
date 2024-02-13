using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimentsEnemic1 : MonoBehaviour
{
    private int videsEnemic = 10;
    private int videsM;
    public float velocitatEnemic = 1f;
    public GameObject player;
    private Rigidbody2D rb;
    string tag = "Player";
    
    private int punts = 1;

    public GameObject prefabRecollictable;

    [SerializeField]
    private Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag(tag);
        videsM = videsEnemic;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "bala")
        {
            videsEnemic--;
            GameManager controlador = FindObjectOfType<GameManager>();
            controlador.sumaScoreEnemic1(punts);

            this.gameObject.SetActive(false);
            ////Destroy(collision.gameObject);
            if (videsEnemic == -1)
            {
                Destroy(this.gameObject, 0.1f);
                Destroy(collision.gameObject);
            }

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
        if (collision.gameObject.tag == "foc")
        {
            Destroy(this.gameObject, 0.1f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 direccio = (player.transform.position - rb.transform.position);
            direccio.Normalize();
            rb.velocity = direccio * velocitatEnemic;
        }
        if (slider != null)
        {
            slider.value = videsEnemic;
        }
    }
    
    
    
    void DeixarRecollictable()
    {
        // Instanciar el prefab del recogible de salud en la posición del enemigo
        Destroy(Instantiate(prefabRecollictable, transform.position, Quaternion.identity), 10.0f);
    }
    
}
