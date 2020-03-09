using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private BoardManager boardScript;                        //Store a reference to our BoardManager which will set up the level.
    public static GameManager instance = null;                //Static instance of GameManager which allows it to be accessed by any other script.

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
    }

    // Update is called once per frame
    void Update()
    {

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
