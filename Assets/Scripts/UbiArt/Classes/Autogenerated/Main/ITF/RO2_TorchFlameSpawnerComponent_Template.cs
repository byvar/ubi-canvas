using UnityEngine;

namespace UbiArt.ITF {
	public partial class RO2_TorchFlameSpawnerComponent_Template : ActorComponent_Template {
		[Serialize("torchPath" )] public Path torchPath;
		[Serialize("snapBones" )] public CArray<StringID> snapBones;
		[Serialize("ZOffset"   )] public float ZOffset;
		[Serialize("animOnFlip")] public StringID animOnFlip;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(torchPath));
			SerializeField(s, nameof(snapBones));
			SerializeField(s, nameof(ZOffset));
			SerializeField(s, nameof(animOnFlip));
		}
		public override uint? ClassCRC => 0x98412800;
	}
}

