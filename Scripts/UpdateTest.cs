using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        var fc = GetComponent<FieldController>();
        fc.enabled = true;
        fc.Rigidbody.velocity = Vector3.zero;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
