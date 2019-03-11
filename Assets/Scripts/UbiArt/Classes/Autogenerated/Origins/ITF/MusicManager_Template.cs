using UnityEngine;

namespace UbiArt.ITF {
	public partial class MusicManager_Template : CSerializable {
		[Serialize("musicPartSet")] public Placeholder musicPartSet;
		[Serialize("musicTree"   )] public Placeholder musicTree;
		[Serialize("inputs"      )] public Placeholder inputs;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(musicPartSet));
			SerializeField(s, nameof(musicTree));
			SerializeField(s, nameof(inputs));
		}
		public override uint? ClassCRC => 0x7B4F583E;
	}
}

