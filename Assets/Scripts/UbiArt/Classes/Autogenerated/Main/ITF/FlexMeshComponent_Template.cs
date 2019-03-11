using UnityEngine;

namespace UbiArt.ITF {
	public partial class FlexMeshComponent_Template : GraphicComponent_Template {
		[Serialize("flexList"         )] public CList<FlexMeshData> flexList;
		[Serialize("useActorFlip"     )] public bool useActorFlip;
		[Serialize("useComponentAlpha")] public bool useComponentAlpha;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(flexList));
			SerializeField(s, nameof(useActorFlip));
			SerializeField(s, nameof(useComponentAlpha));
		}
		public override uint? ClassCRC => 0x7B3F8DEE;
	}
}

