using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CinematicDialogsTriggerComponent : CSerializable {
		[Serialize("dialogData")] public Placeholder dialogData;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(dialogData));
		}
		public override uint? ClassCRC => 0x8D9A36A7;
	}
}

