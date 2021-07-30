using UnityEngine;

public class Player1Paddle : Paddle
{
    public Vector2 direction { get; private set; }

    private void Update()
    {   //keyboard controls
        if (Input.GetKey(KeyCode.W) ) {
            this.direction = Vector2.up;
        } else if (Input.GetKey(KeyCode.S) ) {
            this.direction = Vector2.down;
        } else {
            this.direction = Vector2.zero;
        }
    }

    private void FixedUpdate()
    {
        if (this.direction.sqrMagnitude != 0) {
            this.rigidbody.AddForce(this.direction * this.speed);
        }
    }

}