using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
public class enemy : MonoBehaviour
{
    private Sequence sequence;
    private Transform trans;


    void Start(){
        // Debug.Log("hello");
        trans = GetComponent<Transform>();
        sequence = DOTween.Sequence();
        if(gameObject.layer == 9) MoveSide();
        if(gameObject.layer == 10) MoveLength();
    }
    // Update is called once per frame

    void FixedUpdate(){
        // Debug.Log("hello2");
    }
    void MoveSide(){
        // 左右に動く猫の動き
        Vector3[] paths = {
            new Vector3(-9.1f,0.295f),
            new Vector3(-13.4f,0.295f),
            new Vector3(-9.1f,0.295f),
        };
        trans.DOLocalPath(paths,3.0f,PathType.CatmullRom)
            .SetLookAt(0.03f, new Vector3(9.1f,0.0f,0.0f))
            .SetLoops(-1)
            .SetEase (Ease.Linear);
        }

    void MoveLength(){
        // 鳥の動き２面，，動かない床のところ
        Vector3[] paths = {
            new Vector3(-11.33f,-1.8f),
        };
        trans.DOLocalPath(paths,1.0f,PathType.CatmullRom)
            .SetLookAt(0.03f,new Vector3(-0.2f,0.0f,0.0f));
    }
}
