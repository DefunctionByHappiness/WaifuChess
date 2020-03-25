using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private BoardManager boardScript;                        //Store a reference to our BoardManager which will set up the level.
    public static GameManager instance = null;                //Static instance of GameManager which allows it to be accessed by any other script.

    private bool moveActive;
    private Square selectedPiece;

    void Awake()
    {
        //Check if instance already exists
        if (instance == null)

            //if not, set instance to this
            instance = this;

        //If instance already exists and it's not this:
        else if (instance != this)

            //Then destroy this. This enforces our singleton pattern, meaning there can only ever be one instance of a GameManager.
            Destroy(gameObject);

        //Sets this to not be destroyed when reloading scene
        DontDestroyOnLoad(gameObject);

        //enemies = new List<Enemy>();

        //Get a component reference to the attached BoardManager script
        boardScript = GetComponent<BoardManager>();

        //Call the InitGame function to initialize the first level
        InitGame();

        moveActive = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)){ // if left button pressed...
            Collider2D col = Physics2D.OverlapPoint(Camera.main.ScreenToWorldPoint(Input.mousePosition));

            if (col != null) {
                if (string.Equals(col.name.Substring(0,5), "Piece")) {
                    ChessMan l;
                    if ((l = col.gameObject.GetComponent(typeof(ChessMan)) as ChessMan) != null) {

                        boardScript.clearSpecialSquares();
                        moveActive = true;

                        setSelectedPiece(l.getPlayer(), l.getX(), l.getY());

                        List<Square> s = l.validMovements();

                        foreach (Square square in s)
                        {
                            boardScript.createSpecialSquare(square.getX(), square.getY(), square.getPlayer());
                        }
                        Debug.Log(col.name);
                        //Do something...
                    }

                }else if (string.Equals(col.name.Substring(0,8), "BlueTile")) {
                    Debug.Log("BlueTile");
                    Square target = new Square(0, (int) col.transform.position.x, (int) col.transform.position.y);
                    boardScript.movePieces(this.selectedPiece, target);
                    deactiveMove();
                } else if (string.Equals(col.name.Substring(0,7), "RedTile")) {
                    Debug.Log("RedTile");
                    Square target = new Square(0, (int) col.transform.position.x, (int) col.transform.position.y);
                    boardScript.eatPieces(this.selectedPiece, target);
                    deactiveMove();
                }
            } else {
                if (moveActive) {
                    deactiveMove();
                }
            }
        }

    }

    private void deactiveMove(){
        boardScript.clearSpecialSquares();
        moveActive = false;
        unsetSelectedPiece();
    }

    private void setSelectedPiece(int p, int x, int y){
        this.selectedPiece = new Square(p, x, y);
    }

    private void unsetSelectedPiece() {
        this.selectedPiece = null;
    }

    public void GameOver() {
        //TODO: Setup GameOver logic
        enabled = false;
    }

    //Initializes the game for each level.
    void InitGame()
    {
        //TODO: Clear Chess pieces
        //enemies.Clear();
        //Call the SetupScene function of the BoardManager script, pass it current level number.
        boardScript.SetupScene();
    }

    public int CheckPosition(int x, int y) {
        return boardScript.CheckPosition(x, y);
    }
}
