using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinController : MonoBehaviour
{
    //コインの回転速度
    private float rotateSpeed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        //回転を開始する角度をランダムに設定
        this.transform.Rotate(0, Random.Range(0, 360), 0,Space.Self);
    }

    // Update is called once per frame
    void Update()
    {
        //ローカル座標Y軸回りに回転
        transform.Rotate(0, rotateSpeed, 0, Space.Self);
    }
}
