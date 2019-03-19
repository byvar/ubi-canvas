using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionComponent : CSerializable {
		[Serialize("listenToTrigger")] public int listenToTrigger;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(listenToTrigger));
		}
		public override uint? ClassCRC => 0x06308FAF;
	}
}

