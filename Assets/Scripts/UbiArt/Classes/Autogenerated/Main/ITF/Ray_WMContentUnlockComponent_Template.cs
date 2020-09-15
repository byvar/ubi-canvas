using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class Ray_WMContentUnlockComponent_Template : CSerializable {
		public LocalisationId fairyLocId;
		public LocalisationId chestLocId;
		public LocalisationId costumeLocId;
		public LocalisationId deadLandLocId;
		public LocalisationId bossJungleLocId;
		public LocalisationId bossMusicLocId;
		public LocalisationId bossFoodLocId;
		public LocalisationId bossOceanLocId;
		public Vec2d animSize;
		public Path iconPath;
		public StringID iconPoint;
		public Vec2d iconAnimSize;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			fairyLocId = s.SerializeObject<LocalisationId>(fairyLocId, name: "fairyLocId");
			chestLocId = s.SerializeObject<LocalisationId>(chestLocId, name: "chestLocId");
			costumeLocId = s.SerializeObject<LocalisationId>(costumeLocId, name: "costumeLocId");
			deadLandLocId = s.SerializeObject<LocalisationId>(deadLandLocId, name: "deadLandLocId");
			bossJungleLocId = s.SerializeObject<LocalisationId>(bossJungleLocId, name: "bossJungleLocId");
			bossMusicLocId = s.SerializeObject<LocalisationId>(bossMusicLocId, name: "bossMusicLocId");
			bossFoodLocId = s.SerializeObject<LocalisationId>(bossFoodLocId, name: "bossFoodLocId");
			bossOceanLocId = s.SerializeObject<LocalisationId>(bossOceanLocId, name: "bossOceanLocId");
			animSize = s.SerializeObject<Vec2d>(animSize, name: "animSize");
			iconPath = s.SerializeObject<Path>(iconPath, name: "iconPath");
			iconPoint = s.SerializeObject<StringID>(iconPoint, name: "iconPoint");
			iconAnimSize = s.SerializeObject<Vec2d>(iconAnimSize, name: "iconAnimSize");
		}
		public override uint? ClassCRC => 0x4494AEB3;
	}
}

