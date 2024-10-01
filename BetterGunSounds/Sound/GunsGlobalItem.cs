using Microsoft.Xna.Framework;
using BetterGunSounds.Sound;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Audio;
using Terraria.ModLoader;
using Terraria.DataStructures;
using Terraria.GameContent.Creative;
using static Terraria.ModLoader.ModContent;

namespace BetterGunSounds.Sound
{
	public class GunsGlobalItem : GlobalItem
	{
		public override void SetDefaults(Item item)
		{
			if (item.type is ItemID.Minishark or ItemID.Megashark)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/Minishark")
					{
						PitchVariance = .2f
					};
			}

			if (item.type is ItemID.FlintlockPistol)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/FlintlockPistol");
			}

			if (item.type is ItemID.Musket)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/Musket");
			}

			if (item.type is ItemID.Boomstick)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/Boomstick")
					{
						PitchVariance = .2f
					};
			}

			if (item.type is ItemID.Revolver)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/Revolver");
			}

			if (item.type is ItemID.RedRyder)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/RedRyder");
			}

			if (item.type is ItemID.TheUndertaker)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/TheUndertaker");
			}

			if (item.type is ItemID.QuadBarrelShotgun)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/QuadBarrelShotgun")
					{
						PitchVariance = .2f
					};
			}

			if (item.type is ItemID.Handgun)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/Handgun")
					{
						PitchVariance = .1f
					};
			}

			if (item.type is ItemID.PhoenixBlaster)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/PhoenixBlaster")
					{
						PitchVariance = .1f
					};

			}

			if (item.type is ItemID.PewMaticHorn)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/PewMaticHorn")
					{
						PitchVariance = .1f
					};
			}

			if (item.type is ItemID.SnowballCannon)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/SnowballCannon")
					{
						PitchVariance = .1f
					};

			}

			if (item.type is ItemID.Sandgun)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/Sandgun")
					{
						PitchVariance = .1f
					};

			}

			if (item.type is ItemID.ClockworkAssaultRifle)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/ClockworkAssaultRifle");

			}

			if (item.type is ItemID.Gatligator)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/Gatligator")
					{
						PitchVariance = .2f
					};

			}

			if (item.type is ItemID.Shotgun)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/Shotgun");

			}

			if (item.type is ItemID.OnyxBlaster)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/OnyxBlaster");

			}

			if (item.type is ItemID.Uzi)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/Uzi")
					{
						PitchVariance = .2f
					};

			}

			if (item.type is ItemID.VenusMagnum)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/VenusMagnum")
					{
						PitchVariance = .2f
					};

			}

			if (item.type is ItemID.TacticalShotgun)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/TacticalShotgun");

			}

			if (item.type is ItemID.SniperRifle)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/SniperRifle");

			}

			if (item.type is ItemID.CandyCornRifle)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/CandyCornRifle");

			}

			if (item.type is ItemID.ChainGun)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/ChainGun")
					{
						PitchVariance = .2f
					};

			}

			if (item.type is ItemID.Xenopopper)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/Xenopopper");

			}

			if (item.type is ItemID.SDMG)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/SDMG");

			}

			if (item.type is ItemID.GrenadeLauncher)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/GrenadeLauncher");

			}

			if (item.type is ItemID.ProximityMineLauncher)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/ProximityMineLauncher");

			}

			if (item.type is ItemID.RocketLauncher)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/RocketLauncher");

			}

			if (item.type is ItemID.NailGun)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/NailGun")
					{
						PitchVariance = .2f
					};

			}

			if (item.type is ItemID.JackOLanternLauncher)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/JackOLanternLauncher");

			}

			if (item.type is ItemID.SnowmanCannon)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/SnowmanCannon");

			}

			if (item.type is ItemID.Stynger)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/Stynger");

			}

			if (item.type is ItemID.ElectrosphereLauncher)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/ElectrosphereLauncher");

			}

			if (item.type is ItemID.FireworksLauncher or ItemID.Celeb2)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/FireworksLauncher")
					{
						PitchVariance = .2f
					};

			}

			if (item.type is ItemID.DartPistol or ItemID.DartRifle)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/DartPistol");

			}

			if (item.type is ItemID.CoinGun)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/CoinGun")
					{
						PitchVariance = .1f
					};

			}

			if (item.type is ItemID.SpaceGun)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/SpaceGun");

			}

			if (item.type is ItemID.BeeGun or ItemID.WaspGun)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/BeeGun")
					{
						PitchVariance = .2f
					};

			}

			if (item.type is ItemID.LaserRifle)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/LaserRifle");

			}

			if (item.type is ItemID.LeafBlower)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/LeafBlower");

			}

			if (item.type is ItemID.HeatRay)
			{
				if (!Main.dedServ)
					item.UseSound = new SoundStyle("BetterGunSounds/Sound/HeatRay");

			}
		}
	}
}