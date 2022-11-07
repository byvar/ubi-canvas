namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class BTDeciderHasPlayerBehind_Template : BTDecider_Template {
		public float radius;
		public float margin;
		public bool invert;
		public bool checkAll;
		public StringID factDir;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			radius = s.Serialize<float>(radius, name: "radius");
			margin = s.Serialize<float>(margin, name: "margin");
			invert = s.Serialize<bool>(invert, name: "invert");
			checkAll = s.Serialize<bool>(checkAll, name: "checkAll");
			factDir = s.SerializeObject<StringID>(factDir, name: "factDir");
		}
		public override uint? ClassCRC => 0x8998C34F;
	}
}

