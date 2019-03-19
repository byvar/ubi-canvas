using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR)]
	public partial class SectoTriggerComponent : ActorComponent {
		[Serialize("uint__0")] public uint uint__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(uint__0));
		}
		public override uint? ClassCRC => 0x6231C40B;
	}
}

