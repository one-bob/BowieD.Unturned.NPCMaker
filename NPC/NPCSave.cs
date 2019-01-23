﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace BowieD.Unturned.NPCMaker.NPC
{
    public class NPCSave
    {
        public NPCSave()
        {
            guid = Guid.NewGuid().ToString("N");
        }

        public int version;

        public string editorName;
        public string displayName;
        public ushort id;
        public byte face;
        public byte beard;
        public byte haircut;
        public NPCColor hairColor;
        public NPCColor skinColor;
        public ushort hat;
        public ushort mask;
        public ushort top;
        public ushort bottom;
        public ushort backpack;
        public ushort vest;
        public ushort glasses;
        public ushort startDialogueId;
        public string saveFile;
        public NPC_Pose pose;
        public bool leftHanded;
        public ushort equipPrimary;
        public ushort equipSecondary;
        public ushort equipTertiary;
        public Equip_Type equipped;

        public List<NPCDialogue> dialogues;
        public List<NPCVendor> vendors;
        public List<NPCQuest> quests;
        public List<Condition> visibilityConditions;

        [XmlAttribute]
        public string guid;
    }
}
