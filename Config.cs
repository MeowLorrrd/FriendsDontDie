using Terraria.ModLoader.Config;
using System.ComponentModel;
using Terraria;

namespace FriendsDontDie
{
    public class Config : ModConfig
    {
        public static Config Instance;
        public override ConfigScope Mode => ConfigScope.ClientSide;
        //NPC
        [Header("Settings for immortal NPCs")]
        [Label("Make all friendly NPCs immortal to all damage?")]
        [Tooltip("Enable this setting to make all NPCs immortal to all types of damage")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool allNPCsImmortal;
        [Label("Make all friendly NPCs immortal to lava?")]
        [Tooltip("Enable this setting to make all NPCs immune to lava damage")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool allNPCsLavaImmortal;
        [Label("Make all friendly NPCs immortal to enemies?")]
        [Tooltip("Enable this setting to make all NPCs immune to damage dealt by enemies")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool allNPCsEnemyImmortal;
        //Critter
        [Header("Settings for immortal Critters")]
        [Label("Make all critters immortal to all damage?")]
        [Tooltip("Enable this setting to make all critters immortal to all types of damage")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool allCrittersImmortal;
        [Label("Make all critters immortal to lava?")]
        [Tooltip("Enable this setting to make all critters immune to lava damage")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool allCrittersLavaImmortal;
        [Label("Make all critters immortal to enemies?")]
        [Tooltip("Enable this setting to make all critters immune to damage dealt by enemies")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool allCrittersEnemyImmortal;
        [Label("Make all critters immortal to players?")]
        [Tooltip("Enable this setting to make all critters immune to damage dealt by the player")]
        [DefaultValue(true)]
        [ReloadRequired]
        public bool allCrittersPlayerImmortal;
    }
}