using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    //Unityちゃんを入れる
    public GameObject unitychan;
    //Unitychanと障害物の距離
    private float difference;

    // Start is called before the first frame update
    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    // Update is called once per frame
    void Update()
    {
        //Unityちゃんと障害物の位置（z座標）の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;

        //障害物が画面外に出たらその障害物を消す
        if (this.difference > 10) 
        {
            Destroy(this.gameObject);
        }
    }
}
