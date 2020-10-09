using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_EnduranceBrickComponent : ActorComponent {
		public bool canFlip;
		public Vec2d size;
		public Vec2d inPos;
		public BrickSide inSide;
		public Vec2d outPos;
		public BrickSide outSide;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					canFlip = s.Serialize<bool>(canFlip, name: "canFlip", options: CSerializerObject.Options.BoolAsByte);
					size = s.SerializeObject<Vec2d>(size, name: "size");
					inPos = s.SerializeObject<Vec2d>(inPos, name: "inPos");
					inSide = s.Serialize<BrickSide>(inSide, name: "inSide");
					outPos = s.SerializeObject<Vec2d>(outPos, name: "outPos");
					outSide = s.Serialize<BrickSide>(outSide, name: "outSide");
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					canFlip = s.Serialize<bool>(canFlip, name: "canFlip");
					size = s.SerializeObject<Vec2d>(size, name: "size");
					inPos = s.SerializeObject<Vec2d>(inPos, name: "inPos");
					inSide = s.Serialize<BrickSide>(inSide, name: "inSide");
					outPos = s.SerializeObject<Vec2d>(outPos, name: "outPos");
					outSide = s.Serialize<BrickSide>(outSide, name: "outSide");
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

