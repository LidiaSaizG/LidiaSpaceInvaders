using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, 5 * Time.deltaTime, 0));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Destroy(collision.gameObject); // Destruye al enemigo
            Destroy(gameObject);           // Destruye este proyectil
        }
        else if (collision.gameObject.tag == "ParedInvisible")
        {
            Destroy(gameObject);           // Destruye este proyectil
        }
    }
}