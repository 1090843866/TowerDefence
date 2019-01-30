 using System.Collections;
using System.Collections.Generic;
 using System.Collections.Specialized;
 using System.Text;
/// <summary>
/// 基本英雄信息结构
/// </summary>
public struct HeroBasicInfo
{
    //规则，有攻击力的不具备技能
    public string heroName;
    public int hp;          //标准为100
    public int attackRange; //攻击范围
    public int attackPower; //攻击力
    public int defensePower;//防御力
    public int skillType;   //00 己方加攻击力，01 己方加防御力，03 己方加生命值，04 对方减攻击力，05 对方减防御力
    public int skillPower;  //技能力量
}
 /// <summary>
 /// 英雄信息控制类
 /// </summary>
public class HeroInfoCon
{
    private static HeroInfoCon _instance = null;
    public static HeroInfoCon Instance
    {
        get
        {
            if(Instance == null)
            {
                _instance = new HeroInfoCon();
            }
            return _instance;
        }
        private set { }
    }
    private HeroInfoCon()
    {

    }
    //Hero Infomation from asset
    private static StringBuilder rootPath = new StringBuilder("Model/PrefabHero/", 30);
    public string BoneDragon = rootPath + "BoneDragon";
    public string MaleMarksman = rootPath + "MaleMarksman";
    public string Mori = rootPath + "Mori";
    public string MouseDragoRedBig = rootPath + "MouseDragoRedBig";
    public string Orc_Assassin = rootPath + "Orc_Assassin";
    public string Orc_Beastmaster = rootPath + "Orc_Beastmaster";
    public string Orc_Gladiator = rootPath + "Orc_Gladiator";
    public string Orc_Mystic = rootPath + "Orc_Mystic";
    public string Orc_Necromancer = rootPath + "Orc_Necromancer";
    public string Orc_Scout = rootPath + "Orc_Scout";
    public string Orc_Shaman = rootPath + "Orc_Shaman";
    public string Orc_Warrior = rootPath + "Orc_Warrior";
    public string OspreyCaptian = rootPath + "OspreyCaptian";
    public string TraumaGuard = rootPath + "TraumaGuard";
    public string Vardan = rootPath + "Vardan";

    //基本的英雄信息
    public HeroBasicInfo? GetHeroBasicInfo(int i)
    {
        if (i < 0 || i > _infoList.Length)
        {
            return null;
        }
        return _infoList[i];
    }
    private HeroBasicInfo[] _infoList = new HeroBasicInfo[15]
    {
        new HeroBasicInfo()
        {
            heroName = "BoneDragon",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "MaleMarksman",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "Mori",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "MouseDragoRedBig",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "Orc_Assassin",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "Orc_Beastmaster",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "Orc_Gladiator",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "Orc_Mystic",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "Orc_Necromancer",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "Orc_Scout",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "Orc_Shaman",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "Orc_Warrior",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "OspreyCaptian",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "TraumaGuard",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        },
        new HeroBasicInfo()
        {
            heroName = "Vardan",
            attackPower = 15,
            attackRange = 2,
            defensePower = 12,
            hp = 100,
            skillType = 00,
            skillPower = 10
        }
    };
}
