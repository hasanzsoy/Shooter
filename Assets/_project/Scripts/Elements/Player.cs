using System;
using UnityEngine;

public class Player : MonoBehaviour
{
    internal void RestartPlayer()
    {
        transform.position = Vector3.zero;
    }

}
