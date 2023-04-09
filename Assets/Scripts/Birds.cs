using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : MonoBehaviour
{

    public Rigidbody2D myRigidbody ;
    public float flapStrength;
    public Logic logic;
    public bool birdIsAlive = true;
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0)==true && birdIsAlive == true)
        {
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
       logic.gameOver();
       birdIsAlive = false; 
    }
}
