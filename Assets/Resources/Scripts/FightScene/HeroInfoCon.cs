 using System.Collections;
using System.Collections.Generic;
using System.Text;

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

}
