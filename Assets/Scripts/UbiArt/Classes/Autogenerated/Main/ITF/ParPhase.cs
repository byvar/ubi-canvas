using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.VH | GameFlags.RJR | GameFlags.RFR)]
	public partial class ParPhase : CSerializable {
		[Serialize("phaseTime"       )] public float phaseTime;
		[Serialize("colorMin"        )] public Color colorMin;
		[Serialize("colorMax"        )] public Color colorMax;
		[Serialize("sizeMin"         )] public Vec2d sizeMin;
		[Serialize("sizeMax"         )] public Vec2d sizeMax;
		[Serialize("animstart"       )] public int animstart;
		[Serialize("animend"         )] public int animend;
		[Serialize("animname"        )] public StringID animname;
		[Serialize("deltaphasetime"  )] public float deltaphasetime;
		[Serialize("animstretchtime" )] public bool animstretchtime;
		[Serialize("blendtonextphase")] public bool blendtonextphase;

		[Serialize("float__0"        )] public float float__0;
		[Serialize("Color__1"        )] public Color Color__1;
		[Serialize("Color__2"        )] public Color Color__2;
		[Serialize("Vector2__3"      )] public Vec2d Vector2__3;
		[Serialize("Vector2__4"      )] public Vec2d Vector2__4;
		[Serialize("int__5"          )] public int int__5;
		[Serialize("int__6"          )] public int int__6;
		[Serialize("float__7"        )] public float float__7;
		[Serialize("int__8"          )] public int int__8;
		[Serialize("int__9"          )] public int int__9;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				SerializeField(s, nameof(phaseTime));
				SerializeField(s, nameof(colorMin));
				SerializeField(s, nameof(colorMax));
				SerializeField(s, nameof(sizeMin));
				SerializeField(s, nameof(sizeMax));
				SerializeField(s, nameof(animstart));
				SerializeField(s, nameof(animend));
				SerializeField(s, nameof(deltaphasetime));
				SerializeField(s, nameof(animstretchtime));
				SerializeField(s, nameof(blendtonextphase));
			} else {
				SerializeField(s, nameof(phaseTime));
				SerializeField(s, nameof(colorMin));
				SerializeField(s, nameof(colorMax));
				SerializeField(s, nameof(sizeMin));
				SerializeField(s, nameof(sizeMax));
				SerializeField(s, nameof(animstart));
				SerializeField(s, nameof(animend));
				SerializeField(s, nameof(animname));
				SerializeField(s, nameof(deltaphasetime));
				SerializeField(s, nameof(animstretchtime));
				SerializeField(s, nameof(blendtonextphase));
			}
		}
	}
}

