using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class PlayerMovement : MonoBehaviour
{
 
    private float timer;

    public Rigidbody rb;

    public float forwardForce;

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        {
            timer += Time.deltaTime;
            if (timer > 1f)
            {
                forwardForce++;
                timer = 0.6f;
            }

        }

    }
    
}
