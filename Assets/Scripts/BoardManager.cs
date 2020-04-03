﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardManager : MonoBehaviour
{
    public int columns = 8;
    public int rows = 8;

    private Transform boardHolder;
    private Transform piecesHolder;

    private Transform specialBoardHolder;
    private List<Vector3> gridPositions = new List<Vector3>();

    private List<GameObject> piecesList = new List<GameObject>();

    /*  Y
        |
        07 17 27 37 47 57 67 77
        06 16 26 36 46 56 66 76 PEONES
        05 15 25 35 45 55 65 75
        04 14 24 34 44 54 64 74
        03 13 23 33 43 53 63 73
        02 12 22 32 42 52 62 72 PEONES
        01 11 21 31 41 51 61 71
        00 10 20 30 40 50 60 70 -- X
    */

    public GameObject whiteTiles;
    public GameObject blackTiles;

    public GameObject redTiles;

    public GameObject blueTiles;

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

    public void movePieces(Square from, Square target){

        GameObject obj = this.piecesList.Find(piece => (piece.transform.position.x == from.getX() && piece.transform.position.y == from.getY()));
        obj.transform.position =  new Vector3(target.getX(), target.getY(), -1f);
    }

    public bool eatPieces(Square from, Square target){

        bool checkMate = false;

        GameObject eaten = this.piecesList.Find(piece => (piece.transform.position.x == target.getX() && piece.transform.position.y == target.getY()));
        if (string.Equals(eaten.name.Split('_')[1], "WhiteKing") || string.Equals(eaten.name.Split('_')[1], "BlackKing")) {
            checkMate = true;
        }
        this.piecesList.Remove(eaten);
        Destroy(eaten);

        GameObject obj = this.piecesList.Find(piece => (piece.transform.position.x == from.getX() && piece.transform.position.y == from.getY()));
        obj.transform.position =  new Vector3(target.getX(), target.getY(), -1f);

        return checkMate;
    }

    public void createSpecialSquare(int x, int y, int s) {

        GameObject toInstantiate;
        if (s == 0) {
            toInstantiate = blueTiles;
        } else {
            toInstantiate = redTiles;
        }
        GameObject instance = Instantiate(toInstantiate, new Vector3(x, y, -1.2f), Quaternion.identity) as GameObject;
        instance.transform.SetParent(specialBoardHolder);
    }

    public void clearSpecialSquares() {

        foreach (Transform child in specialBoardHolder.transform) {
            GameObject.Destroy(child.gameObject);
        }
    }


    void PiecesSetup() {

        piecesHolder = new GameObject("Pieces").transform;
        GameObject toInstatiateWhite;
        GameObject toInstatiateBlack;
        GameObject instance;

        for (int y = 0; y < columns; y++)
        {
            toInstatiateWhite = whitePawn;
            instance = Instantiate(toInstatiateWhite, new Vector3(y, 1, -1f), Quaternion.identity) as GameObject;
            instance.transform.SetParent(piecesHolder);
            instance.name = "Piece_WhitePawn_1_"+y;
            piecesList.Add(instance);

            toInstatiateBlack = blackPawn;
            instance = Instantiate(toInstatiateBlack, new Vector3(y, 6, -1f), Quaternion.identity) as GameObject;
            instance.transform.SetParent(piecesHolder);
            instance.name = "Piece_BlackPawn_2_"+y;
            piecesList.Add(instance);

            switch (y)
            {
                case 0:
                    toInstatiateWhite = whiteRook;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_WhiteRook_1_1";
                    piecesList.Add(instance);

                    toInstatiateBlack = blackRook;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_BlackRook_2_1";
                    piecesList.Add(instance);

                    break;
                case 1:
                    toInstatiateWhite = whiteKnight;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_WhiteKnight_1_1";
                    piecesList.Add(instance);

                    toInstatiateBlack = blackKnight;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_BlackKnight_2_1";
                    piecesList.Add(instance);

                    break;
                case 2:
                    toInstatiateWhite = whiteBishop;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_WhiteBishop_1_1";
                    piecesList.Add(instance);

                    toInstatiateBlack = blackBishop;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_BlackBishop_2_1";
                    piecesList.Add(instance);

                    break;
                case 3:
                    toInstatiateWhite = whiteQueen;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_WhiteQueen_1_1";
                    piecesList.Add(instance);

                    toInstatiateBlack = blackQueen;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_BlackQueen_2_1";
                    piecesList.Add(instance);

                    break;
                case 4:
                    toInstatiateWhite = whiteKing;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_WhiteKing_1_1";
                    piecesList.Add(instance);

                    toInstatiateBlack = blackKing;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_BlackKing_2_1";
                    piecesList.Add(instance);

                    break;
                case 5:
                    toInstatiateWhite = whiteBishop;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_WhiteBishop_1_2";
                    piecesList.Add(instance);

                    toInstatiateBlack = blackBishop;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_BlackBishop_2_2";
                    piecesList.Add(instance);

                    break;
                case 6:
                    toInstatiateWhite = whiteKnight;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_WhiteKnight_1_2";
                    piecesList.Add(instance);

                    toInstatiateBlack = blackKnight;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_BlackKnight_2_2";
                    piecesList.Add(instance);

                    break;
                case 7:
                    toInstatiateWhite = whiteRook;
                    instance = Instantiate(toInstatiateWhite, new Vector3(y, 0, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_WhiteRook_1_2";
                    piecesList.Add(instance);

                    toInstatiateBlack = blackRook;
                    instance = Instantiate(toInstatiateBlack, new Vector3(y, 7, -1f), Quaternion.identity) as GameObject;
                    instance.transform.SetParent(piecesHolder);
                    instance.name = "Piece_BlackRook_2_2";
                    piecesList.Add(instance);

                    break;
            }
        }

        foreach (GameObject o in piecesList)
        {
            o.transform.hasChanged = false;
        }

    }

    public void SetupScene() {

        BoardSetup();
        PiecesSetup();
        specialBoardHolder = new GameObject("SpecialBoard").transform;

    }

    public void ClearScene() {
        foreach (Transform child in boardHolder.transform) {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Transform child in piecesHolder.transform) {
            GameObject.Destroy(child.gameObject);
        }
        foreach (Transform child in specialBoardHolder.transform) {
            GameObject.Destroy(child.gameObject);
        }

        gridPositions = new List<Vector3>();
        piecesList = new List<GameObject>();
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
