using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	// Class name actually unknown - only used in Legends
	public class RedirectSymmetryPatch : BaseObject {
		[Serialize(0, "mainPatch")] public StringID mainPatch;
		[Serialize(1, "boneName")] public StringID boneName;
		[Serialize(2, "symmetryPatch")] public StringID symmetryPatch;

		public RedirectSymmetryPatch(Reader reader) : base(reader) {
		}
	}
}
