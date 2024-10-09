using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubCameraController : MonoBehaviour
{

    //Unitちゃんのオブジェクト
    private GameObject unitychan;
    //Unityちゃんとカメラの距離
    private float differenceX;
    private float differenceY;
    private float differenceZ;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");


        //Unityちゃんとカメラの位置（x座標）の差を求める
        this.differenceX = unitychan.transform.position.x - this.transform.position.x;
        //Unityちゃんとカメラの位置（z座標）の差を求める
        this.differenceY = unitychan.transform.position.y - this.transform.position.y;
        //Unityちゃんとカメラの位置（z座標）の差を求める
        this.differenceZ = unitychan.transform.position.z - this.transform.position.z;

    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんの位置に合わせてカメラの位置を移動
        this.transform.position = new Vector3(
            this.unitychan.transform.position.x - differenceX,
            this.unitychan.transform.position.y - differenceY,
            this.unitychan.transform.position.z - differenceZ);
    }
}