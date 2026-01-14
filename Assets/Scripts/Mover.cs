using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] float moveSpeed = 20f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PrintInstructions();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void PrintInstructions()
    {
        Debug.Log("Welcome to the Mover script!");
        Debug.Log("Use WASD or Arrow Keys to move the object.");
        Debug.Log("Dont bump into ojects!");
    }

    void Move()
    {
        float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float yValue = 0f;
        float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(xValue, yValue, zValue);
    }
}
