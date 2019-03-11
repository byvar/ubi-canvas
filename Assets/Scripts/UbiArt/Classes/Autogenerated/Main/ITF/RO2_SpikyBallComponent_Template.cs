using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_SpikyBallComponent_Template : ActorComponent_Template {
		[Serialize("bones")] public CList<RO2_SpikyBallComponent_Template.BoneData> bones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bones));
		}
		public partial class BoneData : CSerializable {
			[Serialize("boneName")] public StringID boneName;
			[Serialize("offset"  )] public Vector2 offset;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(boneName));
				SerializeField(s, nameof(offset));
			}
		}
		public override uint? ClassCRC => 0x275E583D;
	}
}

