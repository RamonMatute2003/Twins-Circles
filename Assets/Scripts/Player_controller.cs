using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player_controller : MonoBehaviour{
    [SerializeField] float speed_rotation;
    [SerializeField] Game_manager manager;

    void Update(){
        if(manager.get_game()){
            movement();
        }

        if(Input.GetKeyDown(KeyCode.Space)){
            SceneManager.LoadScene(0);
        }
    }

    private void movement(){
        if(Input.GetMouseButtonDown(0)){
            speed_rotation=-speed_rotation;
        }

        transform.Rotate(new Vector3(0,0,speed_rotation*Time.deltaTime));
    }
}
