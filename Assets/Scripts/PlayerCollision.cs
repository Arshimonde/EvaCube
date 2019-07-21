using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovements movements;
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Obstacle" )
        {
            movements.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
