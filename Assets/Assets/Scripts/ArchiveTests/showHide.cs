using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class showHide : MonoBehaviour
{
    public GameObject Square;

    void Start()
    {
        
    }


    void Update()
    {
        
    }

    public void whenButtonClicked()
    {
        if (Square.activeInHierarchy == true)
        {
            Square.SetActive(false);
        }
        else
        {
            Square.SetActive(true);
        }
    }



}
