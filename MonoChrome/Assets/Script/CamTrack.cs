using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class Track : MonoBehaviour
{
    public int posz;
    public GameObject player;
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x , player.transform.position.y, posz);
    }
}
