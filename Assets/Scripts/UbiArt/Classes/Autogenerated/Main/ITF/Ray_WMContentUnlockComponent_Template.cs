using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WMContentUnlockComponent_Template : CSerializable {
		[Serialize("fairyLocId"     )] public LocalisationId fairyLocId;
		[Serialize("chestLocId"     )] public LocalisationId chestLocId;
		[Serialize("costumeLocId"   )] public LocalisationId costumeLocId;
		[Serialize("deadLandLocId"  )] public LocalisationId deadLandLocId;
		[Serialize("bossJungleLocId")] public LocalisationId bossJungleLocId;
		[Serialize("bossMusicLocId" )] public LocalisationId bossMusicLocId;
		[Serialize("bossFoodLocId"  )] public LocalisationId bossFoodLocId;
		[Serialize("bossOceanLocId" )] public LocalisationId bossOceanLocId;
		[Serialize("animSize"       )] public Vector2 animSize;
		[Serialize("iconPath"       )] public Path iconPath;
		[Serialize("iconPoint"      )] public StringID iconPoint;
		[Serialize("iconAnimSize"   )] public Vector2 iconAnimSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(fairyLocId));
			SerializeField(s, nameof(chestLocId));
			SerializeField(s, nameof(costumeLocId));
			SerializeField(s, nameof(deadLandLocId));
			SerializeField(s, nameof(bossJungleLocId));
			SerializeField(s, nameof(bossMusicLocId));
			SerializeField(s, nameof(bossFoodLocId));
			SerializeField(s, nameof(bossOceanLocId));
			SerializeField(s, nameof(animSize));
			SerializeField(s, nameof(iconPath));
			SerializeField(s, nameof(iconPoint));
			SerializeField(s, nameof(iconAnimSize));
		}
		public override uint? ClassCRC => 0x4494AEB3;
	}
}

