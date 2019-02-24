using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Event : BaseObject {
		[Serialize(0, "sender")] public ObjectRef sender;

		public Event(Reader reader) : base(reader) {
		}
	}
}
