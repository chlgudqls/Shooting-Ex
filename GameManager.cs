using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Runtime.Serialization.Formatters.Binary;
using System;
using System.IO;

public class GameManager : MonoBehaviour
{
    public PrefabManager prefabManager;
    public ItemManager itemManager;
    public GameObject CoverImage;

    int score;
    public Text TextScore;
    public Text BestTextScore;
    private string Keyname = "Best";
    private int bestScore = 0;

    UserData userData;

    void Awake()
    {
        PlayerPrefs.DeleteAll();
        bestScore = PlayerPrefs.GetInt(Keyname, 0);
        BestTextScore.text = $"BestScore : {bestScore}";   
    }
    void Start()
    {
        //�ؽ�Ʈ ��ũ��Ʈ�� gamemanager�� ���⿡ �Լ��� ����
        //�̺�Ʈ�߰� �߰��Ѱ� enemy��ũ��Ʈ���� ȣ�� 
        EventManager.EnemyDiesEvent += EnemyDies;
    }
    public void OnclickStartButton()
    {
        CoverImage.SetActive(false);
        StartCoroutine(prefabManager.EnemyRandom());
        itemManager.ItemRandom();
    }

    public void EnemyDies()
    {
        score ++;
        TextScore.text = string.Format($"score : {score}");
        if(score > userData.BestScore)
        {
            PlayerPrefs.SetInt(Keyname, score);
        }
    }

    void SaveUserData()
    {
        FileStream file = new FileStream(Application.persistentDataPath + "/userdata.dat", FileMode.Create);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(file, userData);
        file.Close();
    }

    void Update()
    {
        
    }
}   
[Serializable]
    class UserData
    {
        public int BestScore;
    }

