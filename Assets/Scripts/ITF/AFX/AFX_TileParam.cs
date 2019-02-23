using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_TileParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		[Serialize(1, "repetition")] public float repetition;


		public AFX_TileParam(Reader reader) : base(reader) {
		}
	}
}
