using UnityEngine;

public class Scorer : MonoBehaviour
{
    private int score = 0;

    private void OnCollisionEnter(Collision other) {

        if (other.gameObject.tag == "Player")
        {
            HandleHit();
        }
    }

    void HandleHit()
    {
        if (other.gameObject.tag == "Hit")
        {
            return;
        }

        score++;
        Debug.Log("You bumped into a thing this many times  : " + score);
    }
}
