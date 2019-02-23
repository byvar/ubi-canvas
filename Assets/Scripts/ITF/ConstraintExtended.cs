using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class ConstraintExtended : BaseObject {
		[Serialize(0, "offset")] public float offset;
		[Serialize(1, "timeToIncrease")] public float timeToIncrease;
		[Serialize(2, "timeToWaitBeforeDecrease")] public float timeToWaitBeforeDecrease;
		[Serialize(3, "timeToDecrease")] public float timeToDecrease;

		public ConstraintExtended(Reader reader) : base(reader) {
		}
	}
}
