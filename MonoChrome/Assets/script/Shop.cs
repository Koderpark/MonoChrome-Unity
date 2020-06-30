using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;

public class Shop : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("id"))
        {
            //id.text = PlayerPrefs.GetString("id");
            //bgm.value = PlayerPrefs.GetFloat("bgm");
            //sfx.value = PlayerPrefs.GetFloat("sfx");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
