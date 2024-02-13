using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsEnemic3 : MonoBehaviour
{
    public GameObject Player;
    string tag = "Player";
    public int videsEnemic3 = 4;

    [SerializeField]
    float velocitat = 3;
    [SerializeField]
    float rang = 1;
    [SerializeField]
    float distaciaMax = 12;

    Vector2 miPosicio;
    // Start is called before the first frame update
    void Start()
    {
        novaDistinacio();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, miPosicio, velocitat * Time.deltaTime);
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
        if (collision.gameObject.tag == "Player")
        {
            videsEnemic3--;
            if (videsEnemic3 <= 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

