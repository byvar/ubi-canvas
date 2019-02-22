using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Bind : BaseObject {

		public Bind(Reader reader) : base(reader) {
			bool read = reader.ReadBoolean();
			if (read) {
				Debug.LogError("Decipher Bind w/ read=true @ " + reader.BaseStream.Position);
			}
		}
	}
}
