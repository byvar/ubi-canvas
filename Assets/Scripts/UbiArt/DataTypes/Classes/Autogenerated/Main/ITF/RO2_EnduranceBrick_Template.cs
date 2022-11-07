namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA | GameFlags.RM)]
	public partial class RO2_EnduranceBrick_Template : RO2_Brick_Template {
		public CListO<StringID> inTags;
		public CListO<StringID> outTags;
		public bool canFlip;
		public Vec2d size;
		public Vec2d inPos;
		public BrickSide inSide;
		public Vec2d outPos;
		public BrickSide outSide;
		public float length;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			inTags = s.SerializeObject<CListO<StringID>>(inTags, name: "inTags");
			outTags = s.SerializeObject<CListO<StringID>>(outTags, name: "outTags");
			if (s.HasFlags(SerializeFlags.Flags10)) {
				canFlip = s.Serialize<bool>(canFlip, name: "canFlip");
				size = s.SerializeObject<Vec2d>(size, name: "size");
				inPos = s.SerializeObject<Vec2d>(inPos, name: "inPos");
				inSide = s.Serialize<BrickSide>(inSide, name: "inSide");
				outPos = s.SerializeObject<Vec2d>(outPos, name: "outPos");
				outSide = s.Serialize<BrickSide>(outSide, name: "outSide");
				length = s.Serialize<float>(length, name: "length");
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

