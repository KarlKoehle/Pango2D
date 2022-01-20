using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuMainMenu : MonoBehaviour
{
    public void ChangeScene (string changeTo)
    {
        SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
    }
}
