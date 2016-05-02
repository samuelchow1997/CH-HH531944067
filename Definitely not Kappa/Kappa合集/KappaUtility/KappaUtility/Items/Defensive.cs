﻿namespace KappaUtility.Items
{
    using EloBuddy;
    using EloBuddy.SDK;
    using EloBuddy.SDK.Menu;
    using EloBuddy.SDK.Menu.Values;

    internal class Defensive
    {
        public static readonly Item Zhonyas = new Item(ItemId.Zhonyas_Hourglass);

        public static readonly Item Seraph = new Item(ItemId.Seraphs_Embrace);

        public static readonly Item FOTM = new Item(ItemId.Face_of_the_Mountain);

        public static readonly Item Solari = new Item(ItemId.Locket_of_the_Iron_Solari);

        public static readonly Item Randuin = new Item(ItemId.Randuins_Omen, 500f);

        public static int Seraphh => DefMenu["Seraphh"].Cast<Slider>().CurrentValue;

        public static int Solarih => DefMenu["Solarih"].Cast<Slider>().CurrentValue;

        public static int FaceOfTheMountainh => DefMenu["FaceOfTheMountainh"].Cast<Slider>().CurrentValue;

        public static int Zhonyash => DefMenu["Zhonyash"].Cast<Slider>().CurrentValue;

        public static int Seraphn => DefMenu["Seraphn"].Cast<Slider>().CurrentValue;

        public static int Solarin => DefMenu["Solarin"].Cast<Slider>().CurrentValue;

        public static int FaceOfTheMountainn => DefMenu["FaceOfTheMountainn"].Cast<Slider>().CurrentValue;

        public static int Zhonyasn => DefMenu["Zhonyasn"].Cast<Slider>().CurrentValue;

        public static bool Seraphc => DefMenu["Seraph"].Cast<CheckBox>().CurrentValue && Seraph.IsOwned() && Seraph.IsReady();

        public static bool Solaric => DefMenu["Solari"].Cast<CheckBox>().CurrentValue && Solari.IsOwned() && Solari.IsReady();

        public static bool FaceOfTheMountainc => DefMenu["FaceOfTheMountain"].Cast<CheckBox>().CurrentValue && FOTM.IsOwned() && FOTM.IsReady();

        public static bool Zhonyasc => DefMenu["Zhonyas"].Cast<CheckBox>().CurrentValue && Zhonyas.IsOwned() && Zhonyas.IsReady();

        public static Menu DefMenu { get; private set; }

        protected static bool loaded = false;

        internal static void OnLoad()
        {
            DefMenu = Load.UtliMenu.AddSubMenu("防守物品");
            DefMenu.AddGroupLabel("防守物品设置");
            DefMenu.Add("Zhonyas", new CheckBox("使用中亚", false));
            DefMenu.Add("Zhonyash", new Slider("血量为X时使用中亚", 25));
            DefMenu.Add("Zhonyasn", new Slider("使用中亚如果预计受到的伤害多于[{0}%]", 50));
            DefMenu.AddSeparator();
            DefMenu.Add("Seraph", new CheckBox("使用炽天使之拥", false));
            DefMenu.Add("Seraphh", new Slider("血量为X时使用炽天使", 45));
            DefMenu.Add("Seraphn", new Slider("使用炽天使如果预计受到的伤害多于[{0}%]", 45));
            DefMenu.AddSeparator();
            DefMenu.Add("FaceOfTheMountain", new CheckBox("使用崇山圣盾", false));
            DefMenu.Add("FaceOfTheMountainh", new Slider("血量为X时使用圣盾", 50));
            DefMenu.Add("FaceOfTheMountainn", new Slider("使用圣盾如果预计受到的伤害多于[{0}%]", 50));
            DefMenu.AddSeparator();
            DefMenu.Add("Solari", new CheckBox("使用钢铁烈阳之匣", false));
            DefMenu.Add("Solarih", new Slider("血量为X时使用铁盒", 30));
            DefMenu.Add("Solarin", new Slider("使用鸟盾如果预计受到的伤害多于[{0}%]", 35));
            DefMenu.AddSeparator();
            DefMenu.Add("Randuin", new CheckBox("使用兰顿之兆", false));
            DefMenu.Add("Randuinh", new Slider("X名敌人时使用兰顿", 2, 1, 5));
            DefMenu.AddSeparator();
            DefMenu.AddGroupLabel("金身躲避");
            DefMenu.Add("ZhonyasD", new CheckBox("躲避危险技能", false));
            Common.DamageHandler.OnLoad();
            Zhonya.OnLoad();
            loaded = true;
        }

        internal static void Items()
        {
            if (!loaded)
            {
                return;
            }

            if (Randuin.IsReady() && Randuin.IsOwned(Player.Instance)
                && Player.Instance.CountEnemiesInRange(Randuin.Range) >= DefMenu["Randuinh"].Cast<Slider>().CurrentValue
                && DefMenu["Randuin"].Cast<CheckBox>().CurrentValue)
            {
                Randuin.Cast();
            }
        }
    }
}