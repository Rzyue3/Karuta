using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarutaRandamManager : MonoBehaviour
{
    public GameObject[] GameObjectPrefab;

    //かるたの盤面1~30枚からランダムで３枚選択する
    int start = 1;
    int end = 30;
    int firstkaruta = 3;
    int secondkaruta = 2;
    int thirdkaruta = 1;

    List<int> numbers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        
        for (int i = start; i <= end; i++) 
        {
            //1~30まで繰り返す
            numbers.Add(i);
        }
        

        /*
        while (count-- > 0) 
        {
            //indexにランダム要素数を入れる
            int index = Random.Range(0, numbers.Count);

            //karutarandamにランダム要素を使って取得
            int karutarandam = numbers[index];
            Debug.Log(karutarandam);
 
            numbers.RemoveAt(index);
        }
        */
    }
    // Update is called once per frame
    void Update()
    {
        
        while (firstkaruta-- > 2) 
        {
            //indexにランダム要素数を入れる
            int index = Random.Range(2, numbers.Count);

            //karutarandamにランダム要素を使って取得
            int karutarandam = numbers[index];
            Debug.Log(karutarandam);
 
            numbers.RemoveAt(index);

            //一つ目が表示されたら処理をぬける
            if(firstkaruta == 2)
            {
                break;
            }
        }
        
        while (secondkaruta-- > 1) 
        {
            //indexにランダム要素数を入れる
            int index = Random.Range(1, numbers.Count);

            //karutarandamにランダム要素を使って取得
            int karutarandam = numbers[index];
            Debug.Log(karutarandam);
 
            numbers.RemoveAt(index);

            //2つ目が表示されたら処理をぬける
            if(secondkaruta == 1)
            {
                break;
            }
        }

        while (thirdkaruta-- > 0) 
        {
            //indexにランダム要素数を入れる
            int index = Random.Range(0, numbers.Count);

            //karutarandamにランダム要素を使って取得
            int karutarandam = numbers[index];
            Debug.Log(karutarandam);
 
            numbers.RemoveAt(index);

            //3つ目が表示されたら処理をぬける
            if(thirdkaruta == 0)
            {
                break;
            }
        }
    }
}

