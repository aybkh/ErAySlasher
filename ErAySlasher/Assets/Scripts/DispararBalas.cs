using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBalas : MonoBehaviour
{
    public GameObject bala;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            Destroy(Instantiate(bala, this.transform.position, this.transform.rotation), 2.0f);
        }
    }
}
