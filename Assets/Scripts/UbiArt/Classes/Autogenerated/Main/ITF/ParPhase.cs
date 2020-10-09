using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class ParPhase : CSerializable {
		public float phaseTime;
		public Color colorMin;
		public Color colorMax;
		public Vec2d sizeMin;
		public Vec2d sizeMax;
		public int animstart;
		public int animend;
		public StringID animname;
		public float deltaphasetime;
		public bool animstretchtime;
		public bool blendtonextphase;

		public float float__0;
		public Color Color__1;
		public Color Color__2;
		public Vec2d Vector2__3;
		public Vec2d Vector2__4;
		public int int__5;
		public int int__6;
		public float float__7;
		public int int__8;
		public int int__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				phaseTime = s.Serialize<float>(phaseTime, name: "phaseTime");
				colorMin = s.SerializeObject<Color>(colorMin, name: "colorMin");
				colorMax = s.SerializeObject<Color>(colorMax, name: "colorMax");
				sizeMin = s.SerializeObject<Vec2d>(sizeMin, name: "sizeMin");
				sizeMax = s.SerializeObject<Vec2d>(sizeMax, name: "sizeMax");
				animstart = s.Serialize<int>(animstart, name: "animstart");
				animend = s.Serialize<int>(animend, name: "animend");
				deltaphasetime = s.Serialize<float>(deltaphasetime, name: "deltaphasetime");
				animstretchtime = s.Serialize<bool>(animstretchtime, name: "animstretchtime");
				blendtonextphase = s.Serialize<bool>(blendtonextphase, name: "blendtonextphase");
			} else {
				phaseTime = s.Serialize<float>(phaseTime, name: "phaseTime");
				colorMin = s.SerializeObject<Color>(colorMin, name: "colorMin");
				colorMax = s.SerializeObject<Color>(colorMax, name: "colorMax");
				sizeMin = s.SerializeObject<Vec2d>(sizeMin, name: "sizeMin");
				sizeMax = s.SerializeObject<Vec2d>(sizeMax, name: "sizeMax");
				animstart = s.Serialize<int>(animstart, name: "animstart");
				animend = s.Serialize<int>(animend, name: "animend");
				animname = s.SerializeObject<StringID>(animname, name: "animname");
				deltaphasetime = s.Serialize<float>(deltaphasetime, name: "deltaphasetime");
				animstretchtime = s.Serialize<bool>(animstretchtime, name: "animstretchtime");
				blendtonextphase = s.Serialize<bool>(blendtonextphase, name: "blendtonextphase");
			}
		}
	}
}

