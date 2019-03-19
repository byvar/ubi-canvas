using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_EventFlare_EffectLightStatus : Event {
		[Serialize("bool__0" )] public bool bool__0;
		[Serialize("float__1")] public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(bool__0));
			SerializeField(s, nameof(float__1));
		}
		public override uint? ClassCRC => 0xD3DDA28D;
	}
}

