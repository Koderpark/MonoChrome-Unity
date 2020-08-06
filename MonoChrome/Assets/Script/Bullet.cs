using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    void Start() {
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.AddRelativeForce(Vector3.up * 2000 * Time.fixedDeltaTime, ForceMode.Impulse);
    }
    void OnTriggerEnter(Collider col) {
        if (col.tag == "BorderBullet") {
            Destroy(gameObject);
        }
        
    }
}
