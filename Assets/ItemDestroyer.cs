using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    //Unity����������
    public GameObject unitychan;
    //Unitychan�Ə�Q���̋���
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����Ə�Q���̈ʒu�iz���W�j�̍������߂�
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        //��Q������ʊO�ɏo���炻�̏�Q��������
        if (this.difference > 10) 
        {
            Destroy(this.gameObject);
        }
    }
}
