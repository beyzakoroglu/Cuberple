using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    //yazıldığı objeyi referans ediyor yani kamera
    public Transform player;
    public Vector3 offset;  //(x,y,z)

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(player.position);

        //when we dont write "Transform" with non-capital "T" it means
        //it refers to the transform our current object

        transform.position = player.position + offset;  //offset kadar mesafede durmasını saglamak icin
        
    }
}
