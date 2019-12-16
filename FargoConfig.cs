﻿
using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using Terraria;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace FargowiltasSouls
{
    class SoulConfig : ModConfig
    {

        public override ConfigScope Mode => ConfigScope.ClientSide;
        public static SoulConfig Instance;

        [Header("$Mods.FargowiltasSouls.WoodHeader")]
        [Label("$Mods.FargowiltasSouls.BorealConfig")]
        [DefaultValue(true)]
        public bool BorealSnowballs;

        [Label("$Mods.FargowiltasSouls.EbonConfig")]
        [DefaultValue(true)]
        public bool EbonwoodAura;

        [Label("$Mods.FargowiltasSouls.ShadeConfig")]
        [DefaultValue(true)]
        public bool ShadewoodEffect;

        //[Label("[" +  "i:19][c/00FF00: Green Text]")]
        [Label("$Mods.FargowiltasSouls.MahoganyConfig")]
        //[BackgroundColor(181, 108, 100)]
        [DefaultValue(true)]
        public bool MahoganyHook;

        [Label("$Mods.FargowiltasSouls.PalmConfig")]
        [DefaultValue(true)]
        public bool PalmwoodSentry;

        [Label("$Mods.FargowiltasSouls.PearlConfig")]
        [DefaultValue(true)]
        public bool PearlwoodStars;

        [Header("$Mods.FargowiltasSouls.EarthHeader")]
        [Label("$Mods.FargowiltasSouls.AdamantiteConfig")]
        [DefaultValue(true)]
        public bool AdamantiteSplit;

        [Label("$Mods.FargowiltasSouls.CobaltConfig")]
        [DefaultValue(true)]
        public bool CobaltShards;

        [Label("$Mods.FargowiltasSouls.AncientCobaltConfig")]
        [DefaultValue(true)]
        public bool CobaltStingers;

        [Label("$Mods.FargowiltasSouls.MythrilConfig")]
        [DefaultValue(true)]
        public bool MythrilSpeed;

        [Label("$Mods.FargowiltasSouls.OrichalcumConfig")]
        [DefaultValue(true)]
        public bool OrichalcumFire;

        [Label("$Mods.FargowiltasSouls.PalladiumConfig")]
        [DefaultValue(true)]
        public bool PalladiumHeal;

        [Label("$Mods.FargowiltasSouls.TitaniumConfig")]
        [DefaultValue(true)]
        public bool TitaniumDodge;

        [Header("$Mods.FargowiltasSouls.TerraHeader")]
        [Label("$Mods.FargowiltasSouls.CopperConfig")]
        [DefaultValue(true)]
        public bool CopperLightning;

        [Label("$Mods.FargowiltasSouls.IronMConfig")]
        [DefaultValue(true)]
        public bool IronMagnet;

        [Label("$Mods.FargowiltasSouls.IronSConfig")]
        [DefaultValue(true)]
        public bool IronShield;

        [Label("$Mods.FargowiltasSouls.CthulhuShield")]
        [DefaultValue(true)]
        public bool CthulhuShield;

        [Label("$Mods.FargowiltasSouls.TinConfig")]
        [DefaultValue(true)]
        public bool TinCrit;

        [Label("$Mods.FargowiltasSouls.TungstenConfig")]
        [DefaultValue(true)]
        public bool TungstenSize;

        [Header("$Mods.FargowiltasSouls.WillHeader")]
        [Label("$Mods.FargowiltasSouls.GladiatorConfig")]
        [DefaultValue(true)]
        public bool GladiatorJavelins;

        [Label("$Mods.FargowiltasSouls.GoldConfig")]
        [DefaultValue(true)]
        public bool LuckyCoin;

        [Label("$Mods.FargowiltasSouls.HuntressConfig")]
        [DefaultValue(true)]
        public bool HuntressAbility;

        [Label("$Mods.FargowiltasSouls.RedRidingConfig")]
        [DefaultValue(true)]
        public bool redBleed;

        [Label("$Mods.FargowiltasSouls.ValhallaConfig")]
        [DefaultValue(true)]
        public bool ValhallaKB;

        [Header("$Mods.FargowiltasSouls.LifeHeader")]
        [Label("$Mods.FargowiltasSouls.BeetleConfig")]
        [DefaultValue(true)]
        public bool BeetleEffect;

        [Label("$Mods.FargowiltasSouls.CactusConfig")]
        [DefaultValue(true)]
        public bool CactusNeedles;

        [Label("$Mods.FargowiltasSouls.PumpkinConfig")]
        [DefaultValue(true)]
        public bool PumpkinFire;

        [Label("$Mods.FargowiltasSouls.SpiderConfig")]
        [DefaultValue(true)]
        public bool SpiderCrits;

        [Label("$Mods.FargowiltasSouls.TurtleConfig")]
        [DefaultValue(true)]
        public bool TurtleShell;

        [Header("$Mods.FargowiltasSouls.NatureHeader")]
        [Label("$Mods.FargowiltasSouls.ChlorophyteConfig")]
        [DefaultValue(true)]
        public bool ChlorophyteCrystals;

        [Label("$Mods.FargowiltasSouls.CrimsonConfig")]
        [DefaultValue(true)]
        public bool CrimsonRegen;

        [Label("$Mods.FargowiltasSouls.FrostConfig")]
        [DefaultValue(true)]
        public bool FrostIcicles;

        [Label("$Mods.FargowiltasSouls.JungleConfig")]
        [DefaultValue(true)]
        public bool JungleSpores;

        [Label("$Mods.FargowiltasSouls.MoltenConfig")]
        [DefaultValue(true)]
        public bool MoltenInferno;

        [Label("$Mods.FargowiltasSouls.ShroomiteConfig")]
        [DefaultValue(true)]
        public bool ShroomiteStealth;

        [Header("$Mods.FargowiltasSouls.ShadowHeader")]
        [Label("$Mods.FargowiltasSouls.DarkArtConfig")]
        [DefaultValue(true)]
        public bool DarkArtistEffect;

        [Label("$Mods.FargowiltasSouls.NecroConfig")]
        [DefaultValue(true)]
        public bool NecroGuardian;

        [Label("$Mods.FargowiltasSouls.AncientShadowConfig")]
        [DefaultValue(true)]
        public bool AncientShadow;

        [Label("$Mods.FargowiltasSouls.ShadowConfig")]
        [DefaultValue(true)]
        public bool ShadowDarkness;

        [Label("$Mods.FargowiltasSouls.ShinobiConfig")]
        [DefaultValue(true)]
        public bool ShinobiWalls;

        [Label("$Mods.FargowiltasSouls.ShinobiTabiConfig")]
        [DefaultValue(true)]
        public bool ShinobiTabi;

        [Label("$Mods.FargowiltasSouls.SpookyConfig")]
        [DefaultValue(true)]
        public bool SpookyScythes;

        [Header("$Mods.FargowiltasSouls.SpiritHeader")]
        [Label("$Mods.FargowiltasSouls.ForbiddenConfig")]
        [DefaultValue(true)]
        public bool ForbiddenStorm;

        [Label("$Mods.FargowiltasSouls.HallowedConfig")]
        [DefaultValue(true)]
        public bool HallowSword;

        [Label("$Mods.FargowiltasSouls.HalllowSConfig")]
        [DefaultValue(true)]
        public bool HallowShield;

        [Label("$Mods.FargowiltasSouls.SilverConfig")]
        [DefaultValue(true)]
        public bool SilverSword;

        [Label("$Mods.FargowiltasSouls.SpectreConfig")]
        [DefaultValue(true)]
        public bool SpectreOrbs;

        [Label("$Mods.FargowiltasSouls.TikiConfig")]
        [DefaultValue(true)]
        public bool TikiMinions;

        [Header("$Mods.FargowiltasSouls.CosmoHeader")]
        [Label("$Mods.FargowiltasSouls.MeteorConfig")]
        [DefaultValue(true)]
        public bool MeteorShower;

        [Label("$Mods.FargowiltasSouls.NebulaConfig")]
        [DefaultValue(true)]
        public bool NebulaBoost;

        [Label("$Mods.FargowiltasSouls.SolarConfig")]
        [DefaultValue(true)]
        public bool SolarShield;

        [Label("$Mods.FargowiltasSouls.StardustConfig")]
        [DefaultValue(true)]
        public bool StardustGuardian;

        [Label("$Mods.FargowiltasSouls.VortexSConfig")]
        [DefaultValue(true)]
        public bool VortexStealth;

        [Label("$Mods.FargowiltasSouls.VortexVConfig")]
        [DefaultValue(true)]
        public bool VortexVoid;

        #region maso accessories

        [Header("$Mods.FargowiltasSouls.MasoHeader")]
        [Label("$Mods.FargowiltasSouls.MasoBossRecolors")]
        [DefaultValue(true)]
        public bool BossRecolors;

        [Label("$Mods.FargowiltasSouls.MasoIconConfig")]
        [DefaultValue(true)]
        public bool SinisterIcon;

        [Header("$Mods.FargowiltasSouls.SupremeFairyHeader")]
        [Label("$Mods.FargowiltasSouls.MasoSlimeConfig")]
        [DefaultValue(true)]
        public bool SlimyShield;

        [Label("$Mods.FargowiltasSouls.MasoEyeConfig")]
        [DefaultValue(true)]
        public bool AgitatedLens;

        [Label("$Mods.FargowiltasSouls.MasoSkeleConfig")]
        [DefaultValue(true)]
        public bool NecromanticBrew;

        [Header("$Mods.FargowiltasSouls.BionomicHeader")]
        [Label("$Mods.FargowiltasSouls.MasoConcoctionConfig")]
        [DefaultValue(true)]
        public bool TimsConcoction;

        [Label("$Mods.FargowiltasSouls.MasoRainbowConfig")]
        [DefaultValue(true)]
        public bool RainbowSlime;

        [Label("$Mods.FargowiltasSouls.MasoFrigidConfig")]
        [DefaultValue(true)]
        public bool FrigidGemstone;

        [Label("$Mods.FargowiltasSouls.MasoNymphConfig")]
        [DefaultValue(true)]
        public bool NymphPerfume;

        [Label("$Mods.FargowiltasSouls.MasoSqueakConfig")]
        [DefaultValue(true)]
        public bool SqueakyToy;

        [Label("$Mods.FargowiltasSouls.MasoPouchConfig")]
        [DefaultValue(true)]
        public bool WretchedPouch;

        [Label("$Mods.FargowiltasSouls.MasoClippedConfig")]
        [DefaultValue(true)]
        public bool DragonFang;

        [Label("$Mods.FargowiltasSouls.WalletHeader")]
        public WalletToggles walletToggles = new WalletToggles();

        [Header("$Mods.FargowiltasSouls.DubiousHeader")]
        [Label("$Mods.FargowiltasSouls.MasoLightningConfig")]
        [DefaultValue(true)]
        public bool LightningRod;

        [Label("$Mods.FargowiltasSouls.MasoProbeConfig")]
        [DefaultValue(true)]
        public bool ProbeMinion;

        [Header("$Mods.FargowiltasSouls.PureHeartHeader")]
        [Label("$Mods.FargowiltasSouls.MasoEaterConfig")]
        [DefaultValue(true)]
        public bool CorruptHeart;

        [Label("$Mods.FargowiltasSouls.MasoBrainConfig")]
        [DefaultValue(true)]
        public bool GuttedHeart;

        [Header("$Mods.FargowiltasSouls.LumpofFleshHeader")]
        [Label("$Mods.FargowiltasSouls.MasoPugentConfig")]
        [DefaultValue(true)]
        public bool PungentEye;

        [Header("$Mods.FargowiltasSouls.ChaliceHeader")]
        [Label("$Mods.FargowiltasSouls.MasoCultistConfig")]
        [DefaultValue(true)]
        public bool CultistMinion;

        [Label("$Mods.FargowiltasSouls.MasoPlantConfig")]
        [DefaultValue(true)]
        public bool PlanteraMinion;

        [Label("$Mods.FargowiltasSouls.MasoGolemConfig")]
        [DefaultValue(true)]
        public bool LihzahrdBoxGeysers;

        [Label("$Mods.FargowiltasSouls.MasoSpikeConfig")]
        [DefaultValue(true)]
        public bool LihzahrdBoxSpikyBalls;

        [Label("$Mods.FargowiltasSouls.MasoCelestConfig")]
        [DefaultValue(true)]
        public bool CelestialRune;

        [Label("$Mods.FargowiltasSouls.MasoVisionConfig")]
        [DefaultValue(true)]
        public bool AncientVisions;

        [Header("$Mods.FargowiltasSouls.HeartHeader")]
        [Label("$Mods.FargowiltasSouls.MasoPump")]
        [DefaultValue(true)]
        public bool PumpkingCape;

        [Label("$Mods.FargowiltasSouls.MasoFlockoConfig")]
        [DefaultValue(true)]
        public bool FlockoMinion;

        [Label("$Mods.FargowiltasSouls.MasoUfoConfig")]
        [DefaultValue(true)]
        public bool UFOMinion;

        [Label("$Mods.FargowiltasSouls.MasoGravConfig")]
        [DefaultValue(true)]
        public bool GravityControl;

        [Label("$Mods.FargowiltasSouls.MasoGrav2Config")]
        [DefaultValue(true)]
        public bool StabilizedGravity;

        [Label("$Mods.FargowiltasSouls.MasoTrueEyeConfig")]
        [DefaultValue(true)]
        public bool TrueEyes;

        [Header("$Mods.FargowiltasSouls.CyclonicHeader")]
        [Label("$Mods.FargowiltasSouls.MasoFishronConfig")]
        [DefaultValue(true)]
        public bool FishronMinion;

        [Header("$Mods.FargowiltasSouls.MutantArmorHeader")]
        [Label("$Mods.FargowiltasSouls.MasoAbomConfig")]
        [DefaultValue(true)]
        public bool AbomMinion;

        [Label("$Mods.FargowiltasSouls.MasoRingConfig")]
        [DefaultValue(true)]
        public bool RingMinion;

        #endregion

        #region souls
        [Header("$Mods.FargowiltasSouls.SoulHeader")]
        [Label("$Mods.FargowiltasSouls.MeleeConfig")]
        [DefaultValue(true)]
        public bool BerserkerAttackSpeed;

        [Label("$Mods.FargowiltasSouls.SniperConfig")]
        [DefaultValue(true)]
        public bool SniperScope;

        [Label("$Mods.FargowiltasSouls.UniverseConfig")]
        [DefaultValue(true)]
        public bool UniverseAttackSpeed;

        [Label("$Mods.FargowiltasSouls.MiningHuntConfig")]
        [DefaultValue(true)]
        public bool MinerHunter;

        [Label("$Mods.FargowiltasSouls.MiningDangerConfig")]
        [DefaultValue(true)]
        public bool MinerDanger;

        [Label("$Mods.FargowiltasSouls.MiningSpelunkConfig")]
        [DefaultValue(true)]
        public bool MinerSpelunker;

        [Label("$Mods.FargowiltasSouls.MiningShineConfig")]
        [DefaultValue(true)]
        public bool MinerShine;

        [Label("$Mods.FargowiltasSouls.BuilderConfig")]
        [DefaultValue(true)]
        public bool BuilderMode;

        [Label("$Mods.FargowiltasSouls.DefenseSporeConfig")]
        [DefaultValue(true)]
        public bool SporeSac;

        [Label("$Mods.FargowiltasSouls.DefenseStarConfig")]
        [DefaultValue(true)]
        public bool StarCloak;

        [Label("$Mods.FargowiltasSouls.DefenseBeeConfig")]
        [DefaultValue(true)]
        public bool BeesOnHit;

        [Label("$Mods.FargowiltasSouls.SupersonicConfig")]
        [DefaultValue(true)]
        public bool SupersonicSpeed;

        [Label("$Mods.FargowiltasSouls.EternityConfig")]
        [DefaultValue(true)]
        public bool EternityStacking;

        #endregion

        #region pets
        [Header("$Mods.FargowiltasSouls.PetHeader")]
        [Label("$Mods.FargowiltasSouls.PetCatConfig")]
        [DefaultValue(true)]
        public bool BlackCatPet;

        [Label("$Mods.FargowiltasSouls.PetCubeConfig")]
        [DefaultValue(true)]
        public bool CompanionCubePet;

        [Label("$Mods.FargowiltasSouls.PetCurseSapConfig")]
        [DefaultValue(true)]
        public bool CursedSaplingPet;

        [Label("$Mods.FargowiltasSouls.PetDinoConfig")]
        [DefaultValue(true)]
        public bool DinoPet;

        [Label("$Mods.FargowiltasSouls.PetDragonConfig")]
        [DefaultValue(true)]
        public bool DragonPet;

        [Label("$Mods.FargowiltasSouls.PetEaterConfig")]
        [DefaultValue(true)]
        public bool EaterPet;

        [Label("$Mods.FargowiltasSouls.PetEyeSpringConfig")]
        [DefaultValue(true)]
        public bool EyeSpringPet;

        [Label("$Mods.FargowiltasSouls.PetFaceMonsterConfig")]
        [DefaultValue(true)]
        public bool FaceMonsterPet;

        [Label("$Mods.FargowiltasSouls.PetGatoConfig")]
        [DefaultValue(true)]
        public bool GatoPet;

        [Label("$Mods.FargowiltasSouls.PetHornetConfig")]
        [DefaultValue(true)]
        public bool HornetPet;

        [Label("$Mods.FargowiltasSouls.PetLizardConfig")]
        [DefaultValue(true)]
        public bool LizardPet;

        [Label("$Mods.FargowiltasSouls.PetMinitaurConfig")]
        [DefaultValue(true)]
        public bool MinotaurPet;

        [Label("$Mods.FargowiltasSouls.PetParrotConfig")]
        [DefaultValue(true)]
        public bool ParrotPet;

        [Label("$Mods.FargowiltasSouls.PetPenguinConfig")]
        [DefaultValue(true)]
        public bool PenguinPet;

        [Label("$Mods.FargowiltasSouls.PetPupConfig")]
        [DefaultValue(true)]
        public bool PuppyPet;

        [Label("$Mods.FargowiltasSouls.PetSeedConfig")]
        [DefaultValue(true)]
        public bool SeedlingPet;

        [Label("$Mods.FargowiltasSouls.PetDGConfig")]
        [DefaultValue(true)]
        public bool DGPet;

        [Label("$Mods.FargowiltasSouls.PetSnowmanConfig")]
        [DefaultValue(true)]
        public bool SnowmanPet;

        [Label("$Mods.FargowiltasSouls.PetSpiderConfig")]
        [DefaultValue(true)]
        public bool SpiderPet;

        [Label("$Mods.FargowiltasSouls.PetSquashConfig")]
        [DefaultValue(true)]
        public bool SquashlingPet;

        [Label("$Mods.FargowiltasSouls.PetTikiConfig")]
        [DefaultValue(true)]
        public bool TikiPet;

        [Label("$Mods.FargowiltasSouls.PetShroomConfig")]
        [DefaultValue(true)]
        public bool TrufflePet;

        [Label("$Mods.FargowiltasSouls.PetTurtleConfig")]
        [DefaultValue(true)]
        public bool TurtlePet;

        [Label("$Mods.FargowiltasSouls.PetZephyrConfig")]
        [DefaultValue(true)]
        public bool ZephyrFishPet;

        //LIGHT PETS
        [Label("$Mods.FargowiltasSouls.PetHeartConfig")]
        [DefaultValue(true)]
        public bool CrimsonHeartPet;

        [Label("$Mods.FargowiltasSouls.PetNaviConfig")]
        [DefaultValue(true)]
        public bool FairyPet;

        [Label("$Mods.FargowiltasSouls.PetFlickerConfig")]
        [DefaultValue(true)]
        public bool FlickerwickPet;

        [Label("$Mods.FargowiltasSouls.PetLanturnConfig")]
        [DefaultValue(true)]
        public bool MagicLanternPet;

        [Label("$Mods.FargowiltasSouls.PetOrbConfig")]
        [DefaultValue(true)]
        public bool ShadowOrbPet;

        [Label("$Mods.FargowiltasSouls.PetSuspEyeConfig")]
        [DefaultValue(true)]
        public bool SuspiciousEyePet;

        [Label("$Mods.FargowiltasSouls.PetWispConfig")]
        [DefaultValue(true)]
        public bool WispPet;

        #endregion

        [Label("$Mods.FargowiltasSouls.ThoriumHeader")]
        public ThoriumToggles thoriumToggles = new ThoriumToggles();

        [Label("$Mods.FargowiltasSouls.CalamityHeader")]
        public CalamityToggles calamityToggles = new CalamityToggles();


        //soa soon tm
       
        public override void OnLoaded()
        {
            Instance = this;
        }

        // Proper cloning of reference types is required because behind the scenes many instances of ModConfig classes co-exist.
        /*public override ModConfig Clone()
        {
            var clone = (SoulConfig)base.Clone();

            clone.walletToggles = walletToggles == null ? null : new WalletToggles();
            clone.thoriumToggles = thoriumToggles == null ? null : new ThoriumToggles();
            clone.calamityToggles = calamityToggles == null ? null : new CalamityToggles();

            return clone;
        }*/

        public bool GetValue(bool toggle, bool checkForMutantPresence = true)
        {
            if (checkForMutantPresence && Main.player[Main.myPlayer].GetModPlayer<FargoPlayer>().MutantPresence)
                return false;

            return toggle;
        }
    }

    public class WalletToggles
    {
        [Label("Warding")]
        [DefaultValue(true)]
        public bool Warding;

        [Label("Violent")]
        [DefaultValue(true)]
        public bool Violent;

        [Label("Quick")]
        [DefaultValue(true)]
        public bool Quick;

        [Label("Lucky")]
        [DefaultValue(true)]
        public bool Lucky;

        [Label("Menacing")]
        [DefaultValue(true)]
        public bool Menacing;

        [Label("Legendary")]
        [DefaultValue(true)]
        public bool Legendary;

        [Label("Unreal")]
        [DefaultValue(true)]
        public bool Unreal;

        [Label("Mythical")]
        [DefaultValue(true)]
        public bool Mythical;

        [Label("Godly")]
        [DefaultValue(true)]
        public bool Godly;

        [Label("Demonic")]
        [DefaultValue(true)]
        public bool Demonic;

        [Label("Ruthless")]
        [DefaultValue(true)]
        public bool Ruthless;

        [Label("Light")]
        [DefaultValue(true)]
        public bool Light;

        [Label("Deadly")]
        [DefaultValue(true)]
        public bool Deadly;

        [Label("Rapid")]
        [DefaultValue(true)]
        public bool Rapid;
    }

    public class ThoriumToggles
    {
        [Label("$Mods.FargowiltasSouls.ThoriumCrystalScorpionConfig")]
        [DefaultValue(true)]
        public bool CrystalScorpion;

        [Label("$Mods.FargowiltasSouls.ThoriumYumasPendantConfig")]
        [DefaultValue(true)]
        public bool YumasPendant;

        [Label("$Mods.FargowiltasSouls.ThoriumHeadMirrorConfig")]
        [DefaultValue(true)]
        public bool HeadMirror;

        [Label("$Mods.FargowiltasSouls.ThoriumAirWalkersConfig")]
        [DefaultValue(true)]
        public bool AirWalkers;

        [Label("$Mods.FargowiltasSouls.ThoriumGlitterPetConfig")]
        [DefaultValue(true)]
        public bool GlitterPet;

        [Label("$Mods.FargowiltasSouls.ThoriumCoinPetConfig")]
        [DefaultValue(true)]
        public bool CoinPet;

        [Label("$Mods.FargowiltasSouls.ThoriumBioFeederPetConfig")]
        [DefaultValue(true)]
        public bool BioFeederPet;

        [Label("$Mods.FargowiltasSouls.ThoriumLanternPetConfig")]
        [DefaultValue(true)]
        public bool LanternPet;

        [Label("$Mods.FargowiltasSouls.ThoriumBoxPetConfig")]
        [DefaultValue(true)]
        public bool BoxPet;

        [Header("$Mods.FargowiltasSouls.MuspelheimForce")]
        [Label("$Mods.FargowiltasSouls.ThoriumBeeBootiesConfig")]
        [DefaultValue(true)]
        public bool BeeBooties;

        [Label("$Mods.FargowiltasSouls.ThoriumSaplingMinionConfig")]
        [DefaultValue(true)]
        public bool SaplingMinion;

        [Header("$Mods.FargowiltasSouls.JotunheimForce")]
        [Label("$Mods.FargowiltasSouls.ThoriumJellyfishPetConfig")]
        [DefaultValue(true)]
        public bool JellyfishPet;

        [Label("$Mods.FargowiltasSouls.ThoriumTideFoamConfig")]
        [DefaultValue(true)]
        public bool TideFoam;

        [Label("$Mods.FargowiltasSouls.ThoriumYewCritsConfig")]
        [DefaultValue(true)]
        public bool YewCrits;

        [Label("$Mods.FargowiltasSouls.ThoriumCryoDamageConfig")]
        [DefaultValue(true)]
        public bool CryoDamage;

        [Label("$Mods.FargowiltasSouls.ThoriumOwlPetConfig")]
        [DefaultValue(true)]
        public bool OwlPet;

        [Label("$Mods.FargowiltasSouls.ThoriumIcyBarrierConfig")]
        [DefaultValue(true)]
        public bool IcyBarrier;

        [Label("$Mods.FargowiltasSouls.ThoriumWhisperingTentaclesConfig")]
        [DefaultValue(true)]
        public bool WhisperingTentacles;

        [Header("$Mods.FargowiltasSouls.AlfheimForce")]
        [Label("$Mods.FargowiltasSouls.ThoriumCherubMinionConfig")]
        [DefaultValue(true)]
        public bool CherubMinion;

        [Label("$Mods.FargowiltasSouls.ThoriumSpiritPetConfig")]
        [DefaultValue(true)]
        public bool SpiritPet;

        [Label("$Mods.FargowiltasSouls.ThoriumWarlockWispsConfig")]
        [DefaultValue(true)]
        public bool WarlockWisps;

        [Label("$Mods.FargowiltasSouls.ThoriumDevilMinionConfig")]
        [DefaultValue(true)]
        public bool DevilMinion;

        [Label("$Mods.FargowiltasSouls.ThoriumBiotechProbeConfig")]
        [DefaultValue(true)]
        public bool BiotechProbe;

        [Label("$Mods.FargowiltasSouls.ThoriumGoatPetConfig")]
        [DefaultValue(true)]
        public bool GoatPet;

        [Header("$Mods.FargowiltasSouls.NiflheimForce")]
        [Label("$Mods.FargowiltasSouls.ThoriumMixTapeConfig")]
        [DefaultValue(true)]
        public bool MixTape;

        [Label("$Mods.FargowiltasSouls.ThoriumCyberStatesConfig")]
        [DefaultValue(true)]
        public bool CyberStates;

        [Label("$Mods.FargowiltasSouls.ThoriumMetronomeConfig")]
        [DefaultValue(true)]
        public bool Metronome;

        [Header("$Mods.FargowiltasSouls.SvartalfheimForce")]
        [Label("$Mods.FargowiltasSouls.ThoriumEyeoftheStormConfig")]
        [DefaultValue(true)]
        public bool EyeoftheStorm;

        [Label("$Mods.FargowiltasSouls.ThoriumBronzeLightningConfig")]
        [DefaultValue(true)]
        public bool BronzeLightning;

        [Label("$Mods.FargowiltasSouls.ThoriumIncandescentSparkConfig")]
        [DefaultValue(true)]
        public bool IncandescentSpark;

        [Label("$Mods.FargowiltasSouls.ThoriumGreedyMagnetConfig")]
        [DefaultValue(true)]
        public bool GreedyMagnet;

        [Label("$Mods.FargowiltasSouls.ThoriumConduitShieldConfig")]
        [DefaultValue(true)]
        public bool ConduitShield;

        [Label("$Mods.FargowiltasSouls.ThoriumOmegaPetConfig")]
        [DefaultValue(true)]
        public bool OmegaPet;

        [Label("$Mods.FargowiltasSouls.ThoriumIFOPetConfig")]
        [DefaultValue(true)]
        public bool IFOPet;

        [Header("$Mods.FargowiltasSouls.MidgardForce")]
        [Label("$Mods.FargowiltasSouls.ThoriumLodestoneConfig")]
        [DefaultValue(true)]
        public bool LodestoneResist;

        [Label("$Mods.FargowiltasSouls.ThoriumBeholderEyeConfig")]
        [DefaultValue(true)]
        public bool BeholderEye;

        [Label("$Mods.FargowiltasSouls.ThoriumIllumiteMissileConfig")]
        [DefaultValue(true)]
        public bool IllumiteMissile;

        [Label("$Mods.FargowiltasSouls.ThoriumSlimePetConfig")]
        [DefaultValue(true)]
        public bool SlimePet;

        [Label("$Mods.FargowiltasSouls.ThoriumTerrariumSpiritsConfig")]
        [DefaultValue(true)]
        public bool TerrariumSpirits;

        [Label("$Mods.FargowiltasSouls.ThoriumDiverConfig")]
        [DefaultValue(true)]
        public bool ThoriumDivers;

        [Label("$Mods.FargowiltasSouls.ThoriumCrietzConfig")]
        [DefaultValue(true)]
        public bool Crietz;

        [Label("$Mods.FargowiltasSouls.ThoriumJesterBellConfig")]
        [DefaultValue(true)]
        public bool JesterBell;

        [Header("$Mods.FargowiltasSouls.VanaheimForce")]
        [Label("$Mods.FargowiltasSouls.ThoriumFolvAuraConfig")]
        [DefaultValue(true)]
        public bool FolvAura;

        [Label("$Mods.FargowiltasSouls.ThoriumFolvBoltsConfig")]
        [DefaultValue(true)]
        public bool FolvBolts;

        [Label("$Mods.FargowiltasSouls.ThoriumManaBootsConfig")]
        [DefaultValue(true)]
        public bool ManaBoots;

        [Label("$Mods.FargowiltasSouls.ThoriumWhiteDwarfConfig")]
        [DefaultValue(true)]
        public bool WhiteDwarf;

        [Label("$Mods.FargowiltasSouls.ThoriumCelestialAuraConfig")]
        [DefaultValue(true)]
        public bool CelestialAura;

        [Label("$Mods.FargowiltasSouls.ThoriumAscensionStatueConfig")]
        [DefaultValue(true)]
        public bool AscensionStatue;

        [Header("$Mods.FargowiltasSouls.HelheimForce")]
        [Label("$Mods.FargowiltasSouls.ThoriumSpiritWispsConfig")]
        [DefaultValue(true)]
        public bool SpiritTrapperWisps;

        [Label("$Mods.FargowiltasSouls.ThoriumDreadConfig")]
        [DefaultValue(true)]
        public bool DreadSpeed;

        [Label("$Mods.FargowiltasSouls.ThoriumDragonFlamesConfig")]
        [DefaultValue(true)]
        public bool DragonFlames;

        [Label("$Mods.FargowiltasSouls.ThoriumWyvernPetConfig")]
        [DefaultValue(true)]
        public bool WyvernPet;

        [Label("$Mods.FargowiltasSouls.ThoriumDemonBloodConfig")]
        [DefaultValue(true)]
        public bool DemonBloodEffect;

        [Label("$Mods.FargowiltasSouls.ThoriumFleshDropsConfig")]
        [DefaultValue(true)]
        public bool FleshDrops;

        [Label("$Mods.FargowiltasSouls.ThoriumVampireGlandConfig")]
        [DefaultValue(true)]
        public bool VampireGland;

        [Label("$Mods.FargowiltasSouls.ThoriumBlisterPetConfig")]
        [DefaultValue(true)]
        public bool BlisterPet;

        [Label("$Mods.FargowiltasSouls.ThoriumBerserkerConfig")]
        [DefaultValue(true)]
        public bool BerserkerEffect;

        [Label("$Mods.FargowiltasSouls.ThoriumSlagStompersConfig")]
        [DefaultValue(true)]
        public bool SlagStompers;

        [Label("$Mods.FargowiltasSouls.ThoriumSpringStepsConfig")]
        [DefaultValue(true)]
        public bool SpringSteps;

        [Label("$Mods.FargowiltasSouls.ThoriumHarbingerOverchargeConfig")]
        [DefaultValue(true)]
        public bool HarbingerOvercharge;

        [Label("$Mods.FargowiltasSouls.ThoriumMooglePetConfig")]
        [DefaultValue(true)]
        public bool MooglePet;

        [Label("$Mods.FargowiltasSouls.ThoriumPlagueFlaskConfig")]
        [DefaultValue(true)]
        public bool PlagueFlask;

        [Header("$Mods.FargowiltasSouls.AsgardForce")]
        [Label("$Mods.FargowiltasSouls.ThoriumTideGlobulesConfig")]
        [DefaultValue(true)]
        public bool TideGlobules;

        [Label("$Mods.FargowiltasSouls.ThoriumTideDaggersConfig")]
        [DefaultValue(true)]
        public bool TideDaggers;


        [Label("$Mods.FargowiltasSouls.ThoriumAssassinDamageConfig")]
        [DefaultValue(true)]
        public bool AssassinDamage;

        [Label("$Mods.FargowiltasSouls.ThoriumpyromancerBurstsConfig")]
        [DefaultValue(true)]
        public bool PyromancerBursts;

        [Label("$Mods.FargowiltasSouls.ThoriumMaidPetConfig")]
        [DefaultValue(true)]
        public bool MaidPet;
    }

    public class CalamityToggles
    {
        [Label("$Mods.FargowiltasSouls.CalamityElementalQuiverConfig")]
        [DefaultValue(true)]
        public bool ElementalQuiver;

        [Header("$Mods.FargowiltasSouls.ApocalypseForce")]
        [Label("$Mods.FargowiltasSouls.CalamityValkyrieMinionConfig")]
        [DefaultValue(true)]
        public bool ValkyrieMinion;

        [Label("$Mods.FargowiltasSouls.CalamityGladiatorLocketConfig")]
        [DefaultValue(true)]
        public bool GladiatorLocket;

        [Label("$Mods.FargowiltasSouls.CalamityUnstablePrismConfig")]
        [DefaultValue(true)]
        public bool UnstablePrism;

        [Label("$Mods.FargowiltasSouls.CalamityKendraConfig")]
        [DefaultValue(true)]
        public bool KendraPet;

        [Label("$Mods.FargowiltasSouls.CalamitySlimeMinionConfig")]
        [DefaultValue(true)]
        public bool SlimeMinion;

        [Label("$Mods.FargowiltasSouls.CalamityPerforatorConfig")]
        [DefaultValue(true)]
        public bool PerforatorPet;

        [Label("$Mods.FargowiltasSouls.CalamityDaedalusEffectsConfig")]
        [DefaultValue(true)]
        public bool DaedalusEffects;

        [Label("$Mods.FargowiltasSouls.CalamityDaedalusMinionConfig")]
        [DefaultValue(true)]
        public bool DaedalusMinion;

        [Label("$Mods.FargowiltasSouls.CalamityPermafrostPotionConfig")]
        [DefaultValue(true)]
        public bool PermafrostPotion;

        [Label("$Mods.FargowiltasSouls.CalamityRegeneratorConfig")]
        [DefaultValue(true)]
        public bool Regenerator;

        [Label("$Mods.FargowiltasSouls.CalamityBearConfig")]
        [DefaultValue(true)]
        public bool BearPet;

        [Label("$Mods.FargowiltasSouls.CalamityThirdSageConfig")]
        [DefaultValue(true)]
        public bool ThirdSagePet;

        [Label("$Mods.FargowiltasSouls.CalamityBloodflareEffectsConfig")]
        [DefaultValue(true)]
        public bool BloodflareEffects;

        [Label("$Mods.FargowiltasSouls.CalamityPolterMinesConfig")]
        [DefaultValue(true)]
        public bool PolterMines;

        [Header("$Mods.FargowiltasSouls.DesolationForce")]
        [Label("$Mods.FargowiltasSouls.CalamityUrchinConfig")]
        [DefaultValue(true)]
        public bool UrchinMinion;

        [Label("$Mods.FargowiltasSouls.CalamityLuxorGiftConfig")]
        [DefaultValue(true)]
        public bool LuxorGift;

        [Label("$Mods.FargowiltasSouls.CalamityXerocEffectsConfig")]
        [DefaultValue(true)]
        public bool XerocEffects;

        [Label("$Mods.FargowiltasSouls.CalamitySilvaEffectsConfig")]
        [DefaultValue(true)]
        public bool SilvaEffects;

        [Label("$Mods.FargowiltasSouls.CalamitySilvaMinionConfig")]
        [DefaultValue(true)]
        public bool SilvaMinion;

        [Label("$Mods.FargowiltasSouls.CalamityGodlyArtifactConfig")]
        [DefaultValue(true)]
        public bool GodlySoulArtifact;

        [Label("$Mods.FargowiltasSouls.CalamityYharimGiftConfig")]
        [DefaultValue(true)]
        public bool YharimGift;

        [Label("$Mods.FargowiltasSouls.CalamityFungalMinionConfig")]
        [DefaultValue(true)]
        public bool FungalMinion;

        [Label("$Mods.FargowiltasSouls.CalamityPoisonSeawaterConfig")]
        [DefaultValue(true)]
        public bool PoisonSeawater;

        [Label("$Mods.FargowiltasSouls.CalamityAkatoConfig")]
        [DefaultValue(true)]
        public bool AkatoPet;

        [Label("$Mods.FargowiltasSouls.CalamityFoxConfig")]
        [DefaultValue(true)]
        public bool FoxPet;

        [Label("$Mods.FargowiltasSouls.CalamityOmegaTentaclesConfig")]
        [DefaultValue(true)]
        public bool OmegaTentacles;

        [Label("$Mods.FargowiltasSouls.CalamityDivingSuitConfig")]
        [DefaultValue(true)]
        public bool DivingSuit;

        [Label("$Mods.FargowiltasSouls.CalamitySirenConfig")]
        [DefaultValue(true)]
        public bool SirenPet;

        [Label("$Mods.FargowiltasSouls.CalamityGodSlayerEffectsConfig")]
        [DefaultValue(true)]
        public bool GodSlayerEffects;

        [Label("$Mods.FargowiltasSouls.CalamityMechwormMinionConfig")]
        [DefaultValue(true)]
        public bool MechwormMinion;

        [Label("$Mods.FargowiltasSouls.CalamityNebulousCoreConfig")]
        [DefaultValue(true)]
        public bool NebulousCore;

        [Label("$Mods.FargowiltasSouls.CalamityChibiiConfig")]
        [DefaultValue(true)]
        public bool ChibiiPet;

        [Label("$Mods.FargowiltasSouls.CalamityAuricEffectsConfig")]
        [DefaultValue(true)]
        public bool AuricEffects;

        [Label("$Mods.FargowiltasSouls.CalamityWaifuMinionsConfig")]
        [DefaultValue(true)]
        public bool WaifuMinions;

        [Header("$Mods.FargowiltasSouls.DevastationForce")]
        [Label("$Mods.FargowiltasSouls.CalamityShellfishMinionConfig")]
        [DefaultValue(true)]
        public bool ShellfishMinion;

        [Label("$Mods.FargowiltasSouls.CalamityAmidiasPendantConfig")]
        [DefaultValue(true)]
        public bool AmidiasPendant;

        [Label("$Mods.FargowiltasSouls.CalamityGiantPearlConfig")]
        [DefaultValue(true)]
        public bool GiantPearl;

        [Label("$Mods.FargowiltasSouls.CalamityDannyConfig")]
        [DefaultValue(true)]
        public bool DannyPet;

        [Label("$Mods.FargowiltasSouls.CalamityReaverEffectsConfig")]
        [DefaultValue(true)]
        public bool ReaverEffects;

        [Label("$Mods.FargowiltasSouls.CalamityReaverMinionConfig")]
        [DefaultValue(true)]
        public bool ReaverMinion;

        [Label("$Mods.FargowiltasSouls.CalamityFabledTurtleConfig")]
        [DefaultValue(true)]
        public bool FabledTurtleShell;

        [Label("$Mods.FargowiltasSouls.CalamityAtaxiaEffectsConfig")]
        [DefaultValue(true)]
        public bool AtaxiaEffects;

        [Label("$Mods.FargowiltasSouls.CalamityChaosMinionConfig")]
        [DefaultValue(true)]
        public bool ChaosMinion;

        [Label("$Mods.FargowiltasSouls.CalamityPlagueHiveConfig")]
        [DefaultValue(true)]
        public bool PlagueHive;

        [Label("$Mods.FargowiltasSouls.CalamityBrimlingConfig")]
        [DefaultValue(true)]
        public bool BrimlingPet;

        [Label("$Mods.FargowiltasSouls.CalamityAstralStarsConfig")]
        [DefaultValue(true)]
        public bool AstralStars;

        [Label("$Mods.FargowiltasSouls.CalamityTarragonEffectsConfig")]
        [DefaultValue(true)]
        public bool TarragonEffects;

        [Label("$Mods.FargowiltasSouls.CalamityProfanedArtifactConfig")]
        [DefaultValue(true)]
        public bool ProfanedSoulArtifact;

        [Label("$Mods.FargowiltasSouls.CalamityDevilMinionConfig")]
        [DefaultValue(true)]
        public bool RedDevilMinion;

        [Label("$Mods.FargowiltasSouls.CalamityLeviConfig")]
        [DefaultValue(true)]
        public bool LeviPet;
    }
}
