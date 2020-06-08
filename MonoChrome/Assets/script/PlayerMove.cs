using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public FixedJoystick movestick;
    public FixedJoystick aimstick;
    public Rigidbody rb;
    private SpriteRenderer srender;

    void Start()
    {
        srender = GetComponent<SpriteRenderer>();
    }
    // Update is called once per frame
    public void FixedUpdate()
    {
        try
        {
            Vector3 direction = new Vector3(movestick.Horizontal, movestick.Vertical, 0);  
            transform.Translate(direction * speed * Time.fixedDeltaTime);
            if(aimstick.Horizontal != 0 && aimstick.Vertical != 0)
            {
                if (aimstick.Horizontal >= 0) srender.flipX = false;
                else srender.flipX = true;
            }
        }
        catch( NullReferenceException e )
        {
            Console.WriteLine("버그발생"+e.Message);
        }

    }
}
