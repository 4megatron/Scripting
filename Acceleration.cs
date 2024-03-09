
using UnityEngine;

public class Acceleration : MonoBehaviour
{
    public float speedFactor = 2.5f;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed *= speedFactor;
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<FirstPersonMovement>().runSpeed /= speedFactor;
    }
}



