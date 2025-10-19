using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentFirewall : MonoBehaviour
{
    public float velocitat = 10.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        // Llama a la función Mover después de esperar 0.5s
        InvokeRepeating("Moure", 0.3f, Time.deltaTime);
    }


    // Update is called once per frame
    void Update()
    {
       
    }
    public void Moure()
    {
        transform.Translate(new Vector3(velocitat * Time.deltaTime, 0, 0));
    }

}
