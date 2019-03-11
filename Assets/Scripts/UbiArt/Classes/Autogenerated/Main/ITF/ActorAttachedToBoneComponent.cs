using UnityEngine;

namespace UbiArt.ITF {
	public partial class ActorAttachedToBoneComponent : ActorComponent {
		[Serialize("boneName"    )] public StringID boneName;
		[Serialize("posOffset"   )] public Vector2 posOffset;
		[Serialize("useBoneScale")] public bool useBoneScale;
		[Serialize("useBoneAngle")] public bool useBoneAngle;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(boneName));
			SerializeField(s, nameof(posOffset));
			SerializeField(s, nameof(useBoneScale));
			SerializeField(s, nameof(useBoneAngle));
		}
		public override uint? ClassCRC => 0x72CD9667;
	}
}

