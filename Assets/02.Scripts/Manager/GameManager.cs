using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.IO.Enumeration;
using Unity.VisualScripting;
using UnityEngine;

class SaveData
{
    public string userName;
    public int cash;
    public int bankCash;
}

public class GameManager : MonoBehaviour
{
    public Money money;
    public static GameManager instance;
    public UserData userData;

    public PopUpBank popUpBank;
    
    // 제이슨을 활용한 저장
    SaveData bankuser = new SaveData();

    private void Awake()
    {
        instance = this;
    }

    void Start()
    {
        LoadUserData();
    }

    public void DepositCash(int cash)
    {
        if (userData.cash >= cash)
        {
            userData.bankCash += cash;
            userData.cash -= cash;
        }
        else
        {
            if (popUpBank != null)
            {
                popUpBank.popUpError.SetActive(true);
            }
        }

        money.Refresh(userData);
        SaveUserData();
    }

    public void WithdrawCash(int cash)
    {
        if (userData.bankCash >= cash)
        {
            userData.bankCash -= cash;
            userData.cash += cash;
        }
        else
        {
            if (popUpBank != null)
            {
                popUpBank.popUpError.SetActive(true);
            }
        }

        money.Refresh(userData);
        SaveUserData();
    }

    private void SaveUserData()
    {
        // 파일 저장
        bankuser.userName = userData.userName;
        bankuser.cash = userData.cash;
        bankuser.bankCash = userData.bankCash;
        string jsonData = JsonUtility.ToJson(bankuser);

        // 저장 파일 경로
        string fileName = Path.Combine(Application.persistentDataPath + "/BankUserData.json");

        // 디스크에 저장
        File.WriteAllText(fileName, jsonData);
    }

    private void LoadUserData()
    {
        string fileName = Path.Combine(Application.persistentDataPath + "/BankUserData.json");

        // 저장된 파일 로드
        if (File.Exists(fileName))
        {
            string jsonData = File.ReadAllText(fileName);

            SaveData bankuser = JsonUtility.FromJson<SaveData>(jsonData);

            // 파일 불러오기
            userData.userName = bankuser.userName;
            userData.cash = bankuser.cash;
            userData.bankCash = bankuser.bankCash;
        }
        else
        {
            // 파일이 없을때 기본 데이터 설정
            userData = new UserData("백근욱", 50000, 100000);
        }
    }
}