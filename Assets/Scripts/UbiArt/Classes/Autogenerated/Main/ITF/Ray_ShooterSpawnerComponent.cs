using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RFR)]
	public partial class Ray_ShooterSpawnerComponent : TimedSpawnerComponent {
		public StringID tweenId;
		public StringID spawnActorId;
		public Vec3d beforeCamRelativeInitialPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Editor)) {
				tweenId = s.SerializeChoiceListObject<StringID>(tweenId, name: "tweenId", empty: "invalid");
				spawnActorId = s.SerializeChoiceListObject<StringID>(spawnActorId, name: "spawnActorId", empty: "invalid");
			} else {
				tweenId = s.SerializeObject<StringID>(tweenId, name: "tweenId");
				spawnActorId = s.SerializeObject<StringID>(spawnActorId, name: "spawnActorId");
			}
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				beforeCamRelativeInitialPos = s.SerializeObject<Vec3d>(beforeCamRelativeInitialPos, name: "beforeCamRelativeInitialPos");
			}
		}
		public override uint? ClassCRC => 0xFFCF1689;
	}
}

