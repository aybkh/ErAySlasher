using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentsBala : MonoBehaviour
{
    public float velocitatBala = 20.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(velocitatBala * Time.deltaTime, 0, 0));
    }
   
}
