using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBasicInfo
{
    private static CardBasicInfo _instance = null;

    public static CardBasicInfo Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new CardBasicInfo();
            }
            return _instance;
        }
        set
        {}
    }

    private CardBasicInfo()
    {}

    public string GetCardName(int num)
    {
        return "ci_" + num.ToString();
    }
    public string ci_1 = "BoneDragon" ;
    public string ci_2 = "MaleMarksman" ;
    public string ci_3 = "Mori" ;
    public string ci_4 = "MouseDragonRedBig" ;
    public string ci_5 = "Orc_Assassin" ;
    public string ci_6 = "Orc_BeastMaster" ;
    public string ci_7 = "Orc_Gladiator" ;
    public string ci_8 = "Orc_Mystic" ;
    public string ci_9 = "Orc_Necromancer" ;
    public string ci_10 = "Orc_Scout" ;
    public string ci_11 = "Orc_Shaman" ;
    public string ci_12 = "Orc_Warrior" ;
    public string ci_13 = "OspreyCaptian" ;
    public string ci_14 = "TraumaGuard" ;
    public string ci_15 = "Vardan" ;

    //相应的英雄金币
    public int GetCardCost(int i)
    {
        return Int32.Parse("g_" + i);
    }
    private string g_1 = "100";
    private string g_2 = "100";
    private string g_3 = "100";
    private string g_4 = "100";
    private string g_5 = "100";
    private string g_6 = "100";
    private string g_7 = "100";
    private string g_8 = "100";
    private string g_9 = "100";
    private string g_10 = "100";
    private string g_11 = "100";
    private string g_12 = "100";
    private string g_13 = "100";
    private string g_14 = "100";
    private string g_15 = "100";
}
