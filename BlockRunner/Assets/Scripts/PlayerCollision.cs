using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //making a reference to our PlayerMovement script
    public PlayerMovement movement;
    void OnCollisionEnter(Collision collisionInfo) {
        if(collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            NumberOfCollisions.scoreValue += 1;
            FindObjectOfType<GameManager>().EndGame(); //better than making a variable in this case 
            //better this way bc prefabs are not linked to game manager... searching for game manager when we want to
            //calling here bc this is when we want the game to be over - when we collide with something
        }
    }
}
