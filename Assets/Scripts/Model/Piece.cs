using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Piece : MonoBehaviour
{
    int row;
    int col;
    int player;

    public Piece(int row, int col, int player){
        this.row = row;
        this.col = col;
        this.player = player;
    }

    public int getCol(){
        return this.col;
    }

    public int getRow(){
        return this.row;
    }

    public int getPlayer(){
        return this.player;
    }

    public abstract bool moveInsideLimits(int col, int row);

    public abstract List<Square> validMovements();

    public void move(int col, int row) {
        this.col = col;
        this.row = row;
    }
}
