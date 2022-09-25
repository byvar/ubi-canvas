using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_alTranquiloAiComponent : AIComponent {
		public float bubbleLifetime;
		public bool useTuto;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				if (s.HasFlags(SerializeFlags.Default)) {
					bubbleLifetime = s.Serialize<float>(bubbleLifetime, name: "bubbleLifetime");
					useTuto = s.Serialize<bool>(useTuto, name: "useTuto", options: CSerializerObject.Options.BoolAsByte);
				}
			} else {
				if (s.HasFlags(SerializeFlags.Default)) {
					bubbleLifetime = s.Serialize<float>(bubbleLifetime, name: "bubbleLifetime");
					useTuto = s.Serialize<bool>(useTuto, name: "useTuto");
				}
			}
		}
		public override uint? ClassCRC => 0x949607D4;
	}
}

