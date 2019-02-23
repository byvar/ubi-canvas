using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class ChildEntry : BaseObject {
		[Serialize(0, "Path")] public ObjectPath path;
		[Serialize(1, "TagValues")] public Container<TagValue> tagValues;

		public ChildEntry(Reader reader) : base(reader) {
		}
	}
}
