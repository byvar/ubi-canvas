using UnityEngine;

namespace UbiArt.ITF {
	public partial class Ray_SpikyBallComponent_Template : CSerializable {
		[Serialize("circles"    )] public Placeholder circles;
		[Serialize("transitions")] public Placeholder transitions;
		[Serialize("texturePath")] public Path texturePath;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(circles));
			SerializeField(s, nameof(transitions));
			SerializeField(s, nameof(texturePath));
		}
		public override uint? ClassCRC => 0x5600BB01;
	}
}

