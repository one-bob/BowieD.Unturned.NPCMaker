﻿using BowieD.NPCMaker.Configuration;
using BowieD.NPCMaker.NPC;
using System.IO;
using BowieD.NPCMaker.Extensions;
using System.Text;
using System;

namespace BowieD.NPCMaker.Export
{
    public static class ExportTool
    {
        private const string WaterText = "// Made in NPC Maker 2.0";
        public static bool ExportCharacter(Character character, string directory)
        {
            try
            {
                string workDir = $"{directory}Characters{Path.DirectorySeparatorChar}{character.editorName}_{character.id}{Path.DirectorySeparatorChar}";
                Directory.CreateDirectory(workDir);
                using (StreamWriter assetWriter = new StreamWriter(workDir + "Asset.dat", false, Encoding.UTF8))
                {
                    assetWriter.WriteLine(WaterText);
                    if (AppConfig.Instance.exportGuid)
                        assetWriter.WriteLine($"GUID {character.guid}");
                    assetWriter.WriteLine($"ID {character.id}");
                    assetWriter.WriteLine($"Type NPC");
                    if (character.defaultClothing.shirt > 0)
                        assetWriter.WriteLine($"Shirt {character.defaultClothing.shirt}");
                    if (character.defaultClothing.pants > 0)
                        assetWriter.WriteLine($"Pants {character.defaultClothing.pants}");
                    if (character.defaultClothing.mask > 0)
                        assetWriter.WriteLine($"Mask {character.defaultClothing.mask}");
                    if (character.defaultClothing.vest > 0)
                        assetWriter.WriteLine($"Vest {character.defaultClothing.vest}");
                    if (character.defaultClothing.backpack > 0)
                        assetWriter.WriteLine($"Backpack {character.defaultClothing.backpack}");
                    if (character.defaultClothing.hat > 0)
                        assetWriter.WriteLine($"Hat {character.defaultClothing.hat}");
                    if (character.defaultClothing.glasses > 0)
                        assetWriter.WriteLine($"Glasses {character.defaultClothing.glasses}");

                    if (character.christmasClothing.shirt > 0)
                        assetWriter.WriteLine($"Christmas_Shirt {character.christmasClothing.shirt}");
                    if (character.christmasClothing.pants > 0)
                        assetWriter.WriteLine($"Christmas_Pants {character.christmasClothing.pants}");
                    if (character.christmasClothing.mask > 0)
                        assetWriter.WriteLine($"Christmas_Mask {character.christmasClothing.mask}");
                    if (character.christmasClothing.vest > 0)
                        assetWriter.WriteLine($"Christmas_Vest {character.christmasClothing.vest}");
                    if (character.christmasClothing.backpack > 0)
                        assetWriter.WriteLine($"Christmas_Backpack {character.christmasClothing.backpack}");
                    if (character.christmasClothing.hat > 0)
                        assetWriter.WriteLine($"Christmas_Hat {character.christmasClothing.hat}");
                    if (character.christmasClothing.glasses > 0)
                        assetWriter.WriteLine($"Christmas_Glasses {character.christmasClothing.glasses}");

                    if (character.halloweenClothing.shirt > 0)
                        assetWriter.WriteLine($"Halloween_Shirt {character.halloweenClothing.shirt}");
                    if (character.halloweenClothing.pants > 0)
                        assetWriter.WriteLine($"Halloween_Pants {character.halloweenClothing.pants}");
                    if (character.halloweenClothing.mask > 0)
                        assetWriter.WriteLine($"Halloween_Mask {character.halloweenClothing.mask}");
                    if (character.halloweenClothing.vest > 0)
                        assetWriter.WriteLine($"Halloween_Vest {character.halloweenClothing.vest}");
                    if (character.halloweenClothing.backpack > 0)
                        assetWriter.WriteLine($"Halloween_Backpack {character.halloweenClothing.backpack}");
                    if (character.halloweenClothing.hat > 0)
                        assetWriter.WriteLine($"Halloween_Hat {character.halloweenClothing.hat}");
                    if (character.halloweenClothing.glasses > 0)
                        assetWriter.WriteLine($"Halloween_Glasses {character.halloweenClothing.glasses}");

                    if (character.equipPrimary > 0)
                        assetWriter.WriteLine($"Primary {character.equipPrimary}");
                    if (character.equipSecondary > 0)
                        assetWriter.WriteLine($"Secondary {character.equipSecondary}");
                    if (character.equipTertiary > 0)
                        assetWriter.WriteLine($"Tertiary {character.equipTertiary}");
                    if (character.equippedSlot != ESlotType.NONE)
                        assetWriter.WriteLine($"Equipped {character.equippedSlot.ToString().FirstCharToUpper()}");
                    assetWriter.WriteLine($"Face {character.face}");
                    assetWriter.WriteLine($"Beard {character.beard}");
                    assetWriter.WriteLine($"Hair {character.hair}");
                    assetWriter.WriteLine($"Color_Skin {character.skinColor.ToHEX()}");
                    assetWriter.WriteLine($"Color_Hair {character.hairColor.ToHEX()}");
                    assetWriter.WriteLine($"Pose {character.pose.ToString()}");
                    if (character.leftHanded)
                        assetWriter.WriteLine($"Backward");
                    if (character.dialogueId > 0)
                        assetWriter.WriteLine($"Dialogue {character.dialogueId}");
                    foreach (var k in Enum.GetValues(typeof(ELanguage)).ToEnumerable<ELanguage>())
                    {
                        if (character.editorName.ContainsKey(k) || character.displayName.ContainsKey(k))
                        {
                            using (StreamWriter localWriter = new StreamWriter(workDir + k + ".dat", false, Encoding.UTF8))
                            {
                                localWriter.WriteLine(WaterText);
                                if (character.editorName.ContainsKey(k))
                                    localWriter.WriteLine($"Name {character.editorName[k]}");
                                else
                                    localWriter.WriteLine($"Name UNDEFINED");
                                if (character.displayName.ContainsKey(k))
                                    localWriter.WriteLine($"Character {character.displayName[k]}");
                                else
                                    localWriter.WriteLine($"Character UNDEFINED");
                            }
                        }
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static bool ExportDialogue(Dialogue dialogue, string directory)
        {
            try
            {
                string workDir = directory = $"Dialogues{Path.DirectorySeparatorChar}{dialogue.guid}_{dialogue.id}{Path.DirectorySeparatorChar}";
                Directory.CreateDirectory(workDir);
                using (StreamWriter asset = new StreamWriter(workDir + "Asset.dat", false, Encoding.UTF8))
                {
                    asset.WriteLine(WaterText);
                    if (AppConfig.Instance.exportGuid)
                        asset.WriteLine($"GUID {dialogue.guid}");
                    asset.WriteLine($"Type Dialogue");
                    asset.WriteLine($"ID {dialogue.id}");

                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
