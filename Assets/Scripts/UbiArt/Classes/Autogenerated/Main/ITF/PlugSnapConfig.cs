using UnityEngine;

namespace UbiArt.ITF {
	public partial class PlugSnapConfig : CSerializable {
		[Serialize("duration"          )] public float duration;
		[Serialize("boneName"          )] public StringID boneName;
		[Serialize("boneDefaultFlipped")] public bool boneDefaultFlipped;
		[Serialize("depthOffset"       )] public float depthOffset;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(duration));
			SerializeField(s, nameof(boneName));
			SerializeField(s, nameof(boneDefaultFlipped));
			SerializeField(s, nameof(depthOffset));
		}
	}
}

