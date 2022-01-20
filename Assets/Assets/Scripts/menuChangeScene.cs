using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuChangeScene : MonoBehaviour
{
    public void ChangeScene (string changeTo)
    {
        SceneManager.LoadScene("Level01", LoadSceneMode.Single);
    }
}
