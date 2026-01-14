using UnityEngine;

public class FlyAtPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float flySpeed = 1f;

    Vector3 playerPosition;

    void Update()
    {
        playerPosition = player.transform.position;
        transform.position = Vector3.MoveTowards(transform.position, playerPosition, flySpeed * Time.deltaTime);
    }
}
