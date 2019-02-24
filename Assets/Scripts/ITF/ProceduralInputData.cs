using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class ProceduralInputData : BaseObject {
		[Serialize(0, "input")] public StringID input;
		[Serialize(1, "min")] public float min;
		[Serialize(2, "max")] public float max;
		[Serialize(3, "initialValue", game = Settings.Game.RA)] public float initialValue;
		[Serialize(4, "minValue")] public float minValue;
		[Serialize(5, "maxValue")] public float maxValue;
		[Serialize(6, "mod")] public bool mod;
		[Serialize(7, "abs")] public bool abs;
		[Serialize(8, "add")] public bool add;
		[Serialize(9, "sin")] public bool sin;
		[Serialize(10, "curve")] public Spline curve;

		public ProceduralInputData(Reader reader) : base(reader) {
		}
	}
}
