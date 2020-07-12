using UnityEngine;
using System.Collections;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -12;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed * Time.deltaTime, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter2D(Collision2D other)
    {

        //障害物に衝突した場合（追加）
        if (other.gameObject.tag == "CubeTag" || other.gameObject.tag == "GroundTag")
        {
            // タグと接触した時に効果音を鳴らす        
            GetComponent<AudioSource>().Play();
        }

    }

}