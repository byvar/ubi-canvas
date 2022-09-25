using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RL | GameFlags.RA)]
	public partial class RO2_UITimerComponent : UIComponent {
		public bool displayIcon;
		public SmartLocId inTextIntgration;
		public CounterType counterType;
		public bool isHudEventSensitive;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.game == Settings.Game.RL) {
				displayIcon = s.Serialize<bool>(displayIcon, name: "displayIcon");
				inTextIntgration = s.SerializeObject<SmartLocId>(inTextIntgration, name: "inTextIntgration");
				counterType = s.Serialize<CounterType>(counterType, name: "counterType");
			} else {
				displayIcon = s.Serialize<bool>(displayIcon, name: "displayIcon");
				inTextIntgration = s.SerializeObject<SmartLocId>(inTextIntgration, name: "inTextIntgration");
				counterType = s.Serialize<CounterType>(counterType, name: "counterType");
				if (s.HasFlags(SerializeFlags.Default)) {
					isHudEventSensitive = s.Serialize<bool>(isHudEventSensitive, name: "isHudEventSensitive");
				}
			}
		}
		public enum CounterType {
			[Serialize("CounterType_None"    )] None = -1,
			[Serialize("CounterType_Time"    )] Time = 0,
			[Serialize("CounterType_Distance")] Distance = 1,
			[Serialize("CounterType_Lum"     )] Lum = 2,
		}
		public override uint? ClassCRC => 0xA845E2F4;
	}
}

