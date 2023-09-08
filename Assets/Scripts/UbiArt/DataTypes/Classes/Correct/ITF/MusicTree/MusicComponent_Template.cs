namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RAVersion)]
	public partial class MusicComponent_Template : ActorComponent_Template {
		public MusicPartSet_Template musicPartSet;
		public MusicTree_Template musicTree;
		public CArrayO<InputDesc> inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RL) {
				musicPartSet = s.SerializeObject<MusicPartSet_Template>(musicPartSet, name: "musicPartSet");
				musicTree = s.SerializeObject<MusicTree_Template>(musicTree, name: "musicTree");
				inputs = s.SerializeObject<CArrayO<InputDesc>>(inputs, name: "inputs");
			} else {
			}
		}
		public override uint? ClassCRC => 0xEE6355D8;
	}
}

