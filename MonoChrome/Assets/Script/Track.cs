using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Diagnostics;
using UnityEngine;

public class CamTrack : MonoBehaviour
{
    public GameObject player;
    void Update()
    {
        transform.position = new Vector3(player.transform.position.x , player.transform.position.y, -10);
    }
}
