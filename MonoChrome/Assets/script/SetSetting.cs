using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Configuration;
using System.Xml;
using System.Diagnostics;
using System.Runtime.Versioning;
using UnityEngine.SceneManagement;

public class SetSetting : MonoBehaviour
{
    public InputField playername;
    public Scrollbar bgm;
    public Scrollbar sfx;

    private void Start()
    {
        TextAsset txt = (TextAsset)Resources.Load("setting");
        XmlDocument setxml = new XmlDocument();
        setxml.LoadXml(txt.text);

        playername.text = setxml.GetElementsByTagName("playerName")[0].InnerText;
        bgm.value = float.Parse(setxml.GetElementsByTagName("bgm")[0].InnerText);
        sfx.value = float.Parse(setxml.GetElementsByTagName("sfx")[0].InnerText);

        UnityEngine.Debug.Log("test");
    }
    public void SettingExit()
    {
        TextAsset txt = (TextAsset)Resources.Load("setting");
        XmlDocument xml = new XmlDocument();
        xml.LoadXml(txt.text);

        xml.GetElementsByTagName("playerName")[0].InnerText = playername.text;
        xml.GetElementsByTagName("bgm")[0].InnerText = bgm.value.ToString();
        xml.GetElementsByTagName("sfx")[0].InnerText = sfx.value.ToString();

        xml.Save("./Assets/Resources/setting.xml");
        SceneManager.LoadScene("MainScene");
    }
}
