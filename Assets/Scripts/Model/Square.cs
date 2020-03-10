using System.Collections;
using System.Collections.Generic;


    public class Square
    {
        public int x;
        public int y;

        public int player;

        public Square(int player, int x, int y) {
            this.x = x;
            this.y = y;
            this.player = player;
        }

        public int getPlayer(){
            return this.player;
        }

        public int getX(){
            return this.x;
        }

        public int getY(){
            return this.y;
        }
    }

