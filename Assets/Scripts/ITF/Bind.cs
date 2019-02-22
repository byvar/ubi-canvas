using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class Bind : BaseObject {

		public Bind(Reader reader) : base(reader) {
			Debug.LogError("Decipher Bind @ " + reader.BaseStream.Position);
		}
	}
}
