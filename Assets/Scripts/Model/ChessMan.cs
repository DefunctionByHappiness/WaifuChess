using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChessMan : Piece
{
    ChessMan chessmanType;
    public ChessMan(int col, int row, int player){
        base(col, row, player);
    }

    public getCol(){
        base.getCol();
    }

    public getRow(){
        base.getRow();
    }

    public getPlayer(){
        base.getPlayer();
    }

    public ChessMan getChessmanType(){
        this.chessmanType;
    }

    public override bool moveInsideLimits(int col, int row) {

        return true;
    }

    // Implement in each ChessMan
    public override ArrayList<Square> validMovements() {

        return ArrayList<Square> List;
    }

    public bool canMove(int col, int row){

    }

    protected void visitableSquares() {

    }

        protected void visitableSquare() {
        
    }

}
