using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading;
using UnityEngine;

public class Aim : MonoBehaviour
{

    public FixedJoystick aimstick;
    public GameObject gunbox;
    private SpriteRenderer srender;
    // Start is called before the first frame update
    void Start()
    {
        srender = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if(aimstick.Horizontal != 0 && aimstick.Vertical != 0 && Time.timeScale == 1f)
        {
            if (aimstick.Horizontal >= 0) srender.flipY = false;
            else srender.flipY = true;

            float angle = Mathf.Atan2(aimstick.Vertical, aimstick.Horizontal) * Mathf.Rad2Deg;
            gunbox.transform.rotation = Quaternion.Euler(0, 0, angle);
        }
    }
}
