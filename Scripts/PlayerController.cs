using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;

public class PlayerController : MonoBehaviour {
	
	public float speed = 4f; //歩くスピード
    public float jumpPower = 400; //ジャンプ力
	public LayerMask groundLayer; //Linecastで判定するLayer

	private Rigidbody2D rb2d;
    private bool isGrounded; //着地判定
	private Animator anim;
	
	void Start () {
		//各コンポーネントをキャッシュしておく
		anim = GetComponent<Animator>();
		rb2d = GetComponent<Rigidbody2D>();
	}
	
	void Update ()
	{
		//Linecastでユニティちゃんの足元に地面があるか判定
		isGrounded = Physics2D.Linecast (transform.position + transform.up * 1,transform.position - transform.up * 0.7f,groundLayer);
		//スペースキーを押し、
		if (Input.GetKeyDown ("space")) {
			//着地していた時、
			if (isGrounded) {
				//Dashアニメーションを止めて、Jumpアニメーションを実行
				anim.SetBool("Dash", false);
				anim.SetTrigger("Jump");
				//着地判定をfalse
				isGrounded = false;
				//AddForceにて上方向へ力を加える
				rb2d.AddForce (Vector2.up * jumpPower);
			}
		}
		//上下への移動速度を取得
		float velY = rb2d.velocity.y;
		//移動速度が0.1より大きければ上昇
		bool isJumping = velY > 0.1f ? true:false;
		//移動速度が-0.1より小さければ下降
		bool isFalling = velY < -0.1f ? true:false;
		//結果をアニメータービューの変数へ反映する
		anim.SetBool("isJumping",isJumping);
		anim.SetBool("isFalling",isFalling);
	}
	
	void FixedUpdate (){
		float x = Input.GetAxisRaw ("Horizontal");
		float y = Input.GetAxisRaw ("Vertical");
		if(y != 0 && SceneManager.GetActiveScene().name == "stage3"){
			rb2d.velocity = new Vector2 (rb2d.velocity.x,y * speed);
			anim.SetBool ("Dash", true);
		}else if (x != 0) {
			rb2d.velocity = new Vector2 (x * speed, rb2d.velocity.y);
			Vector2 temp = transform.localScale;
			temp.x = x*3;
			transform.localScale = temp;
			anim.SetBool ("Dash", true);
		}else {
			rb2d.velocity = new Vector2 (0, rb2d.velocity.y);
			anim.SetBool ("Dash", false);
		}
	}

	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "GameOver"){
			SceneManager.LoadScene("GameOver");
			// Debug.Log("hello");
		}else if (other.gameObject.tag == "stage1"){
			SceneManager.LoadScene("stage1");
		}else if (other.gameObject.tag == "stage2"){
			SceneManager.LoadScene("stage2");
		// }else if (other.gameObject.tag == "stage3"){
			// SceneManager.LoadScene("stage3");
		}else if(other.gameObject.tag == "gameclear"){
			SceneManager.LoadScene("Stages");
		}
    }
	
}

