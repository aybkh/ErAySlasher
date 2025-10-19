using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class focDragon : MonoBehaviour
{
    public GameObject foc;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreaBala", 0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreaBala()
    {

        Destroy(Instantiate(foc, this.transform.position, this.transform.rotation), 5f);


    }
}
