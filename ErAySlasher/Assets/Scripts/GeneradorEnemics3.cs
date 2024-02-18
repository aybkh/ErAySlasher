using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorEnemics3 : MonoBehaviour
{
    public GameObject Enemic3;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreaEnemic", 0f, 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void CreaEnemic()
    {
        GameManager contador = FindObjectOfType<GameManager>();
        if (contador.DonarPunts() >= 50 && contador.ScoreEnemic2() >= 10)
        {
            Instantiate(Enemic3, this.transform.position, this.transform.rotation);
        }
    }
}
