using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;//情報を読み込むStringReaderを使用するために導入

///
///https://wisteria-sophy.com/663/unity_basis9/#toc9
///
//エネミーの基礎情報をCSVから読み込んで、変数に格納する
public  class CsvDataLoad : MonoBehaviour//MonoBehaviourは継承しない
{
    static TextAsset csvFile;//CSVファイルを変数として扱うために宣言
    static List<string[]> weaponData = new List<string[]>();//CSVファイルの中身を入れる配列を定義。全てのデータが文字列形式で格納される
    //変数名[i]がエネミーIDがiの情報をそれぞれ示す
    public int[] WeaponID = new int[100];//武器のID
    public string[] WeaponName = new string[100];//武器の名前
    public int[] WeaponAtk = new int[100];//武器のHP
    public int[] WeaponBullets = new int[100];//武器の装弾数
    public int[] WeaponMoveSpeed = new int[100];//武器毎の移動速度
    public float[] WeaponReloadTime = new float[100];//武器のリロード時間
    public float[] WeaponBulletSize = new float[100];//弾の大きさ
    //指定したアドレスに保管されているCSVファイルから情報を読み取り、weaponDataに情報を文字列として格納するメソッド。
    //weaponData[i][j]はCSVファイルのi行、j列目のデータを表す。但し先頭行（タイトル部分）は0行目と考えるものとする。
    static void CsvReader()
    {
        csvFile = Resources.Load("CSV/WeaponsData") as TextAsset;//指定したファイルをTextAssetとして読み込み(ファイル名の.csvは不要なことに注意)　最初の行（タイトル部分）も読み込まれるのでそこは使用しない
        StringReader reader = new StringReader(csvFile.text);
        while (reader.Peek() != -1)//最後まで読み込むと-1になる関数
        {
            string line = reader.ReadLine();//一行ずつ読み込み
            weaponData.Add(line.Split(','));//,区切りでリストに追加していく
        }
    }
    //weaponDataに一度CSVファイルのデータを読み込んだら他のプログラムから扱いやすいよう定義したenemyID等の変数にデータを格納する
    public void Init()
    {
        CsvReader();//weaponDataへ情報を一時格納
        //各変数へデータを格納
        for (int i = 1; i < weaponData.Count; i++)//エネミーIDが記述された最後まで読み込み。一行目はタイトルなのでi=0はデータとして扱わない
        {
            WeaponID[i] = int.Parse(weaponData[i][0]);//string型からint型へ変換
            WeaponName[i] = weaponData[i][1];
            WeaponAtk[i] = int.Parse(weaponData[i][2]);
            WeaponBullets[i] = int.Parse(weaponData[i][3]);
            WeaponMoveSpeed[i] = int.Parse(weaponData[i][4]);
            WeaponReloadTime[i] = float.Parse(weaponData[i][5]);
            WeaponBulletSize[i] = float.Parse(weaponData[i][6]);
        }
    }

    void Awake()
    {
        Init();
    }
}