using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemGeneratorNew : MonoBehaviour
{
    //carPrefabを入れる
    public GameObject carPrefab;
    //coinPrefabを入れる
    public GameObject coinPrefab;
    //conePrefabを入れる
    public GameObject conePrefab;
    //スタート地点
    private int startPos = 10;
    //ゴール地点
    private int goalPos = 320;
    //アイテムを出すx方向の範囲
    private float posRange = 3.4f;
    //unityちゃんを入れる
    public GameObject unitychan;
    //アイテムを生成した時のunitychanの位置を入れる
    private float unitychanLastPos;


    // Start is called before the first frame update
    void Start()
    {
        //unitychanのz軸方向位置を取得
        unitychan = GameObject.Find("unitychan");          
    }

    // Update is called once per frame
    void Update()
    {  
        float unitychanPosZ = this.unitychan.transform.position.z;
        Debug.Log(unitychanPosZ);
        int num = Random.Range(1, 15);


        //unitychanがstartPosよりも手前、またはgorlPosよりも先のときはreturn
        if (startPos > unitychanPosZ || unitychanPosZ > goalPos)
        {
            return;
        }

        //unitychanの位置が15m起きにアイテムを設置
        //unitychanの位置が15で割り切れないときはreturn
        else if (unitychanPosZ % 15 > 0.3)
        {
            return;
        }

        //１回前にアイテムを生成した時のunitychanの位置が現在のUnitychanの位置と同じときはreturn
        if(unitychanLastPos == unitychanPosZ)
        {
            return;
        }

        //Unitychanの位置から50m先にアイテムを生成させる
        if (num <= 2)
        {
            //コーンをx軸方向に一直線に生成
            for (float j = -1; j <= 1; j += 0.4f)
            {
                GameObject cone = Instantiate(conePrefab);
                cone.transform.position = new Vector3(4 * j, cone.transform.position.y, unitychanPosZ + 40);
            }
        }
        else
        {
            //レーンごとにアイテムを生成
            for (int j = -1; j <= 1; j++)
            {
                //アイテムの種類を決める
                int item = Random.Range(1, 11);
                //アイテムを置くz座標のオフセットをランダムに設定
                int offsetZ = Random.Range(-3, 3);
                //60%コイン配置：30%車配置：10%何もなし
                if (1 <= item && item <= 6)
                {
                    GameObject coin = Instantiate(coinPrefab);
                    coin.transform.position = new Vector3(posRange * j, coin.transform.position.y, unitychanPosZ + 40 + offsetZ);
                }
                else if (7 <= item && item <= 9)
                {
                    //車を作成
                    GameObject car = Instantiate(carPrefab);
                    car.transform.position = new Vector3(posRange * j, car.transform.position.y, unitychanPosZ + 40 + offsetZ);               
                }
            }
        }

        //アイテム生成した時のこの時のunitychanの位置を記憶
        unitychanLastPos = unitychanPosZ;

    }
}
