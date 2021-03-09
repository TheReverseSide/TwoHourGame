using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{

    [SerializeField] private float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float posUpdate = Time.deltaTime;

        this.transform.position += Vector3.right * posUpdate * 5f;
    }
}
