using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsEnemic3 : MonoBehaviour
{
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
}
