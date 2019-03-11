using UnityEngine;

namespace UbiArt.ITF {
	public partial class PolyLineEdge : CSerializable {
		[Serialize("POS"             )] public Vector2 POS;
		[Serialize("Scale"           )] public float Scale;
		[Serialize("SwitchTexture"   )] public bool SwitchTexture;
		[Serialize("GMatOverride"    )] public StringID GMatOverride;
		[Serialize("HoleMode"        )] public Hole HoleMode;
		[Serialize("Vector"          )] public Vector2 Vector;
		[Serialize("NormalizedVector")] public Vector2 NormalizedVector;
		[Serialize("Length"          )] public float Length;
		[Serialize("GameMaterial"    )] public StringID GameMaterial;
		protected override void SerializeImpl(CSerializerObject s) {
			base.SerializeImpl(s);
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
		public enum Hole {
			[Serialize("Hole_None"     )] None = 0,
			[Serialize("Hole_Collision")] Collision = 1,
			[Serialize("Hole_Visual"   )] Visual = 2,
			[Serialize("Hole_Both"     )] Both = 3,
		}
	}
}

