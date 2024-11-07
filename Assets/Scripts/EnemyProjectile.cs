using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
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
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
           
            GameManager.vidas--;
            if(GameManager.vidas == 0){
            
                Destroy(collision.gameObject);
                GameManager.playGame = false;
            }
           
        }
        else if (collision.gameObject.tag == "ParedInvisible")
        {
            Destroy(gameObject);           
        }
    }
}