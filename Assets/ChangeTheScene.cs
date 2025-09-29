using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTheScene : MonoBehaviour
{
    public void ChangeToNextScene()
    {
    UnityEngine.SceneManagement.SceneManager.LoadScene("MUSEUM SCENE 1");
    }
}
