using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawn : MonoBehaviour
{
    private Vector3 _position; 

    // Start is called before the first frame update
    void Start()
    {
        _position = gameObject.transform.position;
    }

    public void Reset()
    {
        //位置の初期化
        gameObject.transform.position = _position; 
    }
}
