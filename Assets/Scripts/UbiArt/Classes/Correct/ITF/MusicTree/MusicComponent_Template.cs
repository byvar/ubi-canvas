using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RL)]
	public partial class MusicComponent_Template : ActorComponent_Template {
		public MusicPartSet_Template musicPartSet;
		public MusicTree_Template musicTree;
		public CArray<InputDesc> inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				musicPartSet = s.SerializeObject<MusicPartSet_Template>(musicPartSet, name: "musicPartSet");
				musicTree = s.SerializeObject<MusicTree_Template>(musicTree, name: "musicTree");
				inputs = s.SerializeObject<CArray<InputDesc>>(inputs, name: "inputs");
			} else {
			}
		}
		public override uint? ClassCRC => 0xEE6355D8;
	}
}

