using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public void LoadScene(string scene)
    {
        print("Scene load requested for " + scene);
        SceneManager.LoadScene(scene);
    }

    public void QuitRequest()
    {
        print("Quit game requested");
    }
}
