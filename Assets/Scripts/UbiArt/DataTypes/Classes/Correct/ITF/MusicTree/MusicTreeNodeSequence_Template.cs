namespace UbiArt.ITF {
	[Games(GameFlags.RO | GameFlags.RLVersion)]
	public partial class MusicTreeNodeSequence_Template : MusicTreeNode_Template {
		public uint startingLeaf;
		public bool looping;
		public bool useIntro;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.COL) {
				startingLeaf = s.Serialize<uint>(startingLeaf, name: "startingLeaf");
				looping = s.Serialize<bool>(looping, name: "looping", options: CSerializerObject.Options.BoolAsByte);
				useIntro = s.Serialize<bool>(useIntro, name: "useIntro", options: CSerializerObject.Options.BoolAsByte);
			} else if (s.Settings.Game == Game.RL) {
				startingLeaf = s.Serialize<uint>(startingLeaf, name: "startingLeaf");
				looping = s.Serialize<bool>(looping, name: "looping");
				useIntro = s.Serialize<bool>(useIntro, name: "useIntro");
				pauseInsensitiveFlags = s.Serialize<uint>(pauseInsensitiveFlags, name: "pauseInsensitiveFlags");
			} else {
				startingLeaf = s.Serialize<uint>(startingLeaf, name: "startingLeaf");
				looping = s.Serialize<bool>(looping, name: "looping");
				useIntro = s.Serialize<bool>(useIntro, name: "useIntro");
			}
		}
		public override uint? ClassCRC => 0xA7DEF63F;
	}
}

