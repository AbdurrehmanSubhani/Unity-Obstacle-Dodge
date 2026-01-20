using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float flySpeed = 1f;

    Vector3 playerPosition;

    void DestroyWhenTouchPlayer()
    {
        Destroy(gameObject);
    }

    void MoveTowardsPlayer()
    {
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, flySpeed * Time.deltaTime);
    }

    void UpdatePlayerPosition()
    {
        playerPosition = player.transform.position;
    }
    void Update()
    {
        UpdatePlayerPosition();
        MoveTowardsPlayer();
        if (playerPosition == transform.position)
        {
            DestroyWhenTouchPlayer();
        }
    }
}
