using UnityEngine;
using UnityEngine.Events;

public class Score : MonoBehaviour
{
    public UnityEvent scoreTrigger;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ball ball = collision.gameObject.GetComponent<Ball>();
        GetComponent<AudioSource>().Play();

        if (ball != null) {
            this.scoreTrigger.Invoke();
        }
    }

}