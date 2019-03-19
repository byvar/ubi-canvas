using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_MissionStepTutorial_Template : CSerializable {
		[Serialize("id")] public StringID id;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(id));
		}
		public override uint? ClassCRC => 0x906BFDDE;
	}
}

