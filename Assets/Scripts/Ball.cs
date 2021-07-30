using UnityEngine;


public class Ball : MonoBehaviour
{
   
    public float speed = 210.0f;

    public new Rigidbody2D rigidbody { get; private set; }

    private void Awake()
    {
        this.rigidbody = GetComponent<Rigidbody2D>();
    }

    public void ResPos()
    {

        this.rigidbody.velocity = Vector2.zero;
        this.rigidbody.position = Vector2.zero;
        
    }

    public void AddStartForce()
    {
        float x = Random.value < 0.5f ? -1.0f : 1.0f;//ball has a fair chance to start on left or right
        float y = Random.value < 0.5f ? Random.Range(-1.0f, -0.5f) : Random.Range(0.5f, 1.0f);
        Vector2 direction = new Vector2(x, y);
        this.rigidbody.AddForce(direction * this.speed);
 
    }

    public void AddForce(Vector2 force)
    {
        this.rigidbody.AddForce(force);
    }
    
}