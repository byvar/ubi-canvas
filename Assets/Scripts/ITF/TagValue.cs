using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class TagValue : BaseObject {
		[Serialize(0, "Tag")] public StringID tag;
		[Serialize(1, "Value")] public string value;

		public TagValue(Reader reader) : base(reader) {
		}
	}
}
