using UnityEngine;
using System.Collections;


public class Projectile : MonoBehaviour
{
    public Transform target;
    public float speed;
    GameObject prefab;
    void Start()
    {
        prefab = Resources.Load("Ricochet") as GameObject;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            GameObject projectile = Instantiate(prefab) as GameObject;
            float step = speed * Time.deltaTime;
            projectile.transform.position = Vector3.MoveTowards(transform.position, target.position, step);
          
        }
    }
}