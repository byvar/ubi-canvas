using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EnduranceBrickComponent : ActorComponent {
		[Serialize("canFlip")] public bool canFlip;
		[Serialize("size"   )] public Vec2d size;
		[Serialize("inPos"  )] public Vec2d inPos;
		[Serialize("inSide" )] public BrickSide inSide;
		[Serialize("outPos" )] public Vec2d outPos;
		[Serialize("outSide")] public BrickSide outSide;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(canFlip), boolAsByte: true);
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
		public override uint? ClassCRC => 0x6C2D8B0D;
	}
}

