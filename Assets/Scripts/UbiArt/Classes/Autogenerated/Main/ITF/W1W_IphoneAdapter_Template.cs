using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_IphoneAdapter_Template : ActorComponent_Template {
		[Serialize("Vector3__0" )] public Vector3 Vector3__0;
		[Serialize("StringID__1")] public StringID StringID__1;
		[Serialize("bool__2"    )] public bool bool__2;
		[Serialize("bool__3"    )] public bool bool__3;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Vector3__0));
			SerializeField(s, nameof(StringID__1));
			SerializeField(s, nameof(bool__2));
			SerializeField(s, nameof(bool__3));
		}
		public override uint? ClassCRC => 0x9B1B76A4;
	}
}

