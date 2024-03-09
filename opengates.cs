using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UIElements;

public class opengates : MonoBehaviour
{
    
    public int Delay = 200;

    public float x;
    public float y;    
    public float z;
   
    public int reset;

    public async void OnTriggerEnter(Collider other)
    {
      transform.localEulerAngles = new Vector3 (x, y, z);
    }
}

