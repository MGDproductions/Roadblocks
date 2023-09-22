using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public Rigidbody rb;
    public Movement movement;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if (collisionInfo.collider.tag == ("Roadblock"))
        {
            movement.Die();
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }


    void Start()
    {
        movement = GetComponent < Movement > ();
    }

}
