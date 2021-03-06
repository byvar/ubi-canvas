using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.ROVersion | GameFlags.RLVersion)]
	public partial class ScreenRollOffXY : SoundModifier {
		public float distanceMinX;
		public float distanceMaxX;
		public float distanceMinY;
		public float distanceMaxY;
		public bool useX;
		public bool useY;
		public bool useMetricUnit;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
				distanceMinX = s.Serialize<float>(distanceMinX, name: "distanceMinX");
				distanceMaxX = s.Serialize<float>(distanceMaxX, name: "distanceMaxX");
				distanceMinY = s.Serialize<float>(distanceMinY, name: "distanceMinY");
				distanceMaxY = s.Serialize<float>(distanceMaxY, name: "distanceMaxY");
				useX = s.Serialize<bool>(useX, name: "useX");
				useY = s.Serialize<bool>(useY, name: "useY");
				useMetricUnit = s.Serialize<bool>(useMetricUnit, name: "useMetricUnit");
			} else {
				distanceMinX = s.Serialize<float>(distanceMinX, name: "distanceMinX");
				distanceMaxX = s.Serialize<float>(distanceMaxX, name: "distanceMaxX");
				distanceMinY = s.Serialize<float>(distanceMinY, name: "distanceMinY");
				distanceMaxY = s.Serialize<float>(distanceMaxY, name: "distanceMaxY");
				useX = s.Serialize<bool>(useX, name: "useX");
				useY = s.Serialize<bool>(useY, name: "useY");
			}
		}
		public override uint? ClassCRC => 0x6C8F3C79;
	}
}

