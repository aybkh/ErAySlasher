using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsEnemic1 : MonoBehaviour
{
    private int videsEnemic = 3;
    public float velocitatEnemic = 1f;
    public GameObject Player;
    private Rigidbody2D rb;
    string tag = "Player";
    
    private int punts = 1;

    public GameObject prefabRecollictable;

    public baraVidaEnemic1 baraVidaEnemic;

    Transform player;  // Referencia al jugador

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        baraVidaEnemic.ConfigurarVidaMaxima(videsEnemic);
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag(tag);
    }
    // Update is called once per frame
    void Update()
    {
        if (Player != null)
        {
            float distanceToPlayer = Vector2.Distance(transform.position, player.position);
            Vector2 directionToPlayer = (player.position - transform.position).normalized;
            transform.up = directionToPlayer;
            Vector3 direccio = (Player.transform.position - rb.transform.position);
            direccio.Normalize();
            rb.velocity = direccio * velocitatEnemic;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            videsEnemic--;
            baraVidaEnemic.ActualizarVida(videsEnemic);
            GameManager controlador = FindObjectOfType<GameManager>();
            if (videsEnemic <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                controlador.sumaScoreEnemic1(punts);
                if (controlador.DonarPunts() % 10 == 0)
                {
                    videsEnemic++;
                    DeixarRecollictable();
                }
            }
        }
        if (collision.gameObject.tag == "bala2")
        {
            videsEnemic -= 2;
            baraVidaEnemic.ActualizarVida(videsEnemic);

            GameManager controlador = FindObjectOfType<GameManager>();
            if (videsEnemic <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                controlador.sumaScoreEnemic1(punts);
            }
            GameManager enmMatats = FindObjectOfType<GameManager>();
            if (enmMatats.DonarPunts() % 10 == 0)
            {
                videsEnemic++;
                Invoke("DeixarRecollictable", 0.1f);
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

    void DeixarRecollictable()
    {
        // Instanciar el prefab del recogible de salud en la posición del enemigo
        Destroy(Instantiate(prefabRecollictable, transform.position, Quaternion.identity), 10.0f);
    }
    
}
