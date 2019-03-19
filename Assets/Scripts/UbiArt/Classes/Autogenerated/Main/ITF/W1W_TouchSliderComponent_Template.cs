using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_TouchSliderComponent_Template : ActorComponent_Template {
		[Serialize("float__0")] public float float__0;
		[Serialize("bool__1" )] public bool bool__1;
		[Serialize("bool__2" )] public bool bool__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(bool__1));
			SerializeField(s, nameof(bool__2));
		}
		public override uint? ClassCRC => 0x72D0BC93;
	}
}

