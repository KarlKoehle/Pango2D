using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuCredits : MonoBehaviour
{
    public void ChangeScene (string changeTo)
    {
        SceneManager.LoadScene("Credits", LoadSceneMode.Single);
    }
}
