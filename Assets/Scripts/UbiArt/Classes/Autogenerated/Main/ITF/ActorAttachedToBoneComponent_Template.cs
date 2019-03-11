using UnityEngine;

namespace UbiArt.ITF {
	public partial class ActorAttachedToBoneComponent_Template : ActorComponent_Template {
		[Serialize("boneName"    )] public StringID boneName;
		[Serialize("useBoneScale")] public bool useBoneScale;
		[Serialize("useBoneAngle")] public bool useBoneAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(boneName));
			SerializeField(s, nameof(useBoneScale));
			SerializeField(s, nameof(useBoneAngle));
		}
		public override uint? ClassCRC => 0xD24BD29A;
	}
}

