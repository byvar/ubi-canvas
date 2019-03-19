using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class W1W_CreditsComponent : CreditsComponent {
		[Serialize("float__0")] public float float__0;
		[Serialize("float__1")] public float float__1;
		[Serialize("float__2")] public float float__2;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(float__1));
			SerializeField(s, nameof(float__2));
		}
		public override uint? ClassCRC => 0xE8B8591B;
	}
}

