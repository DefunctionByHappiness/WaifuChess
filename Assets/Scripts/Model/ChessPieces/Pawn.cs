using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : ChessMan
{
    public Pawn(int col, int row, int player){
        base(col, row, player);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override ArrayList<Square> validMovements() {

        return ArrayList<Square> List;
    }

}
