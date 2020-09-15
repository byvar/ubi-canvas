using UnityEngine;

namespace UbiArt.ITF {
	[Games(GameFlags.RA | GameFlags.RL | GameFlags.RJR | GameFlags.RFR | GameFlags.VH)]
	public partial class PolyLineEdge : CSerializable {
		[Serialize("POS"             )] public Vec2d POS;
		[Serialize("Scale"           )] public float Scale;
		[Serialize("SwitchTexture"   )] public bool SwitchTexture;
		[Serialize("GMatOverride"    )] public StringID GMatOverride;
		[Serialize("HoleMode"        )] public Hole HoleMode;
		[Serialize("Vector"          )] public Vec2d Vector;
		[Serialize("NormalizedVector")] public Vec2d NormalizedVector;
		[Serialize("Length"          )] public float Length;
		[Serialize("GameMaterial"    )] public StringID GameMaterial;

		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
			if (Settings.s.game == Settings.Game.RJR || Settings.s.game == Settings.Game.RFR || Settings.s.game == Settings.Game.RO) {
				if (s.HasFlags(SerializeFlags.Flags_x30 | SerializeFlags.Default)) {
					SerializeField(s, nameof(POS));
				}
				if (s.HasFlags(SerializeFlags.Default)) {
					SerializeField(s, nameof(HoleMode));
					SerializeField(s, nameof(Scale));
					SerializeField(s, nameof(SwitchTexture));
				}
			} else if (Settings.s.game == Settings.Game.VH || Settings.s.game == Settings.Game.RL) {
				SerializeField(s, nameof(POS));
				SerializeField(s, nameof(Scale));
				SerializeField(s, nameof(SwitchTexture));
				SerializeField(s, nameof(HoleMode));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(Vector));
					SerializeField(s, nameof(NormalizedVector));
					SerializeField(s, nameof(Length));
					SerializeField(s, nameof(GameMaterial));
				}
			} else {
				SerializeField(s, nameof(POS));
				SerializeField(s, nameof(Scale));
				SerializeField(s, nameof(SwitchTexture));
				SerializeField(s, nameof(GMatOverride));
				SerializeField(s, nameof(HoleMode));
				if (s.HasFlags(SerializeFlags.Flags10)) {
					SerializeField(s, nameof(Vector));
					SerializeField(s, nameof(NormalizedVector));
					SerializeField(s, nameof(Length));
					SerializeField(s, nameof(GameMaterial));
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

