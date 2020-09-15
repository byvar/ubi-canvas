using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_EnduranceBrick_Template : RO2_Brick_Template {
		[Serialize("inTags" )] public CList<StringID> inTags;
		[Serialize("outTags")] public CList<StringID> outTags;
		[Serialize("canFlip")] public bool canFlip;
		[Serialize("size"   )] public Vec2d size;
		[Serialize("inPos"  )] public Vec2d inPos;
		[Serialize("inSide" )] public BrickSide inSide;
		[Serialize("outPos" )] public Vec2d outPos;
		[Serialize("outSide")] public BrickSide outSide;
		[Serialize("length" )] public float length;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inTags));
			SerializeField(s, nameof(outTags));
			if (s.HasFlags(SerializeFlags.Flags10)) {
				SerializeField(s, nameof(canFlip));
				SerializeField(s, nameof(size));
				SerializeField(s, nameof(inPos));
				SerializeField(s, nameof(inSide));
				SerializeField(s, nameof(outPos));
				SerializeField(s, nameof(outSide));
				SerializeField(s, nameof(length));
			}
		}
		public enum BrickSide {
			[Serialize("BrickSide_Up"   )] Up = 0,
			[Serialize("BrickSide_Down" )] Down = 1,
			[Serialize("BrickSide_Left" )] Left = 2,
			[Serialize("BrickSide_Right")] Right = 3,
		}
		public override uint? ClassCRC => 0x3944AD3E;
	}
}

