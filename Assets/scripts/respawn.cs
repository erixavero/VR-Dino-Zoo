using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class respawn : MonoBehaviour
{
    [SerializeField] private Transform item;
    [SerializeField] private ParticleSystem spark;
    [SerializeField] private Transform respawn_point;
    [SerializeField] private Rigidbody food;

    void OnTriggerEnter(Collider other)
    {
        Vector3 hitpos = item.transform.position;
        spark.transform.position = hitpos;
        spark.Emit(10);
        item.transform.position = respawn_point.transform.position;
        food.velocity = Vector3.zero;
    }
}
