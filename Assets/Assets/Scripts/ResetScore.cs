using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetScore : MonoBehaviour
{
    ScoreManager ScoreValue;
    
    public static int lifeValue;

    // Start is called before the first frame update
    void Start()
    {
        ScoreManager.scoreValue = 0;
        ScoreManager.lifeValue = 1;
    }
      
}



