using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_ProceduralBoneComponent_Template : ProceduralBoneComponent_Template {
		[Serialize("bones")] public CList<RO2_ProceduralBoneComponent_Template.BoneData> bones;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bones));
		}
		[Games(GameFlags.RA)]
		public partial class BoneData : CSerializable {
			[Serialize("boneName")] public StringID boneName;
			[Serialize("offset"  )] public Vec2d offset;
			protected override void SerializeImpl(CSerializerObject s) {
				base.SerializeImpl(s);
				SerializeField(s, nameof(boneName));
				SerializeField(s, nameof(offset));
			}
		}
		public override uint? ClassCRC => 0x9407EFAC;
	}
}

