using UnityEngine;
using UnityEngine.SceneManagement;
 
public class change_stages : MonoBehaviour {

    public GameObject player;
 
    void Update() {
        // Debug.Log("Update");
        if (Input.GetKeyDown(KeyCode.Alpha1) && SceneManager.GetActiveScene().name == "start") {
            SceneManager.LoadScene("Stages");
        }else if(Input.GetKeyDown(KeyCode.Alpha2) &&SceneManager.GetActiveScene().name == "start"){
            // SceneManager.LoadScene("Sta")
        }else if(Input.GetKeyDown(KeyCode.Alpha3) && SceneManager.GetActiveScene().name =="start"){
            Application.Quit();
        }else if(SceneManager.GetActiveScene().name == "GameOver"){
            Invoke("back_stage",1f);
            // ゲームオーバーになって1秒たつとステージ選択画面になる．
        }else if (Input.GetKey(KeyCode.Escape)) {
            Application.Quit();
        }//ゴール前にワープする
    }

    void back_stage(){
        SceneManager.LoadScene("Stages");
    }
}


