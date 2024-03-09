
using UnityEngine;

public class teleport : MonoBehaviour
{
    public float x = 130;
    public float y = 45;
    public float z = -75;

    public void OnTriggerEnter(Collider other)
    {

        Vector3 newPosition = other.transform.position;
        newPosition.x = x;
        newPosition.y = y;
        newPosition.z = z;
        other.transform.position = newPosition;
    }
}
