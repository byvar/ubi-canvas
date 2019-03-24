using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class Ray_ShooterSpawnerComponent : TimedSpawnerComponent {
		[Serialize("tweenId"                    )] public StringID tweenId;
		[Serialize("spawnActorId"               )] public StringID spawnActorId;
		[Serialize("beforeCamRelativeInitialPos")] public Vector3 beforeCamRelativeInitialPos;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.HasFlags(SerializeFlags.Editor)) {
				SerializeFieldAsChoiceList(s, nameof(tweenId), "invalid");
				SerializeFieldAsChoiceList(s, nameof(spawnActorId), "invalid");
			} else {
				SerializeField(s, nameof(tweenId));
				SerializeField(s, nameof(spawnActorId));
			}
			if (s.HasFlags(SerializeFlags.Flags_xC0)) {
				SerializeField(s, nameof(beforeCamRelativeInitialPos));
			}
		}
		public override uint? ClassCRC => 0xFFCF1689;
	}
}

