namespace UbiArt.ITF {
	[Games(GameFlags.RL)]
	public partial class RO2_UIMenuLeaderboardGraphComponent : CSerializable {
		public Placeholder canvas;
		public byte NameAlwaysLeft;
		public int NameDisplayedMax;
		public float NameAABBInflateX;
		public float NameAABBInflateY;
		public float AutoRefresh_FirstTimer;
		public float AutoRefresh_Timer;
		public float HistoPoint_scaleY;
		public float HistoBar_offsetY;
		public float HistoBar_scaleX;
		public float HistoBar_scaleY;
		public Color HistoBar_colorEven;
		public Color HistoBar_colorOdd;
		public float LeftMargin;
		public float Graduation_offsetY;
		public float Blink_speed;
		public float Blink_scaleMin;
		public float Blink_scaleMax;
		public Enum_IconType_display_method IconType_display_method;
		public float IconType_display_timer;
		public Vec2d IconEffect_sourcePoint;
		public Vec2d IconEffect_IntermediatePoint;
		public float CostumeIcon_scale;
		public float CostumeIcon_offsetY;
		public Color CostumeIcon_colorInactive;
		public Color CostumeIcon_colorBack;
		public Color CostumeIcon_colorFront;
		public float CountryIcon_scale;
		public float CountryIcon_offsetY;
		public Color CountryIcon_colorInactive;
		public Color CountryIcon_colorBack;
		public Color CountryIcon_colorFront;
		public float LevelIcon_scale;
		public float LevelIcon_offsetY;
		public Color LevelIcon_colorInactive;
		public Color LevelIcon_colorBack;
		public Color LevelIcon_colorFront;
		public float MedalIcon_scale;
		public float MedalIcon_offsetY;
		public Color MedalIcon_colorInactive;
		public Color MedalIcon_colorBack;
		public Color MedalIcon_colorFront;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			canvas = s.SerializeObject<Placeholder>(canvas, name: "canvas");
			NameAlwaysLeft = s.Serialize<byte>(NameAlwaysLeft, name: "NameAlwaysLeft");
			NameDisplayedMax = s.Serialize<int>(NameDisplayedMax, name: "NameDisplayedMax");
			NameAABBInflateX = s.Serialize<float>(NameAABBInflateX, name: "NameAABBInflateX");
			NameAABBInflateY = s.Serialize<float>(NameAABBInflateY, name: "NameAABBInflateY");
			AutoRefresh_FirstTimer = s.Serialize<float>(AutoRefresh_FirstTimer, name: "AutoRefresh_FirstTimer");
			AutoRefresh_Timer = s.Serialize<float>(AutoRefresh_Timer, name: "AutoRefresh_Timer");
			HistoPoint_scaleY = s.Serialize<float>(HistoPoint_scaleY, name: "HistoPoint_scaleY");
			HistoBar_offsetY = s.Serialize<float>(HistoBar_offsetY, name: "HistoBar_offsetY");
			HistoBar_scaleX = s.Serialize<float>(HistoBar_scaleX, name: "HistoBar_scaleX");
			HistoBar_scaleY = s.Serialize<float>(HistoBar_scaleY, name: "HistoBar_scaleY");
			HistoBar_colorEven = s.SerializeObject<Color>(HistoBar_colorEven, name: "HistoBar_colorEven");
			HistoBar_colorOdd = s.SerializeObject<Color>(HistoBar_colorOdd, name: "HistoBar_colorOdd");
			LeftMargin = s.Serialize<float>(LeftMargin, name: "LeftMargin");
			Graduation_offsetY = s.Serialize<float>(Graduation_offsetY, name: "Graduation_offsetY");
			Blink_speed = s.Serialize<float>(Blink_speed, name: "Blink_speed");
			Blink_scaleMin = s.Serialize<float>(Blink_scaleMin, name: "Blink_scaleMin");
			Blink_scaleMax = s.Serialize<float>(Blink_scaleMax, name: "Blink_scaleMax");
			IconType_display_method = s.Serialize<Enum_IconType_display_method>(IconType_display_method, name: "IconType_display_method");
			IconType_display_timer = s.Serialize<float>(IconType_display_timer, name: "IconType_display_timer");
			IconEffect_sourcePoint = s.SerializeObject<Vec2d>(IconEffect_sourcePoint, name: "IconEffect_sourcePoint");
			IconEffect_IntermediatePoint = s.SerializeObject<Vec2d>(IconEffect_IntermediatePoint, name: "IconEffect_IntermediatePoint");
			CostumeIcon_scale = s.Serialize<float>(CostumeIcon_scale, name: "CostumeIcon_scale");
			CostumeIcon_offsetY = s.Serialize<float>(CostumeIcon_offsetY, name: "CostumeIcon_offsetY");
			CostumeIcon_colorInactive = s.SerializeObject<Color>(CostumeIcon_colorInactive, name: "CostumeIcon_colorInactive");
			CostumeIcon_colorBack = s.SerializeObject<Color>(CostumeIcon_colorBack, name: "CostumeIcon_colorBack");
			CostumeIcon_colorFront = s.SerializeObject<Color>(CostumeIcon_colorFront, name: "CostumeIcon_colorFront");
			CountryIcon_scale = s.Serialize<float>(CountryIcon_scale, name: "CountryIcon_scale");
			CountryIcon_offsetY = s.Serialize<float>(CountryIcon_offsetY, name: "CountryIcon_offsetY");
			CountryIcon_colorInactive = s.SerializeObject<Color>(CountryIcon_colorInactive, name: "CountryIcon_colorInactive");
			CountryIcon_colorBack = s.SerializeObject<Color>(CountryIcon_colorBack, name: "CountryIcon_colorBack");
			CountryIcon_colorFront = s.SerializeObject<Color>(CountryIcon_colorFront, name: "CountryIcon_colorFront");
			LevelIcon_scale = s.Serialize<float>(LevelIcon_scale, name: "LevelIcon_scale");
			LevelIcon_offsetY = s.Serialize<float>(LevelIcon_offsetY, name: "LevelIcon_offsetY");
			LevelIcon_colorInactive = s.SerializeObject<Color>(LevelIcon_colorInactive, name: "LevelIcon_colorInactive");
			LevelIcon_colorBack = s.SerializeObject<Color>(LevelIcon_colorBack, name: "LevelIcon_colorBack");
			LevelIcon_colorFront = s.SerializeObject<Color>(LevelIcon_colorFront, name: "LevelIcon_colorFront");
			MedalIcon_scale = s.Serialize<float>(MedalIcon_scale, name: "MedalIcon_scale");
			MedalIcon_offsetY = s.Serialize<float>(MedalIcon_offsetY, name: "MedalIcon_offsetY");
			MedalIcon_colorInactive = s.SerializeObject<Color>(MedalIcon_colorInactive, name: "MedalIcon_colorInactive");
			MedalIcon_colorBack = s.SerializeObject<Color>(MedalIcon_colorBack, name: "MedalIcon_colorBack");
			MedalIcon_colorFront = s.SerializeObject<Color>(MedalIcon_colorFront, name: "MedalIcon_colorFront");
		}
		public enum Enum_IconType_display_method {
			[Serialize("Value_0")] Value_0 = 0,
			[Serialize("Value_1")] Value_1 = 1,
			[Serialize("Value_2")] Value_2 = 2,
			[Serialize("Value_3")] Value_3 = 3,
		}
		public override uint? ClassCRC => 0x05732222;
	}
}

