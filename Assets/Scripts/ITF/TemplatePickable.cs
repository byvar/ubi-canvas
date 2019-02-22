using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class TemplatePickable : BaseObject {
		[Serialize(0, "TAGS")] public Container<string> tags;
		[Serialize(1, "WIP")] public bool wip;
		[Serialize(2, "LOWUPDATE")] public bool lowUpdate;
		[Serialize(3, "UPDATELAYER")] public WorldUpdateLayer updateLayer;

		public TemplatePickable(Reader reader) : base(reader) {
		}

		public enum WorldUpdateLayer {
			Gameplay,
			CutScene,
			Menu,
			TRC
		}
	}
}
