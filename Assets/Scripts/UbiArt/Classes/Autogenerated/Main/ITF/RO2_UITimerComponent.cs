using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL)]
	public partial class RO2_UITimerComponent : UIComponent {
		[Serialize("displayIcon"        )] public bool displayIcon;
		[Serialize("inTextIntgration"   )] public SmartLocId inTextIntgration;
		[Serialize("counterType"        )] public CounterType counterType;
		[Serialize("isHudEventSensitive")] public bool isHudEventSensitive;
		[Serialize("counterType"        )] public Enum_counterType counterType;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(displayIcon));
				SerializeField(s, nameof(inTextIntgration));
				SerializeField(s, nameof(counterType));
			} else {
				SerializeField(s, nameof(displayIcon));
				SerializeField(s, nameof(inTextIntgration));
				SerializeField(s, nameof(counterType));
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(isHudEventSensitive));
				}
			}
		}
		public enum CounterType {
			[Serialize("CounterType_None"    )] None = -1,
			[Serialize("CounterType_Time"    )] Time = 0,
			[Serialize("CounterType_Distance")] Distance = 1,
			[Serialize("CounterType_Lum"     )] Lum = 2,
		}
		public enum Enum_counterType {
			[Serialize("Value__1")] Value__1 = -1,
			[Serialize("Value_0" )] Value_0 = 0,
			[Serialize("Value_1" )] Value_1 = 1,
			[Serialize("Value_2" )] Value_2 = 2,
		}
		public override uint? ClassCRC => 0xA845E2F4;
	}
}

