using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class AFX_ColorSettingParam : BaseObject {
		[Serialize(0, "use")] public bool use;
		[Serialize(1, "saturation")] public float saturation;
		[Serialize(2, "contrast")] public float contrast;
		[Serialize(3, "contrastScale")] public float contrastScale;
		[Serialize(4, "bright")] public float bright;
		[Serialize(5, "colorCorrection")] public Color colorCorrection;


		public AFX_ColorSettingParam(Reader reader) : base(reader) {
		}
	}
}
