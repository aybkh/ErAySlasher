using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MovimentsEnemic2 : MonoBehaviour
{
    private int videsEnemic2 = 3;
    public float velocitatEnemic2 = 0.3f;
    public GameObject player;
    private Rigidbody2D rb;
    string tag = "Player";

    private int puntsEnemic2 = 1;

    public GameObject prefabRecollictableEnemic2;

    [SerializeField]
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GameObject.FindGameObjectWithTag(tag);
        if (slider != null)
        {
            slider.maxValue = videsEnemic2;
            slider.value = videsEnemic2;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (player != null)
        {
            Vector3 direccio = (player.transform.position - rb.transform.position);
            direccio.Normalize();
            //this.gameObject.transform.rotation = Quaternion.LookRotation(direccio);
            rb.velocity = direccio * velocitatEnemic2;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "bala")
        {
            velocitatEnemic2--;
            if (slider != null)
            {
                slider.value = videsEnemic2;
            }
            GameManager controlador = FindObjectOfType<GameManager>();
            controlador.sumaScoreEnemic2(puntsEnemic2);

            this.gameObject.SetActive(false);

            if (videsEnemic2 <= 0)
            {
                Destroy(gameObject);
                Destroy(collision.gameObject);
            }
            GameManager EnmMatats = FindObjectOfType<GameManager>();

            if (EnmMatats.ScoreEnemic2() % 20 == 0)
            {
                DeixarRecollictable2();

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

    void DeixarRecollictable2()
    {
        // Instanciar el prefab del recogible de salud en la posición del enemigo
        Destroy(Instantiate(prefabRecollictableEnemic2, transform.position, Quaternion.identity), 10.0f);
    }
}
