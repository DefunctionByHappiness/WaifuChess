using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : ChessMan
{
    public Queen(int col, int row, int player) : base(col, row, player){
        
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override List<Square> validMovements() {
        List<Square> list = new List<Square>();
        return list;
    }

}

