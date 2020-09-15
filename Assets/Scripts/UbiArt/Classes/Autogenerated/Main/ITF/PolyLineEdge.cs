using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class PolyLineEdge : CSerializable {
		public Vec2d POS;
		public float Scale;
		public bool SwitchTexture;
		public StringID GMatOverride;
		public Hole HoleMode;
		public Vec2d Vector;
		public Vec2d NormalizedVector;
		public float Length;
		public StringID GameMaterial;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Default)) {
					POS = s.SerializeObject<Vec2d>(POS, name: "POS");
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					HoleMode = s.Serialize<Hole>(HoleMode, name: "HoleMode");
					Scale = s.Serialize<float>(Scale, name: "Scale");
					SwitchTexture = s.Serialize<bool>(SwitchTexture, name: "SwitchTexture");
				}
			} else if (Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.RL) {
				POS = s.SerializeObject<Vec2d>(POS, name: "POS");
				Scale = s.Serialize<float>(Scale, name: "Scale");
				SwitchTexture = s.Serialize<bool>(SwitchTexture, name: "SwitchTexture");
				HoleMode = s.Serialize<Hole>(HoleMode, name: "HoleMode");
				if (s.HasFlags(SerializeFlags.Flags10)) {
					Vector = s.SerializeObject<Vec2d>(Vector, name: "Vector");
					NormalizedVector = s.SerializeObject<Vec2d>(NormalizedVector, name: "NormalizedVector");
					Length = s.Serialize<float>(Length, name: "Length");
					GameMaterial = s.SerializeObject<StringID>(GameMaterial, name: "GameMaterial");
				}
			} else {
				POS = s.SerializeObject<Vec2d>(POS, name: "POS");
				Scale = s.Serialize<float>(Scale, name: "Scale");
				SwitchTexture = s.Serialize<bool>(SwitchTexture, name: "SwitchTexture");
				GMatOverride = s.SerializeObject<StringID>(GMatOverride, name: "GMatOverride");
				HoleMode = s.Serialize<Hole>(HoleMode, name: "HoleMode");
				if (s.HasFlags(SerializeFlags.Flags10)) {
					Vector = s.SerializeObject<Vec2d>(Vector, name: "Vector");
					NormalizedVector = s.SerializeObject<Vec2d>(NormalizedVector, name: "NormalizedVector");
					Length = s.Serialize<float>(Length, name: "Length");
					GameMaterial = s.SerializeObject<StringID>(GameMaterial, name: "GameMaterial");
				}
			}
		}
		public enum Hole {
			[Serialize("Hole_None"     )] None = 0,
			[Serialize("Hole_Collision")] Collision = 1,
			[Serialize("Hole_Visual"   )] Visual = 2,
			[Serialize("Hole_Both"     )] Both = 3,
		}
	}
}

