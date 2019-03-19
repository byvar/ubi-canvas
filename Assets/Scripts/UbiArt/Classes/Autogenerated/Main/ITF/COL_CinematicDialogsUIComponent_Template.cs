using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.COL)]
	public partial class COL_CinematicDialogsUIComponent_Template : CSerializable {
		[Serialize("characterID")] public StringID characterID;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(characterID));
		}
		public override uint? ClassCRC => 0xA2104A74;
	}
}

