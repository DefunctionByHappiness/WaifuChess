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

    void BoardSetup() {
        boardHolder = new GameObject("Board").transform;
        gridPositions.Clear();

        bool white = false;

        for (int x = 0; x < rows; x++)
        {
            for (int y = 0; y < columns; y++)
            {
                GameObject toInstantiate;
                if (white) {
                    toInstantiate = whiteTiles;
                } else {
                    toInstantiate = blackTiles;
                }
                gridPositions.Add(new Vector3(x, y, 0f));
                GameObject instance = Instantiate(toInstantiate, new Vector3(x, y, 0f), Quaternion.identity) as GameObject;
                instance.transform.SetParent(boardHolder);   
                white = !white;

            }
            white = !white;
        }
    }

    public void SetupScene(){
        BoardSetup();
    }
}
