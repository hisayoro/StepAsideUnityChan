using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGeneratorNew : MonoBehaviour
{
    //carPrefab������
    public GameObject carPrefab;
    //coinPrefab������
    public GameObject coinPrefab;
    //conePrefab������
    public GameObject conePrefab;
    //�X�^�[�g�n�_
    private int startPos = 10;
    //�S�[���n�_
    private int goalPos = 320;
    //�A�C�e�����o��x�����͈̔�
    private float posRange = 3.4f;
    //unity����������
    public GameObject unitychan;
    //�A�C�e���𐶐���������unitychan�̈ʒu������
    private float unitychanLastPos;


    // Start is called before the first frame update
    void Start()
    {
        //unitychan��z�������ʒu���擾
        unitychan = GameObject.Find("unitychan");          
    }

    // Update is called once per frame
    void Update()
    {  
        float unitychanPosZ = this.unitychan.transform.position.z;
        Debug.Log(unitychanPosZ);
        int num = Random.Range(1, 15);


        //unitychan��startPos������O�A�܂���gorlPos������̂Ƃ���return
        if (startPos > unitychanPosZ || unitychanPosZ > goalPos)
        {
            return;
        }

        //unitychan�̈ʒu��15m�N���ɃA�C�e����ݒu
        //unitychan�̈ʒu��15�Ŋ���؂�Ȃ��Ƃ���return
        else if (unitychanPosZ % 15 > 0.3)
        {
            return;
        }

        //�P��O�ɃA�C�e���𐶐���������unitychan�̈ʒu�����݂�Unitychan�̈ʒu�Ɠ����Ƃ���return
        if(unitychanLastPos == unitychanPosZ)
        {
            return;
        }

        //Unitychan�̈ʒu����50m��ɃA�C�e���𐶐�������
        if (num <= 2)
        {
            //�R�[����x�������Ɉ꒼���ɐ���
            for (float j = -1; j <= 1; j += 0.4f)
            {
                GameObject cone = Instantiate(conePrefab);
                cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychanPosZ + 40);
            }
        }
        else
        {
            //���[�����ƂɃA�C�e���𐶐�
            for (int j = -1; j <= 1; j++)
            {
                //�A�C�e���̎�ނ����߂�
                int item = Random.Range(1, 11);
                //�A�C�e����u��z���W�̃I�t�Z�b�g�������_���ɐݒ�
                int offsetZ = Random.Range(-3, 3);
                //60%�R�C���z�u�F30%�Ԕz�u�F10%�����Ȃ�
                if (1 <= item && item <= 6)
                {
                    GameObject coin = Instantiate(coinPrefab);
                    coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychanPosZ + 40 + offsetZ);
                }
                else if (7 <= item && item <= 9)
                {
                    //�Ԃ��쐬
                    GameObject car = Instantiate(carPrefab);
                    car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychanPosZ + 40 + offsetZ);               
                }
            }
        }

        //�A�C�e�������������̂��̎���unitychan�̈ʒu���L��
        unitychanLastPos = unitychanPosZ;

    }
}
