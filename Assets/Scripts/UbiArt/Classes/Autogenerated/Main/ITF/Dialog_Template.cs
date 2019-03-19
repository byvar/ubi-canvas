using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.VH)]
	public partial class Dialog_Template : ActorComponent_Template {
		[Serialize("float__0")] public float float__0;
		[Serialize("float__1")] public float float__1;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(float__0));
			SerializeField(s, nameof(float__1));
		}
		public override uint? ClassCRC => 0xB491AB20;
	}
}

