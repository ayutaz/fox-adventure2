using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
public class trap : MonoBehaviour
{
    // public GameObject gameObject;
    private Transform trans;
    // private float z;
    private Sequence seq;
    // Start is called before the first frame update
    void Start()
    {
        DOTween.SetTweensCapacity(2000, 100);
        // gameObject = GetComponent<Transform>();
        trans = GetComponent<Transform>();
        seq = DOTween.Sequence();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void FixedUpdate(){
       if(gameObject.layer == 13)RotateBall();
    }

    void RotateBall(){
        // 一回転する鉄球
        trans.DORotate(
            new Vector3(0f,0f,360f),
            3.0f,
            RotateMode.FastBeyond360
        );
    }

}
