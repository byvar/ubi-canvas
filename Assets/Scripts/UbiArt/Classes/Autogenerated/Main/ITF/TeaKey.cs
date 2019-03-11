using UnityEngine;

namespace UbiArt.ITF {
	public partial class TeaKey : CSerializable {
		[Serialize("Key1")] public uint Key1;
		[Serialize("Key2")] public uint Key2;
		[Serialize("Key3")] public uint Key3;
		[Serialize("Key4")] public uint Key4;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Key1));
			SerializeField(s, nameof(Key2));
			SerializeField(s, nameof(Key3));
			SerializeField(s, nameof(Key4));
		}
	}
}

