using UnityEngine;

namespace UbiArt.ITF {
	public partial class Unknown_157_sub_750020 : CSerializable {
		[Serialize("canvas"                      )] public Placeholder canvas;
		[Serialize("NameAlwaysLeft"              )] public byte NameAlwaysLeft;
		[Serialize("NameDisplayedMax"            )] public bool NameDisplayedMax;
		[Serialize("NameAABBInflateX"            )] public float NameAABBInflateX;
		[Serialize("NameAABBInflateY"            )] public float NameAABBInflateY;
		[Serialize("AutoRefresh_FirstTimer"      )] public float AutoRefresh_FirstTimer;
		[Serialize("AutoRefresh_Timer"           )] public float AutoRefresh_Timer;
		[Serialize("HistoPoint_scaleY"           )] public float HistoPoint_scaleY;
		[Serialize("HistoBar_offsetY"            )] public float HistoBar_offsetY;
		[Serialize("HistoBar_scaleX"             )] public float HistoBar_scaleX;
		[Serialize("HistoBar_scaleY"             )] public float HistoBar_scaleY;
		[Serialize("HistoBar_colorEven"          )] public Color HistoBar_colorEven;
		[Serialize("HistoBar_colorOdd"           )] public Color HistoBar_colorOdd;
		[Serialize("LeftMargin"                  )] public float LeftMargin;
		[Serialize("Graduation_offsetY"          )] public float Graduation_offsetY;
		[Serialize("Blink_speed"                 )] public float Blink_speed;
		[Serialize("Blink_scaleMin"              )] public float Blink_scaleMin;
		[Serialize("Blink_scaleMax"              )] public float Blink_scaleMax;
		[Serialize("IconType_display_method"     )] public Enum_IconType_display_method IconType_display_method;
		[Serialize("IconType_display_timer"      )] public float IconType_display_timer;
		[Serialize("IconEffect_sourcePoint"      )] public Vector2 IconEffect_sourcePoint;
		[Serialize("IconEffect_IntermediatePoint")] public Vector2 IconEffect_IntermediatePoint;
		[Serialize("CostumeIcon_scale"           )] public float CostumeIcon_scale;
		[Serialize("CostumeIcon_offsetY"         )] public float CostumeIcon_offsetY;
		[Serialize("CostumeIcon_colorInactive"   )] public Color CostumeIcon_colorInactive;
		[Serialize("CostumeIcon_colorBack"       )] public Color CostumeIcon_colorBack;
		[Serialize("CostumeIcon_colorFront"      )] public Color CostumeIcon_colorFront;
		[Serialize("CountryIcon_scale"           )] public float CountryIcon_scale;
		[Serialize("CountryIcon_offsetY"         )] public float CountryIcon_offsetY;
		[Serialize("CountryIcon_colorInactive"   )] public Color CountryIcon_colorInactive;
		[Serialize("CountryIcon_colorBack"       )] public Color CountryIcon_colorBack;
		[Serialize("CountryIcon_colorFront"      )] public Color CountryIcon_colorFront;
		[Serialize("LevelIcon_scale"             )] public float LevelIcon_scale;
		[Serialize("LevelIcon_offsetY"           )] public float LevelIcon_offsetY;
		[Serialize("LevelIcon_colorInactive"     )] public Color LevelIcon_colorInactive;
		[Serialize("LevelIcon_colorBack"         )] public Color LevelIcon_colorBack;
		[Serialize("LevelIcon_colorFront"        )] public Color LevelIcon_colorFront;
		[Serialize("MedalIcon_scale"             )] public float MedalIcon_scale;
		[Serialize("MedalIcon_offsetY"           )] public float MedalIcon_offsetY;
		[Serialize("MedalIcon_colorInactive"     )] public Color MedalIcon_colorInactive;
		[Serialize("MedalIcon_colorBack"         )] public Color MedalIcon_colorBack;
		[Serialize("MedalIcon_colorFront"        )] public Color MedalIcon_colorFront;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			SerializeField(s, nameof(canvas));
			SerializeField(s, nameof(NameAlwaysLeft));
			SerializeField(s, nameof(NameDisplayedMax));
			SerializeField(s, nameof(NameAABBInflateX));
			SerializeField(s, nameof(NameAABBInflateY));
			SerializeField(s, nameof(AutoRefresh_FirstTimer));
			SerializeField(s, nameof(AutoRefresh_Timer));
			SerializeField(s, nameof(HistoPoint_scaleY));
			SerializeField(s, nameof(HistoBar_offsetY));
			SerializeField(s, nameof(HistoBar_scaleX));
			SerializeField(s, nameof(HistoBar_scaleY));
			SerializeField(s, nameof(HistoBar_colorEven));
			SerializeField(s, nameof(HistoBar_colorOdd));
			SerializeField(s, nameof(LeftMargin));
			SerializeField(s, nameof(Graduation_offsetY));
			SerializeField(s, nameof(Blink_speed));
			SerializeField(s, nameof(Blink_scaleMin));
			SerializeField(s, nameof(Blink_scaleMax));
			SerializeField(s, nameof(IconType_display_method));
			SerializeField(s, nameof(IconType_display_timer));
			SerializeField(s, nameof(IconEffect_sourcePoint));
			SerializeField(s, nameof(IconEffect_IntermediatePoint));
			SerializeField(s, nameof(CostumeIcon_scale));
			SerializeField(s, nameof(CostumeIcon_offsetY));
			SerializeField(s, nameof(CostumeIcon_colorInactive));
			SerializeField(s, nameof(CostumeIcon_colorBack));
			SerializeField(s, nameof(CostumeIcon_colorFront));
			SerializeField(s, nameof(CountryIcon_scale));
			SerializeField(s, nameof(CountryIcon_offsetY));
			SerializeField(s, nameof(CountryIcon_colorInactive));
			SerializeField(s, nameof(CountryIcon_colorBack));
			SerializeField(s, nameof(CountryIcon_colorFront));
			SerializeField(s, nameof(LevelIcon_scale));
			SerializeField(s, nameof(LevelIcon_offsetY));
			SerializeField(s, nameof(LevelIcon_colorInactive));
			SerializeField(s, nameof(LevelIcon_colorBack));
			SerializeField(s, nameof(LevelIcon_colorFront));
			SerializeField(s, nameof(MedalIcon_scale));
			SerializeField(s, nameof(MedalIcon_offsetY));
			SerializeField(s, nameof(MedalIcon_colorInactive));
			SerializeField(s, nameof(MedalIcon_colorBack));
			SerializeField(s, nameof(MedalIcon_colorFront));
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

