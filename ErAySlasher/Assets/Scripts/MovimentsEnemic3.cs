using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsEnemic3 : MonoBehaviour
{
    string tag = "Player";
    public int videsEnemic3 = 4;
    private int punts = 1;

    [SerializeField]
    float velocitat = 2;
    [SerializeField]
    float rang = 1;
    [SerializeField]
    float distaciaMax = 20;

    Vector2 miPosicio;

    public GameObject prefabRecollictable;

    public baraVidaEnemic3 baraVidaEnemic3;
    Transform player;  // Reference to the player

    // Start is called before the first frame update
    void Start()
    {
        novaDistinacio();
        player = GameObject.FindGameObjectWithTag("Player").transform;
        baraVidaEnemic3.ConfigurarVidaMaxima(videsEnemic3);
    }

    // Update is called once per frame
    void Update()
    {
        //float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        //Vector2 directionToPlayer = (player.position - transform.position).normalized;
        //transform.up = directionToPlayer;

        // Si el jugador no está cerca, muévete aleatoriamente
        transform.position = Vector2.MoveTowards(transform.position, miPosicio, velocitat * Time.deltaTime);

            // Si el enemigo está cerca de la posición aleatoria, elige una nueva posición aleatoria
            if (Vector2.Distance(transform.position, miPosicio) < rang)
            {
                novaDistinacio();
            }
    }
    public void novaDistinacio()
    {
        miPosicio = new Vector2(Random.Range(-distaciaMax, distaciaMax), Random.Range(-distaciaMax, distaciaMax));
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bala")
        {
            videsEnemic3--;
            baraVidaEnemic3.ActualizarVida(videsEnemic3);

            GameManager controlador = FindObjectOfType<GameManager>();
            if (videsEnemic3 <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                controlador.sumaScoreEnemic3(punts);
                if (controlador.ScoreEnemic3() % 30 == 0)
                {
                    DeixarRecollictable();
                }
                this.gameObject.SetActive(false);
            }


        }
        if (collision.gameObject.tag == "bala2")
        {
            videsEnemic3 = videsEnemic3 - 2;
            baraVidaEnemic3.ActualizarVida(videsEnemic3);


            GameManager controlador = FindObjectOfType<GameManager>();
            if (videsEnemic3 <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
                controlador.sumaScoreEnemic3(punts);
            }
            GameManager enmMatats = FindObjectOfType<GameManager>();
            if (enmMatats.ScoreEnemic3() % 30 == 0)
            {
                videsEnemic3++;
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
    void DeixarRecollictable()
    {
        // Instanciar el prefab del recogible de salud en la posición del enemigo
        Destroy(Instantiate(prefabRecollictable, transform.position, Quaternion.identity), 10.0f);
    }
}

