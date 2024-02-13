using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimentDestral : MonoBehaviour
{
    public Transform Player;
    public float velocitatDestral;

    private void Update()
    {
        if (Player != null)
        {
            Vector3 direction = Player.position - transform.position;
            direction.Normalize();
            transform.Translate(direction * velocitatDestral * Time.deltaTime);
            
        }
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
