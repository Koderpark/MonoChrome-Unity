using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class PopRender : MonoBehaviour
{
    public GameObject pop;
    public void popup()
    {
        Time.timeScale = 0f;
        pop.SetActive(true);
    }
    public void popdown()
    {
        Time.timeScale = 1f;
        pop.SetActive(false);
    }
}
