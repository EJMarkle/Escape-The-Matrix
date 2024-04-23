using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        float moveAmount = moveInput * moveSpeed * Time.deltaTime;

        Vector2 move = new Vector2(moveAmount, 0);
        rb.MovePosition(rb.position + move);
    }
}
