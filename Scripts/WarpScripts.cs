using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class WarpScripts : MonoBehaviour
{
    public Vector3 pos;

    public AudioClip _warpSE;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider collision)
    {
        //SE
        audioSource.PlayOneShot(_warpSE);

        //指定の座標に移動
        collision.gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);
    }
}
