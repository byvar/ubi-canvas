using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class PhantomComponent : ShapeComponent {
		[Serialize(0, "depthOffsets", game = Settings.Game.RA)] public Container<float> depthOffsets;
		public PhantomComponent(Reader reader) : base(reader) {
		}
	}
}
