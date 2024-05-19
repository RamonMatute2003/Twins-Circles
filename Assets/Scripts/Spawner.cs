using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour{
    [SerializeField] GameObject obstacle_prefab;
    [SerializeField] GameObject point_prefab;

    private List<GameObject> obstacles;
    private List<GameObject> points;

    [SerializeField] float spawn_timer;
    [SerializeField] Game_manager manager;

    private void Start() {
        obstacles = new List<GameObject>(); 
        points = new List<GameObject>();
        InvokeRepeating(nameof(spawn),2f,spawn_timer);
    }

    private void Update() {
        if(!manager.get_game()){
            CancelInvoke(nameof(spawn));
        }
    }

    private void spawn(){
        int ramdon_y = Random.Range(-2,2);
        int ramdon_object = Random.Range(0,3);
        GameObject game_object;

        game_object=ramdon_object==0 ? get_list_points() : get_list_obstacles();

        game_object.transform.position=new Vector3(transform.position.x,ramdon_y,transform.position.z);
        game_object.SetActive(true);
    }

    private GameObject get_list_obstacles(){
        for(int i = 0; i<obstacles.Count;i++) {
            if(!obstacles[i].activeInHierarchy) {
                return obstacles[i];
            }
        }

        return create_obstacle();
    }

    private GameObject create_obstacle(){
        GameObject new_obstacle=Instantiate(obstacle_prefab,transform);
        new_obstacle.name="Obstacle_"+obstacles.Count;
        new_obstacle.SetActive(false);
        obstacles.Add(new_obstacle);

        return new_obstacle;
    }

    private GameObject get_list_points() {
        for(int i = 0;i<points.Count;i++) {
            if(!points[i].activeInHierarchy) {
                return points[i];
            }
        }

        return create_points();
    }

    private GameObject create_points() {
        GameObject new_point = Instantiate(point_prefab,transform);
        new_point.name="Point_"+points.Count;
        new_point.SetActive(false);
        points.Add(new_point);

        return new_point;
    }
}
