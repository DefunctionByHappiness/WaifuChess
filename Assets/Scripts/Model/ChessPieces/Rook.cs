using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rook : ChessMan
{
    public int player;
    public Rook() {

    }

    /// Awake is called when the script instance is being loaded.
    void Awake()
    {
        base.setPlayer(this.player);
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

        int actualX = base.getX();
        int actualY = base.getY();

        List<int[]> slotsAndPlayer = new List<int[]>();
        bool finishedX = false;
        bool finishedY = false;
        int x = actualX;
        int y = actualY;

        // Movimiento superior y derecho
        while (!finishedX || !finishedY) {
            // DERECHA
            if (!finishedX && actualX != 7) {
                x++;
                int auxP = base.isEmptySquare(x, actualY);

                if (auxP != this.player)  {
                    slotsAndPlayer.Add(new int[] {auxP, x, actualY});
                }

                if (x == 7 || auxP != 0) {
                    finishedX = true;
                }
            } else finishedX = true;
            // ARRIBA
            if (!finishedY  && actualY != 7) {
                y++;
                int auxP = base.isEmptySquare(actualX, y);

                if (auxP != this.player)  {
                    slotsAndPlayer.Add(new int[] {auxP, actualX, y});
                }

                if (y == 7 || auxP != 0) {
                    finishedY = true;
                }
            } else finishedY = true;
        }

        finishedX = false;
        finishedY = false;
        x = actualX;
        y = actualY;
        // Movimiento inferior e izquierdo
        while (!finishedX || !finishedY) {
            //IZQUIERDA
            if (!finishedX && actualX != 0) {
                x--;
                int auxP = base.isEmptySquare(x, actualY);

                if (auxP != this.player)  {
                    slotsAndPlayer.Add(new int[] {auxP, x, actualY});
                }

                if (x == -1 || auxP != 0) {
                    finishedX = true;
                }
            } else finishedX = true;
            // ABAJO
            if (!finishedY && actualY != 0) {
                y--;
                int auxP = base.isEmptySquare(actualX, y);

                if (auxP != this.player)  {
                    slotsAndPlayer.Add(new int[] {auxP, actualX, y});
                }

                if (y == -1 || auxP != 0) {
                    finishedY = true;
                }
            } else finishedY = true;
        }

        foreach (int[] nums in slotsAndPlayer) {

            //if (nums[0] == 0 || nums[0] != this.player) {

                if (base.moveInsideLimits(nums[1], nums[2])){
                    Square s = new Square(nums[0], nums[1], nums[2]);
                    list.Add(s);
                }
            //}
        }

        return list;
    }

}
