using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text textmenu;
    public int multiplier;
    public float counter;

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        counter += Time.deltaTime * multiplier;
        textmenu.text = Mathf.Round(counter).ToString();
    }
}
