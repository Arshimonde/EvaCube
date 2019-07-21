using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody rb;
    public float sideForce;
    public float forwardForce;

    private void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        float sideAxis = Input.GetAxis("Horizontal");
        rb.AddForce(sideForce * sideAxis * Time.deltaTime, 0,0, ForceMode.VelocityChange);

        if(transform.position.y < -1)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
