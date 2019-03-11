using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_ShooterSpawnerModifierComponent : TimedSpawnerModifierComponent {
		[Serialize("tweenId")] public Enum_tweenId tweenId;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(tweenId));
		}
		public enum Enum_tweenId {
			[Serialize("invalid")] invalid = -1,
		}
		public override uint? ClassCRC => 0xBA1FFC13;
	}
}

