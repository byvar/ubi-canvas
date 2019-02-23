using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_NegatifParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		
		public AFX_NegatifParam(Reader reader) : base(reader) {
		}
	}
}
