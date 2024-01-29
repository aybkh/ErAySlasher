using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mortEnemic : MonoBehaviour
{   public int vidaEnemic = 100;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
   
    public void Daño(int amount)
    {
        vidaEnemic -= amount;

        if (vidaEnemic <= 0)
        {
            // Lógica para el enemigo muerto (por ejemplo, destruir el objeto)
            Destroy(gameObject);
        }
    }
}
