using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RO | GameFlags.RL | GameFlags.COL)]
	public partial class ScreenRollOffXY : CSerializable {
		[Serialize("distanceMinX" )] public float distanceMinX;
		[Serialize("distanceMaxX" )] public float distanceMaxX;
		[Serialize("distanceMinY" )] public float distanceMinY;
		[Serialize("distanceMaxY" )] public float distanceMaxY;
		[Serialize("useX"         )] public int useX;
		[Serialize("useY"         )] public int useY;
		[Serialize("useMetricUnit")] public int useMetricUnit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				SerializeField(s, nameof(distanceMinX));
				SerializeField(s, nameof(distanceMaxX));
				SerializeField(s, nameof(distanceMinY));
				SerializeField(s, nameof(distanceMaxY));
				SerializeField(s, nameof(useX));
				SerializeField(s, nameof(useY));
				SerializeField(s, nameof(useMetricUnit));
			} else {
				SerializeField(s, nameof(distanceMinX));
				SerializeField(s, nameof(distanceMaxX));
				SerializeField(s, nameof(distanceMinY));
				SerializeField(s, nameof(distanceMaxY));
				SerializeField(s, nameof(useX));
				SerializeField(s, nameof(useY));
			}
		}
		public override uint? ClassCRC => 0x6C8F3C79;
	}
}

