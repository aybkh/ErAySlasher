using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispararBalas : MonoBehaviour
{
<<<<<<< HEAD
    public GameObject Bala;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("CreaBala", 0f, 2f);
    }
=======
    public GameObject Bala; // El prefab de la bala
    public Transform Enemic1, Enemic2; // El objeto al que se disparará

    public float fireRate = 1f; // Velocidad de disparo en disparos por segundo
    private float tempsDispar = 0.3f; // Tiempo para el próximo disparo
>>>>>>> 07a2eb306437b70f6a8b3edf46950416e4866bec

    // Update is called once per frame
    void Update()
    {

    }

    private void CreaBala()
    {

        Destroy(Instantiate(Bala, this.transform.position, this.transform.rotation), 10.0f);


    }
}
