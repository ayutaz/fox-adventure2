using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class camera : MonoBehaviour {

    public GameObject player;

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
        transform.position = new Vector3(player.transform.position.x, 0, -10);
        if(transform.position.x < 0.48f && SceneManager.GetActiveScene().name == "Stages"){
            transform.position = new Vector3(0.48f, 0, -10);
        }else if(transform.position.x > 22.49f && SceneManager.GetActiveScene().name == "Stages"){
            transform.position = new Vector3(22.49f, 0, -10);
        }else if(transform.position.x < -22.5f ){
            transform.position = new Vector3(-22.5f, 0, -10);
        }else if(transform.position.x > 33.1f){
            transform.position = new Vector3(33.1f, 0, -10);
        }
    }
}