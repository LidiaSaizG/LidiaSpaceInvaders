using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float timer = 0;
    float timeToMove = 0.5f;
    int horizontalMoves = 0;
    int verticalMoves = 0;
    float horizontalSpeed = 0.25f;
    float verticalSpeed = 0.25f;
    bool movingHorizontally = true;

    public GameObject enemy;
    public GameObject enemyProjectile;
    public GameObject enemyProjectileClone;

    void Start()
    {

    }

    void Update()
    {
        if (GameManager.playGame)
        {
            movement();
            fireEnemyProjectile();
        }
    }

    void movement()
    {
        timer += Time.deltaTime;

       
        if (timer > timeToMove)
        {
            if (movingHorizontally)
            {
               
                transform.Translate(new Vector3(horizontalSpeed, 0, 0));
                horizontalMoves++;

                
                if (horizontalMoves >= 2)
                {
                    horizontalMoves = 0;
                    horizontalSpeed = -horizontalSpeed;
                    movingHorizontally = false; 
                }
            }
            else
            {
              
                transform.Translate(new Vector3(0, verticalSpeed, 0));
                verticalMoves++;

                
                if (verticalMoves >= 2)
                {
                    verticalMoves = 0;
                    verticalSpeed = -verticalSpeed;
                    movingHorizontally = true; 
                }
            }

            timer = 0;
        }
    }

    void fireEnemyProjectile()
    {
        if (Random.Range(0f, 20f) < 1)
        {
            enemyProjectileClone = Instantiate(enemyProjectile, new Vector3(enemy.transform.position.x, enemy.transform.position.y - 0.8f, 0), enemy.transform.rotation) as GameObject;
            Physics2D.IgnoreCollision(enemyProjectile.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
