using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentDestral : MonoBehaviour
{
    public float velocitatDestral;
    public float velocitatRotacio;  // Nueva variable para la velocidad de rotación
    void Start()
    {
        transform.localScale = new Vector3(Mathf.Abs(transform.localScale.x), transform.localScale.y, transform.localScale.z);
    }
    void Update()
    {
        transform.Translate(new Vector3(velocitatDestral * Time.deltaTime, 0, 0));
        transform.Rotate(Vector3.forward, velocitatRotacio * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "bala")
        {
            Destroy(this.gameObject, 0.1f);
            Destroy(collision.gameObject);

        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(this.gameObject, 0.1f);
        }
        if (collision.gameObject.tag == "foc")
        {
            Destroy(this.gameObject, 0.1f);
        }
    }
}
