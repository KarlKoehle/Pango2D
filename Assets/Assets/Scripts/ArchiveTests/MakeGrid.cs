using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeGrid : MonoBehaviour
{

    [SerializeField] GameObject tilePrefabWhite = null;
    [SerializeField] GameObject tilePrefabBlack = null;
    [SerializeField] int columns = 14;
    [SerializeField] int rows = 14;
    [SerializeField] float drawDelay = 0.002f;

    Vector3 startPosition;


    void Start()
    {
        startPosition = transform.position;

        StartCoroutine(CreateGrid());
    }

    private IEnumerator CreateGrid()
    {
        bool isBlack = true;
        
        for (int column = 0; column < columns; column++)
        { 
            for (int row = 0; row < rows; row++)
            {
                if (isBlack)
                {
                    Instantiate(tilePrefabBlack, new Vector3(row, column, 0) + transform.position, Quaternion.Euler(0f, 0f, 0f), transform);
                }
                else
                {
                    Instantiate(tilePrefabWhite, new Vector3(row, column, 0) + transform.position, Quaternion.Euler(0f, 0f, 0f), transform);
                }

               isBlack = !isBlack;

                yield return new WaitForSeconds(drawDelay);
               
            }
            //if the grid has an even number of rows, switch colors.
            if (rows % 2 == 0)
            {
                isBlack = !isBlack;
            }
        }

    }
}
