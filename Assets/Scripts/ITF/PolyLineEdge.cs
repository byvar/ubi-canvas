using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class PolyLineEdge : BaseObject {
		public Vector2 pos;
		public float scale;
		public bool switchTexture;
		public Hole holeMode;
		public Vector2 vector;
		public Vector2 normalizedVector;
		public float length;
		public StringID gameMaterial;

		public PolyLineEdge(Reader reader) : base(reader) {
			pos = reader.ReadVector2();
			scale = reader.ReadSingle();
			switchTexture = reader.ReadBoolean();
			holeMode = (Hole)reader.ReadUInt32();
			vector = reader.ReadVector2();
			normalizedVector = reader.ReadVector2();
			length = reader.ReadSingle();
			gameMaterial = new StringID(reader);
		}

		public enum Hole {
			None,
			Collision,
			Visual,
			Both
		}
	}
}
