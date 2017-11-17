using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RicochetObject : MonoBehaviour
{

    public LayerMask collisionMask;
    public Transform ricochet;
    private float speed = 15;
    private float rotSpeed = 800;

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        ricochet.Rotate(Vector3.up * Time.deltaTime * rotSpeed);

        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, Time.deltaTime * speed + .1f, collisionMask))
        {
            Vector3 reflectDir = Vector3.Reflect(ray.direction, hit.normal);
            float rot = 90 - Mathf.Atan2(reflectDir.z, reflectDir.x) * Mathf.Rad2Deg;
            transform.eulerAngles = new Vector3(0, rot, 0);
        }
    }
}