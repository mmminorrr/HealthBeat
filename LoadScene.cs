using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public GestureSourceManager getLoadScene;

    public void LoadSceneInfo(string GameScene_Health)
    {
        if(getLoadScene.loadScene == true)
        {
            Debug.Log("********** LOAD SCENE **********");
            SceneManager.LoadScene(GameScene_Health);
        }

    }

    /*public void ExitGame()
    {
        Application.Quit();
    }*/
}
