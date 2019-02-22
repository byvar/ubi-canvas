using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class RO2_BezierTreeComponent : ActorComponent {
		[Serialize(0, "branch")] public RO2_BezierBranch branch;

		public RO2_BezierTreeComponent(Reader reader) : base(reader) {
		}
	}
}
