using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_RefractionParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		
		public AFX_RefractionParam(Reader reader) : base(reader) {
		}
	}
}
