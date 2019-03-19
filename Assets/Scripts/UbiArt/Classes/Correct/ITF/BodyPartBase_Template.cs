using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RFR | GameFlags.RO)]
	public partial class BodyPartBase_Template : CSerializable {
		[Serialize("float__0")] public float float__0;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if(Settings.s.game == Settings.Game.RFR) {
				SerializeField(s, nameof(float__0));
			}
		}
		public override uint? ClassCRC => 0x8FD535C3;
	}
}

