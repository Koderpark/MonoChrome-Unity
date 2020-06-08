using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveScene : MonoBehaviour
{
    public void ChangeMain() { SceneManager.LoadScene("MainScene"); }
    public void ChangeShop() { SceneManager.LoadScene("ShopScene"); }
    public void ChangeGame() { SceneManager.LoadScene("GameScene"); }
    public void ChangeRank() { SceneManager.LoadScene("RankScene"); }
    public void ChangeSett() { SceneManager.LoadScene("SettingScene");  }
}
