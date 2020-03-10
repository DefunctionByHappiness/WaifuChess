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

        // Puedes llamar a esta función para comprobar si en una posición del grid hay algo (devolverá 0 en ese caso) o en caso de haber algo, a qué jugador pertenece (1 o 2, dependiendo del jugador)
        // int player = base.isEmptySquare(row,col);

        // Puedes comprobar directamente el jugador al que pertece esta ficha llamando a this.player o a base.getPlayer();

        List<Square> list = new List<Square>();
        return list;
    }

}
