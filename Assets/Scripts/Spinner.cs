using UnityEngine;

public class Spinner : MonoBehaviour
{

    [SerializeField] float xAngle = 0f;
    [SerializeField] float yAngle = 1f;
    [SerializeField] float zAngle = 0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(xAngle, yAngle, zAngle);
    }
}
