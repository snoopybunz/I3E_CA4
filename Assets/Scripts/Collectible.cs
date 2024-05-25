using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    public virtual void Collected()
    {
        // This function will be overridden by child classes
        Debug.Log("Collectible collected");
    }
}
