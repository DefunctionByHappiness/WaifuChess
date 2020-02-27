using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int columns = 8;
    public int rows = 8;

    private Transform boardHolder;
    private List<Vector3> gridPositions = new List<Vector3>();

    public GameObject whiteTiles;
    public GameObject blackTiles;

    void InitializeList() {
        gridPositions.Clear();

        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {   
                gridPositions.Add(new Vector3(x, y, 0f));
            }
        }
    }

    void BoardSetup() {
        boardHolder = new GameObject("Board").transform;

        for (int x = -1; x < rows + 1; x++)
        {
            for (int y = -1; y < columns + 1; y++)
            {
                /*
                GameObject toInstantiate  = floorTiles[Random.Range(0, floorTiles.Length)];
                if(x == -1 || x == rows || y == -1 || y == columns) 
                    toInstantiate = outerWallTiles[Random.Range (0, outerWallTiles.Length)];
                GameObject instance = Instantiate(toInstantiate, new Vector3 (x, y, 0f), Quaternion.identity) as GameObject;
                instance.transform.SetParent(boardHolder);   
                */   
            }
        }
    }

    public void SetupScene(){
        BoardSetup();
        InitializeList();
    }
}
