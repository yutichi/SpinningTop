using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Retry : MonoBehaviour
{
    //�X�N���v�g
    public PlayerController _playerController;

    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(DelayCoroutine(4.5f, () =>
            {
                //�v���C���[�������ʒu�Ɉړ�
                gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);

                //�f�o�b�O���O
                Debug.Log("Restart");

            }));
        }
    }

    public void Restart()
    {
        _playerController._fallSwitch = false;

        StartCoroutine(DelayCoroutine(4.5f, () =>
        {
            gameObject.transform.position = new Vector3(pos.x, pos.y, pos.z);

            StartCoroutine(DelayCoroutine(0.5f, () =>
            {
                _playerController._fallSwitch = true;
            }));
        }));
    }

    private IEnumerator DelayCoroutine(float seconds, UnityAction callback)
    {
        yield return new WaitForSeconds(seconds);
        callback?.Invoke();
    }
}
