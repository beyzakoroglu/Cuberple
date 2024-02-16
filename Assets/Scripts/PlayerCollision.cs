using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public CubeScript movement;
    void OnCollisionEnter(Collision collisionInfo)
    {
        // Debug.Log("We hit " + collisionInfo.collider.tag);    //collider.name de olur ama tag ile specificleştirdik

        if(collisionInfo.collider.tag == "Black Obstacle")
        {
            movement.enabled = false;
            Debug.Log("We hit " + collisionInfo.collider.tag);
            FindObjectOfType<GameManager>().EndGame();
        }


    }
}
