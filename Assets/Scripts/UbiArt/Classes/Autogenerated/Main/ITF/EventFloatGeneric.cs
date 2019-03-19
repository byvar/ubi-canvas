using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA)]
	public partial class EventFloatGeneric : EventGeneric {
		[Serialize("Float")] public float Float;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Float));
		}
		public override uint? ClassCRC => 0x00A70CCE;
	}
}

