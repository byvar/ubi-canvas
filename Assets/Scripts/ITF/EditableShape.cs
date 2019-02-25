using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class EditableShape : BaseObject {
		[Serialize(0, "shape")] public Generic<PhysShape> shape;
		[Serialize(1, "bindedBoneName", game = Settings.Game.RL)] public StringID bindedBoneName;
		[Serialize(2, "localOffset", game = Settings.Game.RL)] public Vector2 localOffset;
		[Serialize(3, "applyRotation", game = Settings.Game.RL)] public bool applyRotation;

		public EditableShape(Reader reader) : base(reader) {
		}
	}
}
