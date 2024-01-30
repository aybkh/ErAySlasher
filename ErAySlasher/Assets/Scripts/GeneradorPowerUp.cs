using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorPlaneta : MonoBehaviour
{
    public GameObject PowerUp;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreaPowerUp", 0f, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void CreaPowerUp()
    {
        
            Destroy(Instantiate(PowerUp, this.transform.position, this.transform.rotation), 10.0f);
        
       
    }
}
