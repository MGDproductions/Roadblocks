using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private float timer;
    public float SidewaysSpeed;
    public float ForwardSpeed;
    public static bool Leftbutton = false;
    public GameObject speedup;

    public static bool Speedbutton = false;

    public void Speedpressed()
    {
        Speedbutton = true;
    }

    public static bool Dead = false;

    public void Die()
    {
        Dead = true;
    }

    void Start()
    {
        Speedbutton = false;
        Dead = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Dead != true){

            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.position.x > Screen.width / 2)
                {
                    transform.Translate(Time.deltaTime * SidewaysSpeed, 0, 0);
                }

                if (touch.position.x < Screen.width / 2)
                {
                    transform.Translate(-Time.deltaTime * SidewaysSpeed, 0, 0);
                }
            }
            else if (Input.GetMouseButton(0))
            {
                if (Input.mousePosition.x > Screen.width / 2)
                {
                    transform.Translate(Time.deltaTime * SidewaysSpeed, 0, 0);
                }

                if (Input.mousePosition.x < Screen.width / 2)
                {
                    transform.Translate(-Time.deltaTime * SidewaysSpeed, 0, 0);
                }
            }
            else
            {
                if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
                {
                    transform.Translate(-Time.deltaTime * SidewaysSpeed, 0, 0);
                }

                if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
                {
                    transform.Translate(Time.deltaTime * SidewaysSpeed, 0, 0);
                }
            }

            if (Speedbutton == true)
            {
                speedup.SetActive(false);
                ForwardSpeed = 2000;
                SidewaysSpeed = 500;
                Speedbutton = false;
            }
            transform.Translate(0, 0, Time.deltaTime * ForwardSpeed);

            ForwardSpeed += 30 * Time.deltaTime;
            SidewaysSpeed += 5 * Time.deltaTime;

        }
    }

}
