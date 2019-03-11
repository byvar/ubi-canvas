using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_EnduranceBrickComponent : ActorComponent {
		[Serialize("canFlip")] public bool canFlip;
		[Serialize("size"   )] public Vector2 size;
		[Serialize("inPos"  )] public Vector2 inPos;
		[Serialize("inSide" )] public BrickSide inSide;
		[Serialize("outPos" )] public Vector2 outPos;
		[Serialize("outSide")] public BrickSide outSide;
		[Serialize("inSide" )] public Enum_inSide inSide;
		[Serialize("outSide")] public Enum_outSide outSide;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(canFlip));
					SerializeField(s, nameof(size));
					SerializeField(s, nameof(inPos));
					SerializeField(s, nameof(inSide));
					SerializeField(s, nameof(outPos));
					SerializeField(s, nameof(outSide));
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(canFlip));
					SerializeField(s, nameof(size));
					SerializeField(s, nameof(inPos));
					SerializeField(s, nameof(inSide));
					SerializeField(s, nameof(outPos));
					SerializeField(s, nameof(outSide));
				}
			}
		}
		public enum BrickSide {
			[Serialize("BrickSide_Up"   )] Up = 0,
			[Serialize("BrickSide_Down" )] Down = 1,
			[Serialize("BrickSide_Left" )] Left = 2,
			[Serialize("BrickSide_Right")] Right = 3,
		}
		public enum Enum_inSide {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x6C2D8B0D;
	}
}

