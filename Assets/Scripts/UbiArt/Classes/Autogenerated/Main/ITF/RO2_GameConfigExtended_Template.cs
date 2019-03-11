using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_GameConfigExtended_Template : GameConfigExtended_Template {
		[Serialize("test"                      )] public uint test;
		[Serialize("PreviewGlobox"             )] public Path PreviewGlobox;
		[Serialize("PreviewTeensy"             )] public Path PreviewTeensy;
		[Serialize("LeaderboardMap"            )] public Path LeaderboardMap;
		[Serialize("LeaderboardPlayerFace"     )] public Path LeaderboardPlayerFace;
		[Serialize("LeaderboardPlayerBubble"   )] public Path LeaderboardPlayerBubble;
		[Serialize("LeaderboardPlayerYou"      )] public Path LeaderboardPlayerYou;
		[Serialize("LeaderboardFlag"           )] public Path LeaderboardFlag;
		[Serialize("LeaderboardGodRay"         )] public Path LeaderboardGodRay;
		[Serialize("LeaderboardPannel"         )] public Path LeaderboardPannel;
		[Serialize("PlayerProfileFlag"         )] public Path PlayerProfileFlag;
		[Serialize("LeaderboardPlayerName"     )] public Path LeaderboardPlayerName;
		[Serialize("SideGreenToadPath"         )] public Path SideGreenToadPath;
		[Serialize("SideSplinterToadPath"      )] public Path SideSplinterToadPath;
		[Serialize("SideMinotaursPath"         )] public Path SideMinotaursPath;
		[Serialize("SideDevilBobPath"          )] public Path SideDevilBobPath;
		[Serialize("SideSwordmanPath"          )] public Path SideSwordmanPath;
		[Serialize("SideGreenToadOffset"       )] public Vector2 SideGreenToadOffset;
		[Serialize("SideSplinterToadOffset"    )] public Vector2 SideSplinterToadOffset;
		[Serialize("SideMinotaursOffset"       )] public Vector2 SideMinotaursOffset;
		[Serialize("SideDevilBobOffset"        )] public Vector2 SideDevilBobOffset;
		[Serialize("SideSwordmanOffset"        )] public Vector2 SideSwordmanOffset;
		[Serialize("CountryAtlasList"          )] public CMap<string, uint> CountryAtlasList;
		[Serialize("regionBackgrounds"         )] public CMap<RLC_GraphicalFamily, RegionPathList> regionBackgrounds;
		[Serialize("eventBackgrounds"          )] public CMap<uint, Path> eventBackgrounds;
		[Serialize("shareConfigScreenShotType" )] public CMap<RLC_SocialManager.eScreenShotType, RO2_GameConfigExtended_Template.ShareConfig> shareConfigScreenShotType;
		[Serialize("shareConfigFamilyShowcase" )] public CMap<uint, RO2_GameConfigExtended_Template.ShareConfig> shareConfigFamilyShowcase;
		[Serialize("shareConfigCostumeShowcase")] public CMap<StringID, RO2_GameConfigExtended_Template.ShareConfig> shareConfigCostumeShowcase;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(test));
			SerializeField(s, nameof(PreviewGlobox));
			SerializeField(s, nameof(PreviewTeensy));
			SerializeField(s, nameof(LeaderboardMap));
			SerializeField(s, nameof(LeaderboardPlayerFace));
			SerializeField(s, nameof(LeaderboardPlayerBubble));
			SerializeField(s, nameof(LeaderboardPlayerYou));
			SerializeField(s, nameof(LeaderboardFlag));
			SerializeField(s, nameof(LeaderboardGodRay));
			SerializeField(s, nameof(LeaderboardPannel));
			SerializeField(s, nameof(PlayerProfileFlag));
			SerializeField(s, nameof(LeaderboardPlayerName));
			SerializeField(s, nameof(SideGreenToadPath));
			SerializeField(s, nameof(SideSplinterToadPath));
			SerializeField(s, nameof(SideMinotaursPath));
			SerializeField(s, nameof(SideDevilBobPath));
			SerializeField(s, nameof(SideSwordmanPath));
			SerializeField(s, nameof(SideGreenToadOffset));
			SerializeField(s, nameof(SideSplinterToadOffset));
			SerializeField(s, nameof(SideMinotaursOffset));
			SerializeField(s, nameof(SideDevilBobOffset));
			SerializeField(s, nameof(SideSwordmanOffset));
			SerializeField(s, nameof(CountryAtlasList));
			SerializeField(s, nameof(regionBackgrounds));
			SerializeField(s, nameof(eventBackgrounds));
			SerializeField(s, nameof(shareConfigScreenShotType));
			SerializeField(s, nameof(shareConfigFamilyShowcase));
			SerializeField(s, nameof(shareConfigCostumeShowcase));
		}
		public override uint? ClassCRC => 0x1D0C1207;
	}
}

