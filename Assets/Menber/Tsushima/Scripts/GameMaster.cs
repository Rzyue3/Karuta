using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameMaster : MonoBehaviour
{
    public NextKaruta nextkaruta;
    public GameObject NextText = null; // Textオブジェクト
    private float _time;
    private float _randTime;

    public string[] texts;//Unity上で入力するstringの配列
    int textNumber;//何番目のtexts[]を表示させるか
    string displayText;//表示させるstring
    int textCharNumber;//何文字目をdisplayTextに追加するか
    int displayTextSpeed; //全体のフレームレートを落とす変数
    bool textStop; //テキスト表示を始めるか
    
    void Start()
    {
        textStop = false;
        TimeSet();

    }

    void Update()
    {
        // 勝敗
        if(nextkaruta.P1Score >= 3)
        {
            
        }
        if(nextkaruta.P2Score >= 3)
        {

        }

        
        if(nextkaruta.NextGM)
        {
            nextkaruta.NextGM = false;
            TimeSet();
            KarutaSystem();
        }

        if(textStop)
        {
            _time += Time.deltaTime;
            if(_randTime <= _time)
            {
                displayTextSpeed++;
                if (displayTextSpeed % 5 == 0)//５回に一回プログラムを実行するif文
                {

                    if (textCharNumber != texts[textNumber].Length)//もしtext[textNumber]の文字列の文字が最後の文字じゃなければ
                    {
                        displayText = displayText + texts[textNumber][textCharNumber];//displayTextに文字を追加していく
                        textCharNumber = textCharNumber + 1;//次の文字にする
                    }
                }
            }
            NextText.GetComponent<Text>().text = displayText;
        }
    }
    void TimeSet()
    {
        _randTime = Random.Range(2.0f,10.0f);
    }
    void KarutaSystem()
    {
        textCharNumber = nextkaruta.LabelNum;
        switch(nextkaruta.LabelNum)
        {
            case 1:
            {
                textStop = true;
                break;
            }
            case 2:
            {
                break;
            }
        }
    }
/*    void TextTTS()
    {
       if (textStop == false) //テキストを表示させるif文
        { 
            displayTextSpeed++;
            if (displayTextSpeed % 5 == 0)//５回に一回プログラムを実行するif文
            {

                if (textCharNumber != texts[textNumber].Length)//もしtext[textNumber]の文字列の文字が最後の文字じゃなければ
                {
                    displayText = displayText + texts[textNumber][textCharNumber];//displayTextに文字を追加していく
                    textCharNumber = textCharNumber + 1;//次の文字にする
                }
            }
            Text nexttext = NextText.GetComponent<Text> ();
        } 
    }
*/
}
