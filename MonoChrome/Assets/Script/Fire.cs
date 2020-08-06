using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public GameObject bullet;
    //public bool isUltimateSkill;
    public FloatingJoystick aimstick;

    public float FireDelay;
    private bool FireState;
    void Start()
    {
        FireState = true;
    }

    void Update()
    {
        if (aimstick.Horizontal != 0 && aimstick.Vertical != 0) {
            if (FireState) {
                Vector3 bulletpos = transform.position;
                bulletpos.z = 0;
                StartCoroutine(FireCycle());
                GameObject instance = Instantiate(bullet, bulletpos, transform.rotation) as GameObject;
            }
        }
    }
    IEnumerator FireCycle() {
        FireState = false;
        yield return new WaitForSeconds(FireDelay); 
        FireState = true; 
    }
}
