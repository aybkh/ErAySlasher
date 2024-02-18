using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerarPowerUp : MonoBehaviour
{
    public GameObject fireWall;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("GeneradorPowerUp", 60f, 30f);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void GeneradorPowerUp()
    {
        Destroy(Instantiate(fireWall, transform.position, transform.rotation), 10f);
    }

}
