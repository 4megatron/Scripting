using System.Threading.Tasks;
using UnityEngine;

public class openchest : MonoBehaviour
{
    public int x = -130;
    public void OnTriggerEnter(Collider other)
    {
        transform.localEulerAngles = new Vector3(x, 0, 0);
    }
}
