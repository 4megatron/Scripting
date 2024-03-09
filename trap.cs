using UnityEngine;

public class trap : MonoBehaviour
{
    public float x = -12;
    public float y = 15.6f;
    public float z = -64;

    public void OnTriggerEnter(Collider other)
    {
        Vector3 newPosition = other.transform.position;
        newPosition.x = x;
        newPosition.y = y;
        newPosition.z = z;
        other.transform.position = newPosition;
    }
}
