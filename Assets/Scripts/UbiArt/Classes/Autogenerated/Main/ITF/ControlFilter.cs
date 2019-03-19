using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.COL | GameFlags.RL)]
	public partial class ControlFilter : CSerializable {
		[Serialize("input")] public ProceduralInputData input;
		[Serialize("input")] public Placeholder input;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(input));
			} else {
				SerializeField(s, nameof(input));
			}
		}
		public override uint? ClassCRC => 0x70CBD0F6;
	}
}

