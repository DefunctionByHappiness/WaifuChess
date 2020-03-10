using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pawn : ChessMan
{
    public int player;
    public Pawn() {

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
        List<Square> movements =  validMovements();
    }

    public override List<Square> validMovements() {

        List<Square> list = new List<Square>();

        // Puedes llamar a esta función para comprobar si en una posición del grid hay algo (devolverá 0 en ese caso) o en caso de haber algo, a qué jugador pertenece (1 o 2, dependiendo del jugador)
        // Puedes comprobar directamente el jugador al que pertece esta ficha llamando a this.player o a base.getPlayer();

        int modifier = 1;

        int actualX = base.getX();
        int actualY = base.getY();

        List<int[]> slotsAndPlayer = new List<int[]>();

        if (this.player == 2) {
            modifier *= -1;
        }

        int auxP = base.isEmptySquare(actualX, actualY + modifier);

        if (auxP == 0) {
            slotsAndPlayer.Add(new int[] {auxP, actualX, actualY + modifier});

            if (!gameObject.transform.hasChanged) {
                modifier *= 2;
                auxP = base.isEmptySquare(actualX, actualY + modifier);
                if (auxP == 0)
                {
                    slotsAndPlayer.Add(new int[] {auxP, actualX, actualY + modifier});
                }
                modifier /=2;
            }
        }

        auxP = base.isEmptySquare(actualX + 1, actualY + modifier);
        if (auxP != this.player && auxP != 0){
            slotsAndPlayer.Add(new int[] {base.isEmptySquare(actualX + 1, actualY + modifier), actualX + 1, actualY + modifier});
        }

        auxP = base.isEmptySquare(actualX - 1, actualY + modifier);
        if (auxP != this.player && auxP != 0){
            slotsAndPlayer.Add(new int[] {base.isEmptySquare(actualX - 1, actualY + modifier), actualX - 1, actualY + modifier});
        }

        foreach (int[] nums in slotsAndPlayer) {

            if (nums[0] == 0 || nums[0] != this.player) {

                if (base.moveInsideLimits(nums[1], nums[2])){
                    Square s = new Square(nums[0], nums[1], nums[2]);
                    list.Add(s);
                }
            }
        }

        return list;
    }

}
