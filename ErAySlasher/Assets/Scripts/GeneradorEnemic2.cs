using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemic2 : MonoBehaviour
{
    public GameObject Enemic2;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreaEnemic", 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreaEnemic()
    {
        GenerarEnemic2();
    }
    public void GenerarEnemic2()
    {
        Destroy(Instantiate(Enemic2, this.transform.position, this.transform.rotation), 10f);
    }
}
