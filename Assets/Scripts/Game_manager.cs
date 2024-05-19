using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_manager : MonoBehaviour{
    private bool game=true;
    private int current_points=0;
    
    public void set_game(bool status){
        game=status;
    }

    public bool get_game(){
        return game;
    }

    public void set_current_points(){
        current_points++;
    }

    public int get_current_points() {
        return current_points;
    }
}
