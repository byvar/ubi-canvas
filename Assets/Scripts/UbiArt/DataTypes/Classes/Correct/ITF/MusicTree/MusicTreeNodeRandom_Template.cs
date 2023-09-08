namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RLVersion)]
	public partial class MusicTreeNodeRandom_Template : MusicTreeNode_Template {
		public bool looping;
		public uint startingLeaf;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				looping = s.Serialize<bool>(looping, name: "looping", options: CSerializerObject.Options.BoolAsByte);
				startingLeaf = s.Serialize<uint>(startingLeaf, name: "startingLeaf");
			} else if (s.Settings.Game == Game.RL) {
				looping = s.Serialize<bool>(looping, name: "looping");
				startingLeaf = s.Serialize<uint>(startingLeaf, name: "startingLeaf");
				pauseInsensitiveFlags = s.Serialize<uint>(pauseInsensitiveFlags, name: "pauseInsensitiveFlags");
			} else {
				looping = s.Serialize<bool>(looping, name: "looping");
				startingLeaf = s.Serialize<uint>(startingLeaf, name: "startingLeaf");
			}
		}
		public override uint? ClassCRC => 0x4A769E62;
	}
}

