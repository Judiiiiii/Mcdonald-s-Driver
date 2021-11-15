using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]float steerSpeed = 1.5f;
    [SerializeField]float moveSpeed = 0.1f;
    [SerializeField]float slowspeed = 10f;
    [SerializeField]float fastspeed = 20f;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float strAmount = Input.GetAxis("Horizontal") * steerSpeed;
        float mvAmount = Input.GetAxis("Vertical") * moveSpeed;

        if(mvAmount == 0)
        {
            strAmount = 0;
        }

        transform.Rotate(0,0,-strAmount);
        transform.Translate(0,mvAmount,0);
    }

    void OnCollisionEnter2D(Collision2D other) 
    {
        moveSpeed = slowspeed;
    }

    void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.tag == "Power+1")
        {
            moveSpeed = fastspeed;
            Debug.Log("Going to a faster speed");
        }
        
    }
}
