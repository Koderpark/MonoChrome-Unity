using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    public FloatingJoystick movestick;
    public FloatingJoystick aimstick;
    public Rigidbody rb;
    private SpriteRenderer srender;

    // Start is called before the first frame update
    void Start()
    {
        srender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = new Vector3(movestick.Horizontal, movestick.Vertical, 0);
        Vector3 aimdir = new Vector3(aimstick.Horizontal, aimstick.Vertical, 0);
        rb.AddForce(direction * speed * Time.fixedDeltaTime);
        if (rb.velocity.x > 5f) { Vector3 v = rb.velocity; v.x = 5f; rb.velocity = v; }
        if (rb.velocity.y > 5f) { Vector3 v = rb.velocity; v.y = 5f; rb.velocity = v; }
        
        if (rb.velocity.x < -5f) { Vector3 v = rb.velocity; v.x = -5f; rb.velocity = v; }
        if (rb.velocity.y < -5f) { Vector3 v = rb.velocity; v.y = -5f; rb.velocity = v; }

        if     (aimstick.Horizontal  != 0 && aimstick.Vertical  != 0) { transform.rotation = Quaternion.FromToRotation(Vector3.up, aimdir); }
        else if(movestick.Horizontal != 0 && movestick.Vertical != 0) { transform.rotation = Quaternion.FromToRotation(Vector3.up, direction); }
    }
}
