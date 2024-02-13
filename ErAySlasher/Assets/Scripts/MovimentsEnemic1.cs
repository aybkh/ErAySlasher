using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimentsEnemic1 : MonoBehaviour
{
    private int videsEnemic = 3;
    private int videsM;
    public float velocitatEnemic = 1f;
    public GameObject Player;
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
        Player = GameObject.FindGameObjectWithTag(tag);
        if (slider != null)
        {
            slider.maxValue = videsEnemic;
            slider.value = videsEnemic;
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            videsEnemic--;
            if (slider != null)
            {
                slider.value = videsEnemic;
            }
            GameManager controlador = FindObjectOfType<GameManager>();
            controlador.sumaScoreEnemic1(punts);

            if (videsEnemic <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            GameManager enmMatats = FindObjectOfType<GameManager>();
            if (enmMatats.DonarPunts() % 10 == 0)
            {
                DeixarRecollictable();
            }
        }
        if (collision.gameObject.tag == "bala2")
        {
            videsEnemic = videsEnemic - 2;
            if (slider != null)
            {
                slider.value = videsEnemic;
            }
            GameManager controlador = FindObjectOfType<GameManager>();
            controlador.sumaScoreEnemic1(punts);

            if (videsEnemic <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            GameManager enmMatats = FindObjectOfType<GameManager>();
            if (enmMatats.DonarPunts() % 10 == 0)
            {
                DeixarRecollictable();
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
        if (Player != null)
        {
            Vector3 direccio = (Player.transform.position - rb.transform.position);
            direccio.Normalize();
            rb.velocity = direccio * velocitatEnemic;
        }
        
    }
    
    
    
    void DeixarRecollictable()
    {
        // Instanciar el prefab del recogible de salud en la posición del enemigo
        Destroy(Instantiate(prefabRecollictable, transform.position, Quaternion.identity), 10.0f);
    }
    
}
