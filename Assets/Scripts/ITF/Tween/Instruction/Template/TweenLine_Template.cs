using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.TweenInstructions.Template {
	public class TweenLine_Template : TweenTranslation_Template {
		[Serialize(0, "movement")] public Vector3 movement;
		[Serialize(1, "CosinusOnX", game = Settings.Game.RA)] public bool cosinusOnX;

		public TweenLine_Template(Reader reader) : base(reader) {
		}
	}
}
