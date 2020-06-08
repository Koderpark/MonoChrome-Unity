using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetSetting : MonoBehaviour
{
    public InputField id;
    public Scrollbar bgm;
    public Scrollbar sfx;

    void Start()
    {
        if (PlayerPrefs.HasKey("id"))
        {
            id.text = PlayerPrefs.GetString("id");
            bgm.value = PlayerPrefs.GetFloat("bgm");
            sfx.value = PlayerPrefs.GetFloat("sfx");
        }
    }
    public void SettingExit()
    {
        PlayerPrefs.SetString("id", id.text);
        PlayerPrefs.SetFloat("bgm", bgm.value);
        PlayerPrefs.SetFloat("sfx", sfx.value);
        SceneManager.LoadScene("MainScene");
    }
}
