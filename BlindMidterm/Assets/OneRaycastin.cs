using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneRaycastin : MonoBehaviour
{
    public Rigidbody projectile;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
				StartCoroutine(functionName());
                if (hit.collider != null)
                {
                    hit.collider.enabled = false;
                }
            }
        }
        if (Input.GetMouseButtonDown(1))
        {

            StartCoroutine(functionName());
        }
    }

    IEnumerator functionName()
    {

        yield return new WaitForSecondsRealtime(2);
        Rigidbody clone;
        clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
        clone.velocity = transform.TransformDirection(Vector3.forward * 10);
    }
}
