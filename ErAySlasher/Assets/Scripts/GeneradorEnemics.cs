using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemics : MonoBehaviour
{
    public GameObject Enemic;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        CreaEnemic();
    }

    private void CreaEnemic()
    {
        int aleatori = Random.Range(0, 1000);
        if (aleatori < 1)
        {
            Destroy(Instantiate(Enemic, transform.position, transform.rotation), 10.0f);
        }
    }
    
}
