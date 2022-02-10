using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace FriendsDontDie
{
    public class FriendsDontDieGlobalNPC : GlobalNPC
    {
        public override bool InstancePerEntity => true;
        public override void SetDefaults(NPC npc)
        {
            #region Critters
            if (npc.type == NPCID.Bird || +
                npc.type == NPCID.BirdBlue || +
                npc.type == NPCID.BirdRed || +
                npc.type == NPCID.Firefly || +
                npc.type == NPCID.LightningBug || +
                npc.type == NPCID.Bunny || +
                npc.type == NPCID.BunnySlimed || +
                npc.type == NPCID.BunnyXmas || +
                npc.type == NPCID.PartyBunny || +
                npc.type == NPCID.Duck || +
                npc.type == NPCID.Duck2 || +
                npc.type == NPCID.DuckWhite || +
                npc.type == NPCID.DuckWhite2 || +
                npc.type == NPCID.Frog || +
                npc.type == NPCID.Mouse || +
                npc.type == NPCID.Penguin || +
                npc.type == NPCID.PenguinBlack || +
                npc.type == NPCID.Scorpion || +
                npc.type == NPCID.ScorpionBlack || +
                npc.type == NPCID.Squirrel || +
                npc.type == NPCID.SquirrelRed || +
                npc.type == NPCID.Buggy || +
                npc.type == NPCID.EnchantedNightcrawler || +
                npc.type == NPCID.Grubby || +
                npc.type == NPCID.Sluggy || +
                npc.type == NPCID.Worm || +
                npc.type == NPCID.Grasshopper || +
                npc.type == NPCID.GlowingSnail || +
                npc.type == NPCID.Snail || +
                npc.type == NPCID.Goldfish || +
                npc.type == NPCID.GoldfishWalker || +
                npc.type == NPCID.Butterfly || +
                npc.type == NPCID.GoldBird || +
                npc.type == NPCID.GoldBunny || +
                npc.type == NPCID.GoldButterfly || +
                npc.type == NPCID.GoldFrog || +
                npc.type == NPCID.GoldGrasshopper || +
                npc.type == NPCID.GoldMouse || +
                npc.type == NPCID.GoldWorm || +
                npc.type == NPCID.SquirrelGold || +
                npc.type == NPCID.TruffleWorm || +
                npc.type == NPCID.TruffleWormDigger) //Checks if NPC is a vanilla critter
                                                     //Should apply to every vanilla critter
            {
                if (Config.Instance.allCrittersImmortal && npc.type != NPCID.DD2EterniaCrystal)//All damage is negated
                {
                    npc.dontTakeDamageFromHostiles = true;
                    npc.lavaImmune = true;
                    npc.immortal = true;
                }
                if (Config.Instance.allCrittersLavaImmortal && npc.type != NPCID.DD2EterniaCrystal)//Only lava damage is negated
                {
                    npc.lavaImmune = true;
                }
                #endregion
            }
            #region NPCs
            if (Config.Instance.allNPCsImmortal && npc.friendly && npc.type != NPCID.DD2EterniaCrystal)//All damage is negated
            {
                npc.dontTakeDamageFromHostiles = true;
                npc.lavaImmune = true;
                npc.immortal = true;
            }
            if (Config.Instance.allNPCsLavaImmortal && npc.friendly && npc.type != NPCID.DD2EterniaCrystal)//All lava damage is negated
            {
                npc.lavaImmune = true;
            }
            #endregion
        }
        #region Player killing Critters
        public override bool? CanBeHitByItem(NPC npc, Player player, Item item)
        {
            if (Config.Instance.allCrittersPlayerImmortal && npc.type != NPCID.DD2EterniaCrystal && (npc.type == NPCID.Bird || 
                npc.type == NPCID.BirdBlue || +
                npc.type == NPCID.BirdRed || +
                npc.type == NPCID.Firefly || +
                npc.type == NPCID.LightningBug || +
                npc.type == NPCID.Bunny || +
                npc.type == NPCID.BunnySlimed || +
                npc.type == NPCID.BunnyXmas || +
                npc.type == NPCID.PartyBunny || +
                npc.type == NPCID.Duck || +
                npc.type == NPCID.Duck2 || +
                npc.type == NPCID.DuckWhite || +
                npc.type == NPCID.DuckWhite2 || +
                npc.type == NPCID.Frog || +
                npc.type == NPCID.Mouse || +
                npc.type == NPCID.Penguin || +
                npc.type == NPCID.PenguinBlack || +
                npc.type == NPCID.Scorpion || +
                npc.type == NPCID.ScorpionBlack || +
                npc.type == NPCID.Squirrel || +
                npc.type == NPCID.SquirrelRed || +
                npc.type == NPCID.Buggy || +
                npc.type == NPCID.EnchantedNightcrawler || +
                npc.type == NPCID.Grubby || +
                npc.type == NPCID.Sluggy || +
                npc.type == NPCID.Worm || +
                npc.type == NPCID.Grasshopper || +
                npc.type == NPCID.GlowingSnail || +
                npc.type == NPCID.Snail || +
                npc.type == NPCID.Goldfish || +
                npc.type == NPCID.GoldfishWalker || +
                npc.type == NPCID.Butterfly || +
                npc.type == NPCID.GoldBird || +
                npc.type == NPCID.GoldBunny || +
                npc.type == NPCID.GoldButterfly || +
                npc.type == NPCID.GoldFrog || +
                npc.type == NPCID.GoldGrasshopper || +
                npc.type == NPCID.GoldMouse || +
                npc.type == NPCID.GoldWorm || +
                npc.type == NPCID.SquirrelGold || +
                npc.type == NPCID.TruffleWorm || +
                npc.type == NPCID.TruffleWormDigger))//Checks if NPC is critter, isn't Eternia Crystal and has appropriate configs
            {
                return false;
            }
            else
            {
                return base.CanBeHitByItem(npc, player, item);
            }
        }
        public override bool? CanBeHitByProjectile(NPC npc, Projectile projectile)
        {
            if (Config.Instance.allCrittersPlayerImmortal && npc.type != NPCID.DD2EterniaCrystal && (npc.type == NPCID.Bird || +
                npc.type == NPCID.BirdBlue || +
                npc.type == NPCID.BirdRed || +
                npc.type == NPCID.Firefly || +
                npc.type == NPCID.LightningBug || +
                npc.type == NPCID.Bunny || +
                npc.type == NPCID.BunnySlimed || +
                npc.type == NPCID.BunnyXmas || +
                npc.type == NPCID.PartyBunny || +
                npc.type == NPCID.Duck || +
                npc.type == NPCID.Duck2 || +
                npc.type == NPCID.DuckWhite || +
                npc.type == NPCID.DuckWhite2 || +
                npc.type == NPCID.Frog || +
                npc.type == NPCID.Mouse || +
                npc.type == NPCID.Penguin || +
                npc.type == NPCID.PenguinBlack || +
                npc.type == NPCID.Scorpion || +
                npc.type == NPCID.ScorpionBlack || +
                npc.type == NPCID.Squirrel || +
                npc.type == NPCID.SquirrelRed || +
                npc.type == NPCID.Buggy || +
                npc.type == NPCID.EnchantedNightcrawler || +
                npc.type == NPCID.Grubby || +
                npc.type == NPCID.Sluggy || +
                npc.type == NPCID.Worm || +
                npc.type == NPCID.Grasshopper || +
                npc.type == NPCID.GlowingSnail || +
                npc.type == NPCID.Snail || +
                npc.type == NPCID.Goldfish || +
                npc.type == NPCID.GoldfishWalker || +
                npc.type == NPCID.Butterfly || +
                npc.type == NPCID.GoldBird || +
                npc.type == NPCID.GoldBunny || +
                npc.type == NPCID.GoldButterfly || +
                npc.type == NPCID.GoldFrog || +
                npc.type == NPCID.GoldGrasshopper || +
                npc.type == NPCID.GoldMouse || +
                npc.type == NPCID.GoldWorm || +
                npc.type == NPCID.SquirrelGold || +
                npc.type == NPCID.TruffleWorm || +
                npc.type == NPCID.TruffleWormDigger))//Checks if NPC is critter, isn't She-Ra Crystal and has appropriate configs
            {
                return false;
            }
            else
            {
                return base.CanBeHitByProjectile(npc, projectile);
            }
        }
        #endregion
        #region NPC hitting friendly NPC
        public override bool? CanHitNPC(NPC hitter, NPC npc)
        {
            if (Config.Instance.allNPCsEnemyImmortal && npc.friendly && npc.type != NPCID.DD2EterniaCrystal)
            {
                return false;
            }
            if (Config.Instance.allCrittersEnemyImmortal && (npc.type == NPCID.Bird || +
                npc.type == NPCID.BirdBlue || +
                npc.type == NPCID.BirdRed || +
                npc.type == NPCID.Firefly || +
                npc.type == NPCID.LightningBug || +
                npc.type == NPCID.Bunny || +
                npc.type == NPCID.BunnySlimed || +
                npc.type == NPCID.BunnyXmas || +
                npc.type == NPCID.PartyBunny || +
                npc.type == NPCID.Duck || +
                npc.type == NPCID.Duck2 || +
                npc.type == NPCID.DuckWhite || +
                npc.type == NPCID.DuckWhite2 || +
                npc.type == NPCID.Frog || +
                npc.type == NPCID.Mouse || +
                npc.type == NPCID.Penguin || +
                npc.type == NPCID.PenguinBlack || +
                npc.type == NPCID.Scorpion || +
                npc.type == NPCID.ScorpionBlack || +
                npc.type == NPCID.Squirrel || +
                npc.type == NPCID.SquirrelRed || +
                npc.type == NPCID.Buggy || +
                npc.type == NPCID.EnchantedNightcrawler || +
                npc.type == NPCID.Grubby || +
                npc.type == NPCID.Sluggy || +
                npc.type == NPCID.Worm || +
                npc.type == NPCID.Grasshopper || +
                npc.type == NPCID.GlowingSnail || +
                npc.type == NPCID.Snail || +
                npc.type == NPCID.Goldfish || +
                npc.type == NPCID.GoldfishWalker || +
                npc.type == NPCID.Butterfly || +
                npc.type == NPCID.GoldBird || +
                npc.type == NPCID.GoldBunny || +
                npc.type == NPCID.GoldButterfly || +
                npc.type == NPCID.GoldFrog || +
                npc.type == NPCID.GoldGrasshopper || +
                npc.type == NPCID.GoldMouse || +
                npc.type == NPCID.GoldWorm || +
                npc.type == NPCID.SquirrelGold || +
                npc.type == NPCID.TruffleWorm || +
                npc.type == NPCID.TruffleWormDigger))
            {
                return false;
            }
            else
            {
                return base.CanHitNPC(hitter, npc);
            }
        }
        #endregion
    }
}
// npc.type != NPCID.DD2EterniaCrystal checks if the NPC isn't an Eternia Crystal
// npc.maxLife == 5 checks if an NPC is a critter, as only critter have 5 HP
// ^^ removed as bugs and replaced with the all critters vanilla 
// !Config.Instance.allCrittersImmortal checks if the Immortal Config setting is disabled, as enabling it will render other settings useless anyways
// Other configs speak for themselves on what they do
// Yes this is some crappy code but I didn't see you making this... so... meh >:)