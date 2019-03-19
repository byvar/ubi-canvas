using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.VH | GameFlags.RL)]
	public partial class BounceStim : EventStim {
		[Serialize("bounceType"     )] public BOUNCETYPE bounceType;
		[Serialize("direction"      )] public Vector2 direction;
		[Serialize("radial"         )] public bool radial;
		[Serialize("multiplier"     )] public float multiplier;
		[Serialize("bounceType"     )] public Enum_bounceType bounceType;
		[Serialize("bounceReactType")] public uint bounceReactType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(bounceType));
				SerializeField(s, nameof(bounceReactType));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(radial));
				SerializeField(s, nameof(multiplier));
			} else {
				SerializeField(s, nameof(bounceType));
				SerializeField(s, nameof(direction));
				SerializeField(s, nameof(radial));
				SerializeField(s, nameof(multiplier));
			}
		}
		public enum BOUNCETYPE {
			[Serialize("BOUNCETYPE_ENEMY"            )] ENEMY = 1,
			[Serialize("BOUNCETYPE_BUMPER"           )] BUMPER = 2,
			[Serialize("BOUNCETYPE_BUMPER_AIRCONTROL")] BUMPER_AIRCONTROL = 8,
			[Serialize("BOUNCETYPE_SETBACKS"         )] SETBACKS = 7,
		}
		public enum Enum_bounceType {
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_8")] Value_8 = 8,
			[Serialize("Value_7")] Value_7 = 7,
		}
		public override uint? ClassCRC => 0x30DD3B8D;
	}
}

