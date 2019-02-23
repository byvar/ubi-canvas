using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AnimPathAABB : BaseObject {
		[Serialize(0, "name")] public StringID name;
		[Serialize(1, "path")] public Path path;
		[Serialize(2, "aabb")] public AABB aabb;

		public AnimPathAABB(Reader reader) : base(reader) {
		}
	}
}
