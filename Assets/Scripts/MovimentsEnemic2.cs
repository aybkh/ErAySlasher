using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsEnemic2 : MonoBehaviour
{
    private int videsEnemic2 = 3;
    public float velocitatEnemic = 0.5f;
    public GameObject Player;
    private Rigidbody2D rb;
    string tag = "Player";
    public GameManager ScoreEnemic2;
    private int punts = 1;

    public GameObject prefabRecollictable;

    public baraVidaEnemic2 baraVidaEnemic;
    Transform player;  // Referencia al jugador

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Player = GameObject.FindGameObjectWithTag(tag);
        baraVidaEnemic.ConfigurarVidaMaxima(videsEnemic2);
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            videsEnemic2--;
            baraVidaEnemic.ActualizarVida(videsEnemic2);

            GameManager controlador = FindObjectOfType<GameManager>();
            if (videsEnemic2 <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                controlador.sumaScoreEnemic2(punts);
                if (controlador.ScoreEnemic2() % 20 == 0)
                {
                    DeixarRecollictable();
                }
                this.gameObject.SetActive(false);
            }


        }
        if (collision.gameObject.tag == "bala2")
        {
            videsEnemic2 = videsEnemic2 - 2;
            baraVidaEnemic.ActualizarVida(videsEnemic2);

            GameManager controlador = FindObjectOfType<GameManager>();
            if (videsEnemic2 <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                controlador.sumaScoreEnemic2(punts);
            }
            GameManager enmMatats = FindObjectOfType<GameManager>();
            if (enmMatats.ScoreEnemic2() % 20 == 0)
            {
                videsEnemic2++;
                DeixarRecollictable();
                baraVidaEnemic.ActualizarVida(videsEnemic2);
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
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        Vector2 directionToPlayer = (player.position - transform.position).normalized;
        transform.up = directionToPlayer;
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
