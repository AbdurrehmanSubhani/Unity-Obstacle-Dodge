using UnityEngine;

public class TriggerProjectile : MonoBehaviour
{
    [SerializeField] GameObject projectile;

    private void Awake() {
        projectile.SetActive(false);
    }
    
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            projectile.SetActive(true);
        }
    }
}
