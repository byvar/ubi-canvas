using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_25_sub_958920 : CSerializable {
		[Serialize("RTPC"            )] public SoundGUID RTPC;
		[Serialize("stopOnDeactivate")] public bool stopOnDeactivate;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(RTPC));
			SerializeField(s, nameof(stopOnDeactivate), boolAsByte: true);
		}
		public override uint? ClassCRC => 0xCC0BBF1B;
	}
}

