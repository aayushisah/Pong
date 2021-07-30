using UnityEngine;

public class Paddle : MonoBehaviour
{
    public float speed = 15.0f;
    public new Rigidbody2D rigidbody { get; private set; }

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResPos()
    {
        this.rigidbody.velocity = Vector2.zero;
        this.rigidbody.position = new Vector2(this.rigidbody.position.x, 0.0f);
    }

}
