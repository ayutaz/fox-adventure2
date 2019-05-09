    // void Update()
    // {
        // if(gameObject.layer == 9){
        //     move_lengh();
        //     // Debug.Log("lengh");
        // }else if(gameObject.layer == 10){
        //     move_side();
        //     // Debug.Log("side");
        // }else if(gameObject.layer == 11){
        //     fly_ememy();
        // }else if(gameObject.layer ==12){
        //     jump();
        // }
    // }
    // void move_lengh(){
    //     // 左右に動く鳥のうごき
    //     float pos_x = this.gameObject.transform.position.x;
    //     float pos_y = this.gameObject.transform.position.y;
    //     float sin = Mathf.Sin(rotation_speed*Time.time)*rotation_range + position_y;
    //     // Debug.Log("eagle->"+"pos_x:"+this.gameObject.transform.localPosition.x+",pos_y"+this.gameObject.transform.localPosition.y+",sin:"+sin);
    //     this.transform.position = new Vector3(pos_x,sin,0);
    // }

        // void b(){
    //     trans.DORotate(
    //         new Vector3(90.0f,0.0f,0.0f),
    //         1.0f
    //     );
    // }

//     void fly_ememy(){
//         float pos_y = this.gameObject.transform.position.y;
//         float pos_x = this.gameObject.transform.position.x;
//         // Debug.Log(pos_x);
//         float sin = Mathf.Sin(rotation_speed*Time.time)*rotation_range + position_y;
//         // float cos = Mathf.Cos(rotation_speed*Time.time)*rotation_range + position_x;
//         // Debug.Log("opossum->"+"pos_x:"+this.gameObject.transform.localPosition.x+",pos_y"+this.gameObject.transform.localPosition.y+",sin:"+sin);
//         if(pos_x > -27.55){
//             this.transform.position = new Vector3(pos_x-0.01f,sin,0);
//         }else if(pos_x < 30){
//             this.transform.position = new Vector3(pos_x-0.01f,sin,0);
//         }
//     }

//     void jump(){
//         // カエル
//         float pos_y = this.gameObject.transform.position.y;
//         float pos_x = this.gameObject.transform.position.x;
//     }

    // public float position_x = 0.0f;
    // public float position_y = 0.0f;
    // [Range(0.0f,3.0f)]
    // public float rotation_speed = 1.0f;
    // [Range(1.0f,10.0f)]
    // public float rotation_range = 1.0f;