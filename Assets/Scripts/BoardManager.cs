using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int columns = 8;
    public int rows = 8;

    private Transform boardHolder;
    private Transform piecesHolder;
    private List<Vector3> gridPositions = new List<Vector3>();

    private List<GameObject> piecesList = new List<GameObject>();

    public GameObject whiteTiles;
    public GameObject blackTiles;

    // All the references of the individual Chessmans
    public GameObject whiteRook;
    public GameObject whiteKnight;
    public GameObject whiteBishop;
    public GameObject whiteKing;
    public GameObject whiteQueen;
    public GameObject whitePawn;

    public GameObject blackRook;
    public GameObject blackKnight;
    public GameObject blackBishop;
    public GameObject blackKing;
    public GameObject blackQueen;
    public GameObject blackPawn;


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

    void PiecesSetup() {

        piecesHolder = new GameObject("Pieces").transform;

        for (int y = 0; y < columns; y++)
        {
            GameObject toInstatiateWhite = whitePawn;
            GameObject instance = Instantiate(toInstatiateWhite, new Vector3(y, 1, -1f), Quaternion.identity) as GameObject;
            instance.transform.SetParent(piecesHolder);
            piecesList.Add(instance);

            GameObject toInstatiateBlack = blackPawn;
            instance = Instantiate(toInstatiateBlack, new Vector3(y, 6, -1f), Quaternion.identity) as GameObject;
            instance.transform.SetParent(piecesHolder);
            piecesList.Add(instance);

            switch (y)
            {
                case 0:
                    toInstatiateWhite = whiteRook;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    toInstatiateBlack = blackRook;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    break;
                case 1:
                    toInstatiateWhite = whiteKnight;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    toInstatiateBlack = blackKnight;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    break;
                case 2:
                    toInstatiateWhite = whiteBishop;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    toInstatiateBlack = blackBishop;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    break;
                case 3:
                    toInstatiateWhite = whiteQueen;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    toInstatiateBlack = blackQueen;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    break;
                case 4:
                    toInstatiateWhite = whiteKing;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    toInstatiateBlack = blackKing;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    break;
                case 5:
                    toInstatiateWhite = whiteBishop;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    toInstatiateBlack = blackBishop;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    break;
                case 6:
                    toInstatiateWhite = whiteKnight;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    toInstatiateBlack = blackKnight;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    break;
                case 7:
                    toInstatiateWhite = whiteRook;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    toInstatiateBlack = blackRook;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    piecesList.Add(instance);

                    break;
            }
        }

    }

    public void SetupScene(){

        BoardSetup();
        PiecesSetup();

    }

    public int CheckPosition(int x, int y) {

        GameObject obj = this.piecesList.Find(piece => (piece.transform.position.x == x && piece.transform.position.y == y));
        int result = 0;
        if (obj != null) {
            result = obj.GetComponent<ChessMan>().getPlayer();
        }
        return result;
    }

}
