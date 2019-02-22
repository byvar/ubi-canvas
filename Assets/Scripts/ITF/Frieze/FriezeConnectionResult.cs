using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class FriezeConnectionResult : Pickable {

		public FriezeConnectionResult(Reader reader) : base(reader) {
			Debug.LogError("Decipher FriezeConnectionResult @ " + reader.BaseStream.Position);
		}
	}
}
