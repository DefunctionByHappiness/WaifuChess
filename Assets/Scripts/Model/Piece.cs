using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Piece : MonoBehaviour
{
    private int playerNum;

    public Piece(){

    }

    public int getY(){
        return (int) gameObject.transform.position.y;
    }

    public int getX(){
        return (int) gameObject.transform.position.x;
    }

    public int getPlayer(){
        return this.playerNum;
    }

    public abstract bool moveInsideLimits(float col, float row);

    public abstract List<Square> validMovements();

    public void move(float col, float row) {
        gameObject.transform.position = new Vector3(col, row, -1.0f);
    }

    public void setPlayer(int player) {
        this.playerNum = player;
    }

}
