using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad : MonoBehaviour

{
    public float jumpFactor = 3;
    public float normaljump = 2;

    void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = jumpFactor * normaljump;
    }
    private void OnTriggerExit(Collider other)
    {
        other.GetComponent<Jump>().jumpStrength = normaljump;
    }
}
