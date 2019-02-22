using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class PolyLineEdge : BaseObject {
		[Serialize(0, "POS")] public Vector2 pos;
		[Serialize(1, "Scale")] public float scale;
		[Serialize(2, "SwitchTexture")] public bool switchTexture;
		[Serialize(3, "HoleMode")] public Hole holeMode;
		[Serialize(4, "Vector")] public Vector2 vector;
		[Serialize(5, "NormalizedVector")] public Vector2 normalizedVector;
		[Serialize(6, "Length")] public float length;
		[Serialize(7, "GameMaterial")] public StringID gameMaterial;

		public PolyLineEdge(Reader reader) : base(reader) {
		}

		public enum Hole {
			None,
			Collision,
			Visual,
			Both
		}
	}
}
