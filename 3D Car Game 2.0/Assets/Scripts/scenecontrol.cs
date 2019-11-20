using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class scenecontrol : MonoBehaviour
{

    public void changelevel(string s)
    {
        SceneManager.LoadScene(s);
    }

    public void exitGame()
    {
        Application.Quit();
    }



}
