using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemic2 : MonoBehaviour
{
    public GameObject Enemic2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GenerarEnemic2", 3f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void GenerarEnemic2()
    {
        Destroy(Instantiate(Enemic2, transform.position, transform.rotation), 10f);
    }
    
}
