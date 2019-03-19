using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_28_sub_959060 : CSerializable {
		[Serialize("Trigger")] public SoundGUID Trigger;
		[Serialize("Repeat" )] public float Repeat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(Trigger));
			SerializeField(s, nameof(Repeat));
		}
		public override uint? ClassCRC => 0xA80678AD;
	}
}

