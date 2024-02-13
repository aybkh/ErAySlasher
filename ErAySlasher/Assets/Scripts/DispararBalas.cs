using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBalas : MonoBehaviour
{
    public GameObject Bala;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreaBala", 0f, 2f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreaBala()
    {

        Destroy(Instantiate(Bala, this.transform.position, this.transform.rotation), 1.0f);


    }
}
