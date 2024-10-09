using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCameraController : MonoBehaviour
{

    //Unit�����̃I�u�W�F�N�g
    private GameObject unitychan;
    //Unity�����ƃJ�����̋���
    private float differenceX;
    private float differenceY;
    private float differenceZ;

    // Start is called before the first frame update
    void Start()
    {
        //Unity�����̃I�u�W�F�N�g���擾
        this.unitychan = GameObject.Find("unitychan");


        //Unity�����ƃJ�����̈ʒu�ix���W�j�̍������߂�
        this.differenceX = unitychan.transform.position.x - this.transform.position.x;
        //Unity�����ƃJ�����̈ʒu�iz���W�j�̍������߂�
        this.differenceY = unitychan.transform.position.y - this.transform.position.y;
        //Unity�����ƃJ�����̈ʒu�iz���W�j�̍������߂�
        this.differenceZ = unitychan.transform.position.z - this.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        //Unity�����̈ʒu�ɍ��킹�ăJ�����̈ʒu���ړ�
        this.transform.position = new Vector3(
            this.unitychan.transform.position.x - differenceX,
            this.unitychan.transform.position.y - differenceY,
            this.unitychan.transform.position.z - differenceZ);
    }
}