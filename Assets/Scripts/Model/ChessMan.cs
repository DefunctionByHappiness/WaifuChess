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

    public ChessMan getChessmanType(){
        return this.chessmanType;
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
    

    public bool canMove(int col, int row){
        return true;
    }

    protected void visitableSquares() {

    }

        protected void visitableSquare() {
        
    }

}
