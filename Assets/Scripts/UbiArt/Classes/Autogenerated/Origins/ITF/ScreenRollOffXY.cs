using UnityEngine;

namespace UbiArt.ITF {
	public partial class ScreenRollOffXY : CSerializable {
		[Serialize("distanceMinX" )] public float distanceMinX;
		[Serialize("distanceMaxX" )] public float distanceMaxX;
		[Serialize("distanceMinY" )] public float distanceMinY;
		[Serialize("distanceMaxY" )] public float distanceMaxY;
		[Serialize("useX"         )] public bool useX;
		[Serialize("useY"         )] public bool useY;
		[Serialize("useMetricUnit")] public bool useMetricUnit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL) {
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

