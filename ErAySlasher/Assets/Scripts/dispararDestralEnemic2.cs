using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dispararDestralEnemic2 : MonoBehaviour
{
    public GameObject Destral;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreaDestral", 0f, 4f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreaDestral()
    {

        Destroy(Instantiate(Destral, this.transform.position, this.transform.rotation), 10.0f);


    }
}
