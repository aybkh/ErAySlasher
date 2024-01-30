using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemics1 : MonoBehaviour
{
    public GameObject Enemic1;
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
        
            Destroy(Instantiate(Enemic1, this.transform.position, this.transform.rotation), 10.0f);
        
       
    }
}
