using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Knight : ChessMan
{
    public int player;
    public Knight() {

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

        // Superior Derecha 1
        auxP = base.isEmptySquare(actualX + 1, actualY + 2);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX + 1, actualY + 2});
        }

        // Superior Derecha 2
        auxP = base.isEmptySquare(actualX + 2, actualY + 1);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX + 2, actualY + 1});
        }

        // Superior Izquierda 1
        auxP = base.isEmptySquare(actualX - 1, actualY + 2);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX - 1, actualY + 2});
        }
        // Superior Izquierda 2
        auxP = base.isEmptySquare(actualX - 2, actualY + 1);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX - 2, actualY + 1});
        }

        // Inferior Derecha 1
        auxP = base.isEmptySquare(actualX + 2, actualY - 1);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX + 2, actualY - 1});
        }

        // Inferior Derecha 2
        auxP = base.isEmptySquare(actualX + 1, actualY - 2);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX + 1, actualY - 2});
        }

        // Inferior Izquierda 1
        auxP = base.isEmptySquare(actualX - 2, actualY - 1);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX - 2, actualY - 1});
        }

        // Inferior Izquierda 2
        auxP = base.isEmptySquare(actualX - 1, actualY - 2);
        if (auxP != this.player) {
            slotsAndPlayer.Add(new int[] {auxP, actualX - 1, actualY - 2});
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
