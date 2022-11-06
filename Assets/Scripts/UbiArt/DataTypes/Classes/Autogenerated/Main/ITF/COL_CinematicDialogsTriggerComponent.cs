using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CinematicDialogsTriggerComponent : CSerializable {
		public Placeholder dialogData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			dialogData = s.SerializeObject<Placeholder>(dialogData, name: "dialogData");
		}
		public override uint? ClassCRC => 0x475B791D;
	}
}

