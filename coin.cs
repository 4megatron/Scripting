using UnityEngine;



public class coin : MonoBehaviour
{
    public float rotateSpeed = 10;
    public int value;

    public void FixedUpdate()
    {
        transform.Rotate(0, rotateSpeed, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Coiincouter.instance.IncreaseCoins(value);
    }
}

