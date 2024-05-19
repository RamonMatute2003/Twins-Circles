using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour{
    [SerializeField] float speed;

    void Update(){
        gameObject.transform.Translate(Vector3.left*speed*Time.deltaTime,Space.World);
    }
}
