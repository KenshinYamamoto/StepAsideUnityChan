using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    //Unityちゃんのオブジェクト
    GameObject unitychan;

    //Unityちゃんとアイテムの距離
    private float difference;

    void Start()
    {
        //Unityちゃんのオブジェクトを取得
        this.unitychan = GameObject.Find("unitychan");
    }

    void Update()
    {
        //アイテムとUnityちゃん(Z座標)の差を求める
        this.difference = this.transform.position.z - this.unitychan.transform.position.z;

        //もし差が-7以下になったらアイテムを破棄する
        if (difference < -7.0f)
        {
            Destroy(this.gameObject);
        }
    }
}
