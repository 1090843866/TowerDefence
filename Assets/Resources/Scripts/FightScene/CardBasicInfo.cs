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

    public string GetCardName(int index)
    {
        return _nameList[index];
    }

    private List<string> _nameList = new List<string>()
    {
        "BoneDragon",
        "MaleMarksman",
        "Mori",
        "MouseDragoRedBig",
        "Orc_Assassin",
        "Orc_BeastMaster",
        "Orc_Gladiator",
        "Orc_Mystic",
        "Orc_Necromancer",
        "Orc_Scout",
        "Orc_Shaman",
        "Orc_Warrior",
        "OspreyCaptian",
        "TraumaGuard",
        "Vardan"
    };

    //相应的英雄金币
    public int GetCardCost(int i)
    {
        return _costList[i];
    }
    private List<int> _costList = new List<int>()
    {
        100,
        100,
        100,
        100,
        100,
        100,
        100,
        100,
        100,
        100,
        100,
        100,
        100,
        100,
        100,
    };
}
