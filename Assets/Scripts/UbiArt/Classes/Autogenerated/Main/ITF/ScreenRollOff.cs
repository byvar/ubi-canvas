using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class ScreenRollOff : CSerializable {
		[Serialize("distanceMin"  )] public float distanceMin;
		[Serialize("distanceMax"  )] public float distanceMax;
		[Serialize("useMetricUnit")] public int useMetricUnit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(distanceMin));
				SerializeField(s, nameof(distanceMax));
				SerializeField(s, nameof(useMetricUnit));
			} else {
				SerializeField(s, nameof(distanceMin));
				SerializeField(s, nameof(distanceMax));
			}
		}
		public override uint? ClassCRC => 0x4EDC3030;
	}
}

