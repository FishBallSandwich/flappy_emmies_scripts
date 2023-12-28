using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class pepe : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float flapStrength = 25;
    public LogicScript logic;
    private bool birdIsAlive = true;
    private float rotationAmount = 1000;
    public ParticleSystem Explosion;

    public void StartGame()
    {
        birdIsAlive = true;
        gameObject.SetActive(true);
    }

    void Update()
    {
        if (birdIsAlive)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                myRigidbody.velocity = Vector2.up * flapStrength;
                transform.Rotate(Vector3.forward * rotationAmount);
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        birdIsAlive = false;
        Vector3 collisionPosition = transform.position;
        Explosion.transform.position = collisionPosition;
        Explosion.Play();

    }

    void OnBecameInvisible() 
    
    {

        logic.gameOver();
        birdIsAlive = false;
        
    }




}