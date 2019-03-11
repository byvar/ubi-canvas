using UnityEngine;

namespace UbiArt.ITF {
	public partial class BoneMapping : CSerializable {
		[Serialize("inputBone" )] public StringID inputBone;
		[Serialize("outputBone")] public StringID outputBone;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(inputBone));
			SerializeField(s, nameof(outputBone));
		}
	}
}

