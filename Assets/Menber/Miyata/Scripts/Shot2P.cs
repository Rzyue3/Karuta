using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot2P : MonoBehaviour
{
   [SerializeField]
    private GameObject firingPoint;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private float speed = 300f;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire3_2"))
        {
            LauncherShot2P();
        }
    }
    private void LauncherShot2P()
    {
        // 弾を発射する場所を取得
        Vector3 bulletPosition = firingPoint.transform.position;
        // 上で取得した場所に、"bullet"のPrefabを出現させる
        GameObject newBall = Instantiate(bullet, bulletPosition, transform.rotation);
        // 出現させたボールのforward(z軸方向)
        Vector3 direction = newBall.transform.forward;
        // 弾の発射方向にnewBallのz方向(ローカル座標)を入れ、弾オブジェクトのrigidbodyに衝撃力を加える
        newBall.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Impulse);
        // 出現させたボールを0.2秒後に消す
        Destroy(newBall, 0.2f);
    }
}
