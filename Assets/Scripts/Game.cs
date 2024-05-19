using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour{
    [SerializeField] Game_manager manager;
    [SerializeField] GameObject spawner;

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.CompareTag("Obstacle")) {
            collision.gameObject.SetActive(false);
            manager.set_game(false);
            spawner.SetActive(false);
        }

        if(collision.gameObject.CompareTag("Point")) {
            manager.set_current_points();
            collision.gameObject.SetActive(false);
            print("Puntaje: "+manager.get_current_points());
        }
    }
}
