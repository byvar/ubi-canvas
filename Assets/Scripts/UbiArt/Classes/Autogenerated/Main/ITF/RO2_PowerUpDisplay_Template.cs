using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_PowerUpDisplay_Template : CSerializable {
		[Serialize("id"       )] public StringID id;
		[Serialize("debugName")] public string debugName;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(id));
			} else {
				SerializeField(s, nameof(id));
				SerializeField(s, nameof(debugName));
			}
		}
		public override uint? ClassCRC => 0x41C1630D;
	}
}

