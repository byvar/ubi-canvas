using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class UnknownComponent1 : ActorComponent {
		public StringID type;
		public int value;

		public UnknownComponent1(Reader reader) : base(reader) {
			type = new StringID(reader);
			value = reader.ReadInt32();
		}
	}
}
