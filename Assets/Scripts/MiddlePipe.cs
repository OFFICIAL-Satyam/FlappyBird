using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiddlePipe : MonoBehaviour
{
    public Logic logic;
   
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.layer == 3)
        {
            logic.addScore(1);
        }
        
    }
}
