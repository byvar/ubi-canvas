using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class Unknown_COL_28_sub_959060 : CSerializable {
		public SoundGUID Trigger;
		public float Repeat;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			Trigger = s.SerializeObject<SoundGUID>(Trigger, name: "Trigger");
			Repeat = s.Serialize<float>(Repeat, name: "Repeat");
		}
		public override uint? ClassCRC => 0xA80678AD;
	}
}

