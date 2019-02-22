using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class MetaFrieze : Pickable {

		public MetaFrieze(Reader reader) : base(reader) {
			Debug.LogError("Decipher MetaFrieze @ " + Pointer.Current(reader));
		}
	}
}
