using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class Rotate : MonoBehaviour
{
    public float speed;
}

class RotatorSystem : ComponentSystem
{
    struct Components
    {
        public Transform rotator;
        public Transform transform;
    }
    protected override void OnUpdate()
    {
    }
}