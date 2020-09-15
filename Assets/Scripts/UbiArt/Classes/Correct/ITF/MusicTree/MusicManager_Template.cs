using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class MusicManager_Template : CSerializable {
		public MusicPartSet_Template musicPartSet;
		public MusicTree_Template musicTree;
		public CArray<InputDesc> inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			musicPartSet = s.SerializeObject<MusicPartSet_Template>(musicPartSet, name: "musicPartSet");
			musicTree = s.SerializeObject<MusicTree_Template>(musicTree, name: "musicTree");
			inputs = s.SerializeObject<CArray<InputDesc>>(inputs, name: "inputs");
		}
		public override uint? ClassCRC => 0x7B4F583E;
	}
}

