﻿using EloBuddy.SDK.Menu;
using EloBuddy.SDK.Menu.Values;
using EloBuddy.SDK;

// ReSharper disable InconsistentNaming
// ReSharper disable MemberHidesStaticFromOuterClass
namespace MissFortune
{
    // I can't really help you with my layout of a good config class
    // since everyone does it the way they like it most, go checkout my
    // config classes I make on my GitHub if you wanna take over the
    // complex way that I use
    public static class Config
    {
        private const string MenuName = "好运小姐";

        private static readonly Menu Menu;

        static Config()
        {
            // Initialize the menu
            Menu = MainMenu.AddMenu(MenuName, MenuName.ToLower());
            Menu.AddGroupLabel("Welcome to MissFortune by TopGunner");
            Menu.AddGroupLabel("CARRY合集由CH汉化");

            // Initialize the modes
            Modes.Initialize();
        }

        public static void Initialize()
        {
        }


        public static class Misc
        {

            private static readonly Menu Menu;
            public static readonly CheckBox _drawQ;
            public static readonly CheckBox _drawW;
            public static readonly CheckBox _drawE;
            public static readonly CheckBox _drawR;
            public static readonly CheckBox _drawCombo;
            private static readonly CheckBox _ksQ;
            private static readonly CheckBox _unkillableQ;
            private static readonly CheckBox _useLoveTaps;
            private static readonly CheckBox _useHeal;
            private static readonly CheckBox _useQSS;
            private static readonly CheckBox _autoBuyStartingItems;
            private static readonly CheckBox _autolevelskills;
            private static readonly Slider _skinId;
            public static readonly CheckBox _useSkinHack;
            private static readonly CheckBox[] _useHealOn = { new CheckBox("", false), new CheckBox("", false), new CheckBox("", false), new CheckBox("", false), new CheckBox("", false) };
            private static readonly CheckBox[] _useQOn = { new CheckBox(""), new CheckBox(""), new CheckBox(""), new CheckBox(""), new CheckBox("") };

            public static bool UseQOnI(int i)
            {
                return _useQOn[i].CurrentValue;
            }
            public static bool useHealOnI(int i)
            {
                return _useHealOn[i].CurrentValue;
            }
            public static bool ksQ
            {
                get { return _ksQ.CurrentValue; }
            }
            public static bool useQFarm
            {
                get { return _unkillableQ.CurrentValue; }
            }
            public static bool useLoveTaps
            {
                get { return _useLoveTaps.CurrentValue; }
            }
            public static bool useHeal
            {
                get { return _useHeal.CurrentValue; }
            }
            public static bool useQSS
            {
                get { return _useQSS.CurrentValue; }
            }
            public static bool autoBuyStartingItems
            {
                get { return _autoBuyStartingItems.CurrentValue; }
            }
            public static bool autolevelskills
            {
                get { return _autolevelskills.CurrentValue; }
            }
            public static int skinId
            {
                get { return _skinId.CurrentValue; }
            }
            public static bool UseSkinHack
            {
                get { return _useSkinHack.CurrentValue; }
            }
            public static bool drawComboDmg
            {
                get { return _drawCombo.CurrentValue; }
            }


            static Misc()
            {
                // Initialize the menu values
                Menu = Config.Menu.AddSubMenu("杂项");
                _drawQ = Menu.Add("drawQ", new CheckBox("显示 Q"));
                _drawW = Menu.Add("drawW", new CheckBox("显示 W"));
                _drawE = Menu.Add("drawE", new CheckBox("显示 E"));
                _drawR = Menu.Add("drawR", new CheckBox("显示 R"));
                Menu.AddSeparator();
                _useLoveTaps = Menu.Add("LoveTaps", new CheckBox("使用爱的节拍"));
                Menu.AddSeparator();
                _ksQ = Menu.Add("ksQ", new CheckBox("智能Q抢头"));
                _unkillableQ = Menu.Add("unkillableQ", new CheckBox("在骚扰/清线模式时无法杀死小兵使用Q"));
                Menu.AddSeparator();
                _useHeal = Menu.Add("useHeal", new CheckBox("智能使用治疗"));
                _useQSS = Menu.Add("useQSS", new CheckBox("使用水银"));
                Menu.AddSeparator();
                for (int i = 0; i < EntityManager.Heroes.Allies.Count; i++)
                {
                    _useHealOn[i] = Menu.Add("useHeal" + i, new CheckBox("使用治疗给 " + EntityManager.Heroes.Allies[i].ChampionName));
                }
                Menu.AddSeparator();
                for (int i = 0; i < EntityManager.Heroes.Enemies.Count; i++)
                {
                    _useQOn[i] = Menu.Add("useQ" + i, new CheckBox("Q用在" + EntityManager.Heroes.Enemies[i].ChampionName));
                }
                Menu.AddSeparator();
                _autolevelskills = Menu.Add("autolevelskills", new CheckBox("自动加点"));
                _autoBuyStartingItems = Menu.Add("autoBuyStartingItems", new CheckBox("开局自动购买物品 (召唤师峡谷)"));
                Menu.AddSeparator();
                _useSkinHack = Menu.Add("useSkinHack", new CheckBox("换肤"));
                _skinId = Menu.Add("skinId", new Slider("Skin ID", 7, 1, 9));
            }

            public static void Initialize()
            {
            }

        }

        public static class Modes
        {
            private static readonly Menu Menu;

            static Modes()
            {
                // Initialize the menu
                Menu = Config.Menu.AddSubMenu("模式");

                // Initialize all modes
                // Combo
                Combo.Initialize();
                Menu.AddSeparator();

                // Harass
                Harass.Initialize();
                LaneClear.Initialize();
                JungleClear.Initialize();
            }

            public static void Initialize()
            {
            }

            public static class Combo
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly CheckBox _useE;
                private static readonly CheckBox _useR;
                private static readonly CheckBox _useQChampsOnly;
                private static readonly CheckBox _useRHotkey;
                private static readonly CheckBox _useBOTRK;
                private static readonly CheckBox _useYOUMOUS;
                private static readonly CheckBox _saveRforStunned;
                private static readonly CheckBox _alwaysROnStunned;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool useQChampsOnly
                {
                    get { return _useQChampsOnly.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static bool UseE
                {
                    get { return _useE.CurrentValue; }
                }
                public static bool UseR
                {
                    get { return _useR.CurrentValue; }
                }
                public static bool UseRHotkey
                {
                    get { return _useRHotkey.CurrentValue; }
                }
                public static bool useBOTRK
                {
                    get { return _useBOTRK.CurrentValue; }
                }
                public static bool useYOUMOUS
                {
                    get { return _useYOUMOUS.CurrentValue; }
                }
                public static int ROnEnemies
                {
                    get { return Menu["comboROnEnemies"].Cast<Slider>().CurrentValue; }
                }
                public static int REnemiesMaxHP
                {
                    get { return Menu["REnemiesMaxHP"].Cast<Slider>().CurrentValue; }
                }
                public static bool saveRforStunned
                {
                    get { return _saveRforStunned.CurrentValue; }
                }
                public static bool alwaysROnStunned
                {
                    get { return _alwaysROnStunned.CurrentValue; }
                }
                public static bool RPressed
                {
                    get { return Menu["RHotkey"].Cast<KeyBind>().CurrentValue; }
                }
                public static void resetRKey()
                {
                    Menu["RHotkey"].Cast<KeyBind>().CurrentValue = false;
                }

                static Combo()
                {
                    // Initialize the menu values
                    Menu.AddGroupLabel("连招");
                    _useQ = Menu.Add("comboUseQ", new CheckBox("使用 Q"));
                    _useQChampsOnly = Menu.Add("comboUseQChampsOnly", new CheckBox("只对英雄使用Q"));
                    _useW = Menu.Add("comboUseW", new CheckBox("使用智能W"));
                    _useE = Menu.Add("comboUseE", new CheckBox("使用 E"));
                    _useR = Menu.Add("comboUseR", new CheckBox("使用 R"));
                    _useRHotkey = Menu.Add("comboUseRHotkey", new CheckBox("使用R热键", false));
                    Menu.Add("RHotkey", new KeyBind("不要打勾此选项!", false, KeyBind.BindTypes.HoldActive, 'R'));
                    Menu.Add("comboROnEnemies", new Slider("最低敌人数使用R R", 2, 1, 5));
                    Menu.Add("REnemiesMaxHP", new Slider("当1名敌人生命低于 ({0}%) 则使用R", 100, 1, 100));
                    Menu.AddSeparator();
                    _saveRforStunned = Menu.Add("saveRforStunned", new CheckBox("只是用R当至少一名敌人被晕眩"));
                    Menu.AddSeparator();
                    _alwaysROnStunned = Menu.Add("alwaysROnStunned", new CheckBox("当敌人被晕眩总使用R"));
                    Menu.AddSeparator();
                    _useBOTRK = Menu.Add("useBotrk", new CheckBox("使用 破败（智能）和弯刀"));
                    _useYOUMOUS = Menu.Add("useYoumous", new CheckBox("使用 幽梦"));
                }


                public static void Initialize()
                {
                }

            }

            public static class Harass
            {
                public static bool UseQ
                {
                    get { return Menu["harassUseQ"].Cast<CheckBox>().CurrentValue; }
                }
                public static bool useQMinionKillOnly
                {
                    get { return Menu["harassUseQKillingBlowOnly"].Cast<CheckBox>().CurrentValue; }
                }
                public static bool UseW
                {
                    get { return Menu["harassUseW"].Cast<CheckBox>().CurrentValue; }
                }
                public static bool UseE
                {
                    get { return Menu["harassUseE"].Cast<CheckBox>().CurrentValue; }
                }
                public static bool UseR
                {
                    get { return Menu["harassUseR"].Cast<CheckBox>().CurrentValue; }
                }
                public static int Mana
                {
                    get { return Menu["harassMana"].Cast<Slider>().CurrentValue; }
                }

                static Harass()
                {
                    // Here is another option on how to use the menu, but I prefer the
                    // way that I used in the combo class
                    Menu.AddGroupLabel("骚扰");
                    Menu.Add("harassUseQ", new CheckBox("使用 Q"));
                    Menu.Add("harassUseQKillingBlowOnly", new CheckBox("只为了更高的伤害而使用Q", false));
                    Menu.Add("harassUseW", new CheckBox("使用智能W"));
                    Menu.Add("harassUseE", new CheckBox("使用 E", false)); // Default false

                    // Adding a slider, we have a little more options with them, using {0} {1} and {2}
                    // in the display name will replace it with 0=current 1=min and 2=max value
                    Menu.Add("harassMana", new Slider("最大蓝量使用百分比 ({0}%)", 40));
                }
                public static void Initialize()
                {
                }

            }

            public static class LaneClear
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useQHarass;
                private static readonly CheckBox _useW;
                private static readonly Slider _mana;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseQHarass
                {
                    get { return _useQHarass.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static int mana
                {
                    get { return _mana.CurrentValue; }
                }

                static LaneClear()
                {
                    // Initialize the menu values
                    Menu.AddGroupLabel("清线");
                    _useQ = Menu.Add("clearUseQ", new CheckBox("使用 Q"));
                    _useQHarass = Menu.Add("clearUseQHarass", new CheckBox("如果能击中敌人则使用Q"));
                    _useW = Menu.Add("clearUseW", new CheckBox("使用 W"));
                    _mana = Menu.Add("clearMana", new Slider("最大蓝量使用百分比 ({0}%)", 40));
                }

                public static void Initialize()
                {
                }
            }
            public static class JungleClear
            {
                private static readonly CheckBox _useQ;
                private static readonly CheckBox _useW;
                private static readonly Slider _mana;

                public static bool UseQ
                {
                    get { return _useQ.CurrentValue; }
                }
                public static bool UseW
                {
                    get { return _useW.CurrentValue; }
                }
                public static int mana
                {
                    get { return _mana.CurrentValue; }
                }

                static JungleClear()
                {
                    // Initialize the menu values
                    Menu.AddGroupLabel("清野");
                    _useQ = Menu.Add("jglUseQ", new CheckBox("使用 Q"));
                    _useW = Menu.Add("jglUseW", new CheckBox("使用 W"));
                    _mana = Menu.Add("jglMana", new Slider("最大蓝量使用百分比 ({0}%)", 40));
                }

                public static void Initialize()
                {
                }
            }
        }
    }
}
