using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    //�R�C���̉�]���x
    private float rotateSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //��]���J�n����p�x�������_���ɐݒ�
        this.transform.Rotate(0, Random.Range(0, 360), 0,Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        //���[�J�����WY�����ɉ�]
        transform.Rotate(0, rotateSpeed, 0, Space.Self);
    }
}
