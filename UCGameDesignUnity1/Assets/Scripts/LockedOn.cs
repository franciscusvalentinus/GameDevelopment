using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedOn : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject target;
    Vector3 distance;
    void Start()
    {
        distance = target.transform.position - this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.transform.position - distance;
    }
}
