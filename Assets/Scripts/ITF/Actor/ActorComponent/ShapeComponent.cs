using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class ShapeComponent : ActorComponent {
		[Serialize(0, "localOffset")] public Vector2 localOffset;
		[Serialize(1, "localScale")] public Vector2 localScale;
		[Serialize(2, "useShapeTransform")] public bool useShapeTransform;
		[Serialize(3, "AnimPolylineList", game = Settings.Game.RA)] public Container<StringID> animPolylineList;

		public ShapeComponent(Reader reader) : base(reader) {
		}
	}
}
