using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject firingPoint;

    [SerializeField]
    private GameObject bullet;

    [SerializeField]
    private float speed = 300f;

    [SerializeField]
    Mag mag;
    [SerializeField]
    Explosion exp;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire3"))
        {
            LauncherShot();
        }

        /*
        if(Input.GetMouseButtonDown(0))
        {
            exp.blowoff();
        }
        */
    }
    private void LauncherShot()
    {
        if(!mag.zeroammo1)
        {
            exp.blowoff();
            // 弾を発射する場所を取得
            Vector3 bulletPosition = firingPoint.transform.position;
            // 上で取得した場所に、"bullet"のPrefabを出現させる
            GameObject newBall = Instantiate(bullet, bulletPosition, transform.rotation);
            // 出現させたボールのforward(z軸方向)
            Vector3 direction = newBall.transform.forward;
            // 弾の発射方向にnewBallのz方向(ローカル座標)を入れ、弾オブジェクトのrigidbodyに衝撃力を加える
            newBall.GetComponent<Rigidbody>().AddForce(direction * speed, ForceMode.Impulse);
            // 出現させたボールの名前を"bullet"に変更
            newBall.name = bullet.name;
            mag.reloadMag(0);
            Destroy(newBall, 0.2f);

        }
    }
}
