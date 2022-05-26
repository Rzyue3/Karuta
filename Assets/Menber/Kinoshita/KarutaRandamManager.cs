using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarutaRandamManager : MonoBehaviour
{
    [SerializeField] int label;
    [SerializeField] int label2;
    [SerializeField] int label3;

    //かるたの盤面1~30枚からランダムで３枚選択する
    int start = 1;
    int end = 30;
    int first = 3;
    int second = 2;
    int thied = 1;

    List<int> numbers = new List<int>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = start; i <= end; i++) 
        {
            //1~30まで繰り返す
            numbers.Add(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
        while (first-- > 2) 
        {
            //indexにランダム要素数を入れる
            int index = Random.Range(0, numbers.Count);

            //labelにランダム要素を使って取得
            int label = numbers[index];
            Debug.Log(label);

            //選択された数字を重複しないようにする
            numbers.RemoveAt(index);
        }
        
        if(first == 2)
        {
            //switchの条件式にランダムで呼び出した数値を入れる
            //一枚目の処理
            switch(label)
                {
                    case 1: 
                        Debug.Log("1が選択されました");
                        break;
                    case 2: 
                        Debug.Log("2が選択されました");
                        break;
                    case 3: 
                        Debug.Log("3が選択されました");
                        break;
                    case 4: 
                        Debug.Log("4が選択されました");
                        break;
                    case 5: 
                        Debug.Log("5が選択されました");
                        break;
                    case 6: 
                        Debug.Log("6が選択されました");
                        break;
                    case 7: 
                        Debug.Log("7が選択されました");
                        break;
                    case 8: 
                        Debug.Log("8が選択されました");
                        break;
                    case 9: 
                        Debug.Log("9が選択されました");
                        break;
                    case 10: 
                        Debug.Log("10が選択されました");
                        break;
                    case 11: 
                        Debug.Log("11が選択されました");
                        break;
                    case 12: 
                        Debug.Log("12が選択されました");
                        break;
                    case 13: 
                        Debug.Log("13が選択されました");
                        break;
                    case 14: 
                        Debug.Log("14が選択されました");
                        break;
                    case 15: 
                        Debug.Log("15が選択されました");
                        break;
                    case 16: 
                        Debug.Log("16が選択されました");
                        break;
                    case 17: 
                        Debug.Log("17が選択されました");
                        break;
                    case 18: 
                        Debug.Log("18が選択されました");
                        break;
                    case 19: 
                        Debug.Log("19が選択されました");
                        break;
                    case 20: 
                        Debug.Log("20が選択されました");
                        break;
                    case 21: 
                        Debug.Log("21が選択されました");
                        break;
                    case 22: 
                        Debug.Log("22が選択されました");
                        break;
                    case 23: 
                        Debug.Log("23が選択されました");
                        break;
                    case 24: 
                        Debug.Log("24が選択されました");
                        break;
                    case 25: 
                        Debug.Log("25が選択されました");
                        break;
                    case 26: 
                        Debug.Log("26が選択されました");
                        break;
                    case 27: 
                        Debug.Log("27が選択されました");
                        break;
                    case 28: 
                        Debug.Log("28が選択されました");
                        break;
                    case 29: 
                        Debug.Log("29が選択されました");
                        break;
                    case 30: 
                        Debug.Log("30が選択されました");
                        break;
                }

         while (second-- > 1) 
        {
            //indexにランダム要素数を入れる
            int index = Random.Range(0, numbers.Count);

            //labelにランダム要素を使って取得
            int label2 = numbers[index];
            Debug.Log(label2);

            //選択された数字を重複しないようにする
            numbers.RemoveAt(index);
        }
        if(second == 1)
        {
            //switchの条件式にランダムで呼び出した数値を入れる
            //一枚目の処理
            switch(label2)
                {
                    case 1: 
                        Debug.Log("1が選択されました");
                        break;
                    case 2: 
                        Debug.Log("2が選択されました");
                        break;
                    case 3: 
                        Debug.Log("3が選択されました");
                        break;
                    case 4: 
                        Debug.Log("4が選択されました");
                        break;
                    case 5: 
                        Debug.Log("5が選択されました");
                        break;
                    case 6: 
                        Debug.Log("6が選択されました");
                        break;
                    case 7: 
                        Debug.Log("7が選択されました");
                        break;
                    case 8: 
                        Debug.Log("8が選択されました");
                        break;
                    case 9: 
                        Debug.Log("9が選択されました");
                        break;
                    case 10: 
                        Debug.Log("10が選択されました");
                        break;
                    case 11: 
                        Debug.Log("11が選択されました");
                        break;
                    case 12: 
                        Debug.Log("12が選択されました");
                        break;
                    case 13: 
                        Debug.Log("13が選択されました");
                        break;
                    case 14: 
                        Debug.Log("14が選択されました");
                        break;
                    case 15: 
                        Debug.Log("15が選択されました");
                        break;
                    case 16: 
                        Debug.Log("16が選択されました");
                        break;
                    case 17: 
                        Debug.Log("17が選択されました");
                        break;
                    case 18: 
                        Debug.Log("18が選択されました");
                        break;
                    case 19: 
                        Debug.Log("19が選択されました");
                        break;
                    case 20: 
                        Debug.Log("20が選択されました");
                        break;
                    case 21: 
                        Debug.Log("21が選択されました");
                        break;
                    case 22: 
                        Debug.Log("22が選択されました");
                        break;
                    case 23: 
                        Debug.Log("23が選択されました");
                        break;
                    case 24: 
                        Debug.Log("24が選択されました");
                        break;
                    case 25: 
                        Debug.Log("25が選択されました");
                        break;
                    case 26: 
                        Debug.Log("26が選択されました");
                        break;
                    case 27: 
                        Debug.Log("27が選択されました");
                        break;
                    case 28: 
                        Debug.Log("28が選択されました");
                        break;
                    case 29: 
                        Debug.Log("29が選択されました");
                        break;
                    case 30: 
                        Debug.Log("30が選択されました");
                        break;
                }
        }
        while (thied-- > 0) 
        {
            //indexにランダム要素数を入れる
            int index = Random.Range(0, numbers.Count);

            //labelにランダム要素を使って取得
            int label3 = numbers[index];
            Debug.Log(label3);

            //選択された数字を重複しないようにする
            numbers.RemoveAt(index);
        }
        if(thied == 0)
        {
            //switchの条件式にランダムで呼び出した数値を入れる
            //一枚目の処理
            switch(label3)
                {
                    case 1: 
                        Debug.Log("1が選択されました");
                        break;
                    case 2: 
                        Debug.Log("2が選択されました");
                        break;
                    case 3: 
                        Debug.Log("3が選択されました");
                        break;
                    case 4: 
                        Debug.Log("4が選択されました");
                        break;
                    case 5: 
                        Debug.Log("5が選択されました");
                        break;
                    case 6: 
                        Debug.Log("6が選択されました");
                        break;
                    case 7: 
                        Debug.Log("7が選択されました");
                        break;
                    case 8: 
                        Debug.Log("8が選択されました");
                        break;
                    case 9: 
                        Debug.Log("9が選択されました");
                        break;
                    case 10: 
                        Debug.Log("10が選択されました");
                        break;
                    case 11: 
                        Debug.Log("11が選択されました");
                        break;
                    case 12: 
                        Debug.Log("12が選択されました");
                        break;
                    case 13: 
                        Debug.Log("13が選択されました");
                        break;
                    case 14: 
                        Debug.Log("14が選択されました");
                        break;
                    case 15: 
                        Debug.Log("15が選択されました");
                        break;
                    case 16: 
                        Debug.Log("16が選択されました");
                        break;
                    case 17: 
                        Debug.Log("17が選択されました");
                        break;
                    case 18: 
                        Debug.Log("18が選択されました");
                        break;
                    case 19: 
                        Debug.Log("19が選択されました");
                        break;
                    case 20: 
                        Debug.Log("20が選択されました");
                        break;
                    case 21: 
                        Debug.Log("21が選択されました");
                        break;
                    case 22: 
                        Debug.Log("22が選択されました");
                        break;
                    case 23: 
                        Debug.Log("23が選択されました");
                        break;
                    case 24: 
                        Debug.Log("24が選択されました");
                        break;
                    case 25: 
                        Debug.Log("25が選択されました");
                        break;
                    case 26: 
                        Debug.Log("26が選択されました");
                        break;
                    case 27: 
                        Debug.Log("27が選択されました");
                        break;
                    case 28: 
                        Debug.Log("28が選択されました");
                        break;
                    case 29: 
                        Debug.Log("29が選択されました");
                        break;
                    case 30: 
                        Debug.Log("30が選択されました");
                        break;
                }
        }
        }
        
    }
}

