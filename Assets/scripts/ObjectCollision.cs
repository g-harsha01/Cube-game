using UnityEngine;

public class ObjectCollision : MonoBehaviour
{   
    public playermovemnt movement;

    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag =="Obstacle"){
            movement.enabled = false ;
            FindObjectOfType<Game_Manager>().Endgame();
        }


    }
}
