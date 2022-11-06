using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class RO2_GameConfigExtended_Template : GameConfigExtended_Template {
		public uint test;
		public Path PreviewGlobox;
		public Path PreviewTeensy;
		public Path LeaderboardMap;
		public Path LeaderboardPlayerFace;
		public Path LeaderboardPlayerBubble;
		public Path LeaderboardPlayerYou;
		public Path LeaderboardFlag;
		public Path LeaderboardGodRay;
		public Path LeaderboardPannel;
		public Path PlayerProfileFlag;
		public Path LeaderboardPlayerName;
		public Path SideGreenToadPath;
		public Path SideSplinterToadPath;
		public Path SideMinotaursPath;
		public Path SideDevilBobPath;
		public Path SideSwordmanPath;
		public Vec2d SideGreenToadOffset;
		public Vec2d SideSplinterToadOffset;
		public Vec2d SideMinotaursOffset;
		public Vec2d SideDevilBobOffset;
		public Vec2d SideSwordmanOffset;
		public CMap<string, uint> CountryAtlasList;
		public CMap<RLC_GraphicalFamily, RegionPathList> regionBackgrounds;
		public CMap<uint, Path> eventBackgrounds;
		public CMap<RLC_SocialManager.eScreenShotType, RO2_GameConfigExtended_Template.ShareConfig> shareConfigScreenShotType;
		public CMap<uint, RO2_GameConfigExtended_Template.ShareConfig> shareConfigFamilyShowcase;
		public CMap<StringID, RO2_GameConfigExtended_Template.ShareConfig> shareConfigCostumeShowcase;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			test = s.Serialize<uint>(test, name: "test");
			PreviewGlobox = s.SerializeObject<Path>(PreviewGlobox, name: "PreviewGlobox");
			PreviewTeensy = s.SerializeObject<Path>(PreviewTeensy, name: "PreviewTeensy");
			LeaderboardMap = s.SerializeObject<Path>(LeaderboardMap, name: "LeaderboardMap");
			LeaderboardPlayerFace = s.SerializeObject<Path>(LeaderboardPlayerFace, name: "LeaderboardPlayerFace");
			LeaderboardPlayerBubble = s.SerializeObject<Path>(LeaderboardPlayerBubble, name: "LeaderboardPlayerBubble");
			LeaderboardPlayerYou = s.SerializeObject<Path>(LeaderboardPlayerYou, name: "LeaderboardPlayerYou");
			LeaderboardFlag = s.SerializeObject<Path>(LeaderboardFlag, name: "LeaderboardFlag");
			LeaderboardGodRay = s.SerializeObject<Path>(LeaderboardGodRay, name: "LeaderboardGodRay");
			LeaderboardPannel = s.SerializeObject<Path>(LeaderboardPannel, name: "LeaderboardPannel");
			PlayerProfileFlag = s.SerializeObject<Path>(PlayerProfileFlag, name: "PlayerProfileFlag");
			LeaderboardPlayerName = s.SerializeObject<Path>(LeaderboardPlayerName, name: "LeaderboardPlayerName");
			SideGreenToadPath = s.SerializeObject<Path>(SideGreenToadPath, name: "SideGreenToadPath");
			SideSplinterToadPath = s.SerializeObject<Path>(SideSplinterToadPath, name: "SideSplinterToadPath");
			SideMinotaursPath = s.SerializeObject<Path>(SideMinotaursPath, name: "SideMinotaursPath");
			SideDevilBobPath = s.SerializeObject<Path>(SideDevilBobPath, name: "SideDevilBobPath");
			SideSwordmanPath = s.SerializeObject<Path>(SideSwordmanPath, name: "SideSwordmanPath");
			SideGreenToadOffset = s.SerializeObject<Vec2d>(SideGreenToadOffset, name: "SideGreenToadOffset");
			SideSplinterToadOffset = s.SerializeObject<Vec2d>(SideSplinterToadOffset, name: "SideSplinterToadOffset");
			SideMinotaursOffset = s.SerializeObject<Vec2d>(SideMinotaursOffset, name: "SideMinotaursOffset");
			SideDevilBobOffset = s.SerializeObject<Vec2d>(SideDevilBobOffset, name: "SideDevilBobOffset");
			SideSwordmanOffset = s.SerializeObject<Vec2d>(SideSwordmanOffset, name: "SideSwordmanOffset");
			CountryAtlasList = s.SerializeObject<CMap<string, uint>>(CountryAtlasList, name: "CountryAtlasList");
			regionBackgrounds = s.SerializeObject<CMap<RLC_GraphicalFamily, RegionPathList>>(regionBackgrounds, name: "regionBackgrounds");
			eventBackgrounds = s.SerializeObject<CMap<uint, Path>>(eventBackgrounds, name: "eventBackgrounds");
			shareConfigScreenShotType = s.SerializeObject<CMap<RLC_SocialManager.eScreenShotType, RO2_GameConfigExtended_Template.ShareConfig>>(shareConfigScreenShotType, name: "shareConfigScreenShotType");
			shareConfigFamilyShowcase = s.SerializeObject<CMap<uint, RO2_GameConfigExtended_Template.ShareConfig>>(shareConfigFamilyShowcase, name: "shareConfigFamilyShowcase");
			shareConfigCostumeShowcase = s.SerializeObject<CMap<StringID, RO2_GameConfigExtended_Template.ShareConfig>>(shareConfigCostumeShowcase, name: "shareConfigCostumeShowcase");
		}
		public enum RLC_GraphicalFamily {
			[Serialize("RLC_GraphicalFamily_Unknown"      )] Unknown = 0,
			[Serialize("RLC_GraphicalFamily_Shaolin"      )] Shaolin = 1,
			[Serialize("RLC_GraphicalFamily_Medieval"     )] Medieval = 2,
			[Serialize("RLC_GraphicalFamily_ToadStory"    )] ToadStory = 3,
			[Serialize("RLC_GraphicalFamily_Desert"       )] Desert = 4,
			[Serialize("RLC_GraphicalFamily_UnderWater"   )] UnderWater = 5,
			[Serialize("RLC_GraphicalFamily_Greece"       )] Greece = 6,
			[Serialize("RLC_GraphicalFamily_LandOfTheDead")] LandOfTheDead = 7,
			[Serialize("RLC_GraphicalFamily_Intro"        )] Intro = 8,
			[Serialize("RLC_GraphicalFamily_Count"        )] Count = 9,
		}
		public override uint? ClassCRC => 0x1D0C1207;

		[Games(GameFlags.RA)]
		public partial class ShareConfig : CSerializable {
			public CMap<online.SNSType, string> snsUrl;
			public string url;
			public string anim;
			public Path preview;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				snsUrl = s.SerializeObject<CMap<online.SNSType, string>>(snsUrl, name: "snsUrl");
				url = s.Serialize<string>(url, name: "url");
				anim = s.Serialize<string>(anim, name: "anim");
				preview = s.SerializeObject<Path>(preview, name: "preview");
			}

		}
	}
}

