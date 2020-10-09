using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.RLVersion | GameFlags.VH | GameFlags.RA)]
	public partial class BaseCurveParams : CSerializable {
		public float xofs;
		public float yofs;
		public float xScale;
		public float yScale;
		public float xMin;
		public float xMax;
		public float yMin;
		public float yMax;
		public bool loop;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RL || Settings.s.game == Settings.Game.COL) {
			} else {
				xofs = s.Serialize<float>(xofs, name: "xofs");
				yofs = s.Serialize<float>(yofs, name: "yofs");
				xScale = s.Serialize<float>(xScale, name: "xScale");
				yScale = s.Serialize<float>(yScale, name: "yScale");
				xMin = s.Serialize<float>(xMin, name: "xMin");
				xMax = s.Serialize<float>(xMax, name: "xMax");
				yMin = s.Serialize<float>(yMin, name: "yMin");
				yMax = s.Serialize<float>(yMax, name: "yMax");
				loop = s.Serialize<bool>(loop, name: "loop");
			}
		}
		public override uint? ClassCRC => 0x9E41C323;
	}
}

