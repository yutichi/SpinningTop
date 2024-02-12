using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent]
public class FieldController : MonoBehaviour
{
    Rigidbody _rigidbody;

    public Rigidbody Rigidbody => _rigidbody;

    // Start is called before the first frame update
    // only 1 time
    void Start()
    {
        
        _rigidbody = GetComponentInChildren<Rigidbody>();
        var name = _rigidbody.gameObject.name;

        Application.targetFrameRate = 60;
    }

    void Awake()
    {

    }

    private void OnEnable()
    {
       
    }

    private void OnGUI()
    {
       
    }

    private void LateUpdate()
    {
      
    }

    private void FixedUpdate()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        // Plane������炳����
        // X���@Rotation������������Ɓ@��O�ɌX���@�傫������Ɓ@���ɌX��
        // Y���@���l�ɁA����������Ɓ@�E�ɌX���@�傫������Ɓ@���ɌX��

        if (Input.GetKey(KeyCode.W)) //��
        {
            Vector3 vel = _rigidbody.angularVelocity;
            _rigidbody.angularVelocity = new Vector3(vel.x + 0.1f
                                                    , vel.y
                                                    , vel.z);
        }
        if (Input.GetKey(KeyCode.A)) //��
        {
            Vector3 vel = _rigidbody.angularVelocity;
            _rigidbody.angularVelocity = new Vector3(vel.x
                                                    , vel.y
                                                    , vel.z + 0.1f);
        }
        if (Input.GetKey(KeyCode.S)) //��
        {
            Vector3 vel = _rigidbody.angularVelocity;
            _rigidbody.angularVelocity = new Vector3(vel.x - 0.1f
                                                    , vel.y
                                                    , vel.z);
        }
        if (Input.GetKey(KeyCode.D)) //�E
        {
            Vector3 vel = _rigidbody.angularVelocity;
            _rigidbody.angularVelocity = new Vector3(vel.x
                                                    , vel.y
                                                    , vel.z - 0.1f);
        }

        this.transform.localPosition *= 1.0f - Time.deltaTime;
        Quaternion rot = this.transform.localRotation;

        // いろいろいじくって、Quantanionのidentity に最も近い動かし方で近づける
        Quaternion reveseRot
         = Quaternion.Slerp(rot, Quaternion.identity, Time.deltaTime);

        this.transform.localRotation = reveseRot;
    }
}
