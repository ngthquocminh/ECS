using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using Unity.Rendering;

public class Spawner : MonoBehaviour
{
    [SerializeField] private Mesh enemyMesh;
    [SerializeField] private Material enemyMaterial;

    private EntityManager entityManager;
    // Start is called before the first frame update
    void Start()
    {
        // 1
        entityManager = World.DefaultGameObjectInjectionWorld.EntityManager;

        EntityArchetype archtype = entityManager.CreateArchetype(
            typeof(Translation),
            typeof(RenderMesh),
            typeof(Rotation),
            typeof(RenderBounds),
            typeof(LocalToWorld)
            ); 

        // 2
        Entity entity = entityManager.CreateEntity();

        entityManager.AddComponentData(entity, new Translation { Value = new float3(-3f, 0.5f, 5f) });
        entityManager.AddComponentData(entity, new Rotation { Value = quaternion.EulerXYZ(new float3(0f, 45f, 0f)) });

        entityManager.AddSharedComponentData(entity, new RenderMesh { mesh = enemyMesh, material = enemyMaterial });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
