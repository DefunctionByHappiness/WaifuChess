using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class King : ChessMan
{
    public int player;
    public King() {

    }

    /// Awake is called when the script instance is being loaded.
    void Awake()
    {
        base.setPlayer(this.player);
    }

    // Start is called before the first frame update
    void Start()
    {
        base.setPlayer(player);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public override List<Square> validMovements() {

        List<Square> list = new List<Square>();

        int actualX = base.getX();
        int actualY = base.getY();

        int auxP;

        List<int[]> slotsAndPlayer = new List<int[]>();

        // Superior
        auxP = base.isEmptySquare(actualX, actualY + 1);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX, actualY + 1});
        }

        // Superior Derecha
        auxP = base.isEmptySquare(actualX + 1, actualY + 1);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX + 1, actualY + 1});
        }

        // Derecha
        auxP = base.isEmptySquare(actualX + 1, actualY);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX + 1, actualY});
        }
        // Inferior Derecha
        auxP = base.isEmptySquare(actualX + 1, actualY - 1);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX + 1, actualY - 1});
        }

        // Inferior
        auxP = base.isEmptySquare(actualX, actualY - 1);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX, actualY - 1});
        }

        // Inferior Izquierda
        auxP = base.isEmptySquare(actualX - 1, actualY - 1);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX - 1, actualY - 1});
        }

        // Izquierda
        auxP = base.isEmptySquare(actualX - 1, actualY);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX - 1, actualY});
        }

        // Superior Izquierda
        auxP = base.isEmptySquare(actualX - 1, actualY + 1);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX - 1, actualY + 1});
        }

        foreach (int[] nums in slotsAndPlayer) {

                if (base.moveInsideLimits(nums[1], nums[2])){
                    Square s = new Square(nums[0], nums[1], nums[2]);
                    list.Add(s);
                }
        }

        return list;
    }

}
