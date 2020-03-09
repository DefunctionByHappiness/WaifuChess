using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessMan : Piece
{
    public ChessMan(int col, int row, int player) : base(col, row, player){
       
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
    public override bool moveInsideLimits(int col, int row) {

        return true;
    }

    // Implement in each ChessMan
    
    public override List<Square> validMovements() {
        List<Square> list = new List<Square>();
        return list;
    }
    
    // Check if the square is empty, and returns 0 if empty, 1 if player 1 Chessman or 2 if player 2 Chessman.
    public int isEmptySquare(int col, int row){
        return 1;
    }

    protected void visitableSquares() {

    }

        protected void visitableSquare() {
        
    }

}
