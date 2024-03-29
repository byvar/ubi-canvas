namespace UbiArt.ITF {
	[Games(GameFlags.RJR | GameFlags.RFR | GameFlags.VH | GameFlags.RA)]
	public partial class ParPhase : CSerializable {
		public float phaseTime = 1f;
		public Color colorMin = Color.White;
		public Color colorMax = Color.White;
		public Vec2d sizeMin = Vec2d.One;
		public Vec2d sizeMax = Vec2d.One;
		public int animstart = -1;
		public int animend = -1;
		public StringID animname;
		public float deltaphasetime;
		public bool animstretchtime;
		public bool blendtonextphase = true;

		[Description("A 2D vector specifying the (min, max) range of alpha that will get remapped to (0, 1). Negative values and values > 1 are allowed.")]
		public Vec2d remapAlpha = new Vec2d(0,1);

		public uint Vita_00 { get; set; }

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (s.Settings.Game == Game.RJR || s.Settings.Game == Game.RFR || s.Settings.Game == Game.RO) {
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
			} else if(s.Settings.Game == Game.COL) {
				phaseTime = s.Serialize<float>(phaseTime, name: "phaseTime");
				colorMin = s.SerializeObject<Color>(colorMin, name: "colorMin");
				colorMax = s.SerializeObject<Color>(colorMax, name: "colorMax");
				sizeMin = s.SerializeObject<Vec2d>(sizeMin, name: "sizeMin");
				sizeMax = s.SerializeObject<Vec2d>(sizeMax, name: "sizeMax");
				remapAlpha = s.SerializeObject<Vec2d>(remapAlpha, name: "remapAlpha");
				animstart = s.Serialize<int>(animstart, name: "animstart");
				animend = s.Serialize<int>(animend, name: "animend");
				animname = s.SerializeObject<StringID>(animname, name: "animname");
				deltaphasetime = s.Serialize<float>(deltaphasetime, name: "deltaphasetime");
				animstretchtime = s.Serialize<bool>(animstretchtime, name: "animstretchtime", options: CSerializerObject.Options.BoolAsByte);
				blendtonextphase = s.Serialize<bool>(blendtonextphase, name: "blendtonextphase", options: CSerializerObject.Options.BoolAsByte);
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
				if (s.Settings.Platform == GamePlatform.Vita) {
					animstretchtime = s.Serialize<int>(animstretchtime ? 1 : 0, name: "animstretchtime") != 0;
					blendtonextphase = s.Serialize<bool>(blendtonextphase, name: "blendtonextphase");
				} else {
					animstretchtime = s.Serialize<bool>(animstretchtime, name: "animstretchtime");
					blendtonextphase = s.Serialize<bool>(blendtonextphase, name: "blendtonextphase");
				}
			}
		}
	}
}

