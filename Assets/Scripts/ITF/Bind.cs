using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Bind : BaseObject {
		[Serialize(0, "parentPath")] public ObjectPath parentPath;
		[Serialize(1, "offsetPos")] public Vector3 offsetPos;
		[Serialize(2, "offsetAngle")] public float offsetAngle;
		[Serialize(3, "type")] public Type type;
		[Serialize(4, "typeData")] public uint typeData;
		[Serialize(5, "useParentFlip")] public bool useParentFlip;
		[Serialize(6, "useParentScale")] public bool useParentScale;
		[Serialize(7, "useParentAlpha")] public bool useParentAlpha;
		[Serialize(8, "usRelativeZ", game = Settings.Game.RL)] public bool useRelativeZ;
		[Serialize(9, "removeWithParent")] public bool removeWithParent;

		public Bind(Reader reader) : base(reader) {
		}

		public enum Type {
			Root = 0,
			BoneName,
			ProceduralBoneName
		}
	}
}
