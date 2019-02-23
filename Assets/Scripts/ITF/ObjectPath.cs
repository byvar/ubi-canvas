using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class ObjectPath : BaseObject {
		[Serialize(0, "levels")] public Container<Level> levels;
		[Serialize(1, "id")] public string id;
		[Serialize(2, "absolute")] public bool absolute;

		public ObjectPath(Reader reader) : base(reader) {
		}

		public class Level : BaseObject {
			[Serialize(0, "name")] public string name;
			[Serialize(1, "parent")] public bool parent;

			public Level(Reader reader) : base(reader) {
			}
		}
	}
}
