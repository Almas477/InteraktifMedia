using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour
{
    // Start is called before the first frame update
    public void KAMUS()
    {
        SceneManager.LoadSceneAsync("MenuScene");
    }

    // Update is called once per frame
    public void KATAHARIAN()
    {
        SceneManager.LoadSceneAsync("MenuScene");
    }

    public void GAME()
    {
        SceneManager.LoadSceneAsync("MenuScene");
    }

    public void backButton()
    {
        SceneManager.LoadSceneAsync("StartScene");
    }

    public void JawabanA()
    {
        SceneManager.LoadSceneAsync("SceneBenar");
    }

    public void JawbanB()
    {
        SceneManager.LoadSceneAsync("SceneSalah");
    }

    public void JawbanC()
    {
        SceneManager.LoadSceneAsync("SceneSalah");
    }

    public void JawbanD()
    {
        SceneManager.LoadSceneAsync("SceneSalah");
    }

    public void Kembali()
    {
        SceneManager.LoadSceneAsync("StartScene");
    }
}
