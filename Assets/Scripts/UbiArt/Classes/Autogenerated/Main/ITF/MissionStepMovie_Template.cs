using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class MissionStepMovie_Template : CSerializable {
		[Serialize("id")] public Placeholder id;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
		}
		public override uint? ClassCRC => 0x63D4CEB7;
	}
}

