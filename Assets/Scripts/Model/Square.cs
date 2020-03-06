using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Square {

    public class Square : MonoBehaviour
    {
        int col;
        int row;

        public Square(int col, int row) {
            this.col = col;
            this.row = row;
        }
    }
}
