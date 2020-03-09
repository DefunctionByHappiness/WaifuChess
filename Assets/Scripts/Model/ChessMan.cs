using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessMan : Piece
{
    public ChessMan() : base(){

    }
/*
    public int getCol(){
        return base.getCol();
    }

    public int getRow(){
        return base.getRow();
    }

    public int getPlayer(){
        return base.getPlayer();
    }

*/
    public override bool moveInsideLimits(float col, float row) {

        if((col < 8 && col >= 0) && (row < 8 && row >= 0) ) {
            return true;
        }
        return false;
    }

    // Implement in each ChessMan

    public override List<Square> validMovements() {
        List<Square> list = new List<Square>();
        return list;
    }

    // Check if the square is empty, and returns 0 if empty, 1 if player 1 Chessman or 2 if player 2 Chessman.
    public int isEmptySquare(int row, int col){

        GameObject gc = GameObject.FindGameObjectWithTag("GameController");
        return gc.GetComponent<BoardManager>().CheckPosition(row, col);

    }

    protected void visitableSquares() {

    }

        protected void visitableSquare() {

    }

}
