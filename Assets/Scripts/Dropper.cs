using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float delayForDrop = 2f;
    MeshRenderer meshRenderer;
    Rigidbody myRigidbody;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        myRigidbody = GetComponent<Rigidbody>();
        meshRenderer.enabled = false;
        myRigidbody.useGravity = false;
    }

    void Update()
    {
        if (Time.time >= delayForDrop)
        {
            meshRenderer.enabled = true;
            myRigidbody.useGravity = true;
        }
    }
}
