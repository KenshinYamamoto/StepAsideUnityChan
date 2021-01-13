using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemDestroyer : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    private GameObject unitychan;

    //Unityちゃんとデストロイヤーの距離
    private float difference;

    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");

        //Unityちゃんとデストロイヤーの位置(z座標)の差を求める
        this.difference = unitychan.transform.position.z - this.transform.position.z;
    }

    void Update()
    {
        //Unityちゃんの位置に合わせてデストロイヤーの位置を移動
        this.transform.position = new Vector3(0, this.transform.position.y, this.unitychan.transform.position.z - difference);
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
