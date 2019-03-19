using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RO)]
	public partial class MusicManager_Template : CSerializable {
		[Serialize("musicPartSet")] public MusicPartSet_Template musicPartSet;
		[Serialize("musicTree"   )] public MusicTree_Template musicTree;
		[Serialize("inputs"      )] public CArray<InputDesc> inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(musicPartSet));
			SerializeField(s, nameof(musicTree));
			SerializeField(s, nameof(inputs));
		}
		public override uint? ClassCRC => 0x7B4F583E;
	}
}

