using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.VH | GameFlags.RL)]
	public partial class BounceStim : EventStim {
		[Serialize("bounceType"     )] public BOUNCETYPE bounceType;
		[Serialize("direction"      )] public Vec2d direction;
		[Serialize("radial"         )] public bool radial;
		[Serialize("multiplier"     )] public float multiplier;
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
		public override uint? ClassCRC => 0x30DD3B8D;
	}
}

