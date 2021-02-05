﻿using BowieD.Unturned.NPCMaker.GameIntegration;
using BowieD.Unturned.NPCMaker.Localization;
using BowieD.Unturned.NPCMaker.NPC.Shared.Attributes;
using System.Text;

namespace BowieD.Unturned.NPCMaker.NPC.Conditions
{
    [System.Serializable]
    public sealed class ConditionWeatherStatus : Condition
    {
        [AssetPicker(typeof(GameWeatherAsset), "Control_SelectAsset_Weather", MahApps.Metro.IconPacks.PackIconMaterialKind.WeatherCloudy)]
        public string GUID { get; set; }
        public ENPCWeatherStatus Value { get; set; }
        public Logic_Type Logic { get; set; }
        public override Condition_Type Type => Condition_Type.Weather_Status;
        public override string UIText
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                sb.Append($"{LocalizationManager.Current.Condition["Type_Weather_Status"]} ");
                switch (Logic)
                {
                    case Logic_Type.Equal:
                        sb.Append("= ");
                        break;
                    case Logic_Type.Greater_Than:
                        sb.Append("> ");
                        break;
                    case Logic_Type.Greater_Than_Or_Equal_To:
                        sb.Append(">= ");
                        break;
                    case Logic_Type.Less_Than:
                        sb.Append("< ");
                        break;
                    case Logic_Type.Less_Than_Or_Equal_To:
                        sb.Append("<= ");
                        break;
                    case Logic_Type.Not_Equal:
                        sb.Append("!= ");
                        break;
                }
                sb.Append(LocalizationManager.Current.Condition[$"Weather_Status_Status_{Value}"]);
                return sb.ToString();
            }
        }

        public override void Apply(Simulation simulation)
        {
            
        }

        public override bool Check(Simulation simulation)
        {
            return true;
        }
    }
}
