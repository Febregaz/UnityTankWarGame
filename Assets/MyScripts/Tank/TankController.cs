using UnityEngine;
using System.Collections;

public class TankController : MonoBehaviour {
	public float moveSpeed; 
	public float rotateSpeed;
	/**
	 *  按下W ,向前移动
	 *  按下S ,向后移动
	 *  按下A ,向左旋转
	 *  按下D ,向右旋转
	 * 
	 */
	void Update () {
//			速度 * 方向  * 这一帧的时间
//			transform.Translate ( 每一帧基本长度);

		//按下W ,向前移动
		if ( Input.GetKey(KeyCode.W) ) {
			transform.Translate (new Vector3(0.0f, 0.0f, 1.0f) * moveSpeed * Time.deltaTime );
		}
		//按下S ,向后移动
		if ( Input.GetKey(KeyCode.S) ) {
			transform.Translate (new Vector3(0.0f, 0.0f, -1.0f) * moveSpeed * Time.deltaTime );
		}

		//按下A向左旋转
		if( Input.GetKey(KeyCode.A) ){
			transform.Rotate (new Vector3(0.0f,-1.0f, 0.0f) * rotateSpeed * Time.deltaTime );

		}

		//按下D向右旋转
		if( Input.GetKey(KeyCode.D) ){
			transform.Rotate (new Vector3(0.0f,1.0f, 0.0f) * rotateSpeed * Time.deltaTime );

		}
	}

//	void Awake(){}
//	void Start () {
//
//	}

//
//	void LateUpdate(){}
//
//	void OnGUI(){}
//
//	void FixedUpdate(){}
}
