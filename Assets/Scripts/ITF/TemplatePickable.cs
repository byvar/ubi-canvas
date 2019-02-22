using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF {
	public class TemplatePickable : BaseObject {
		public Container<string> tags;
		public bool wip;
		public bool lowUpdate;
		public WorldUpdateLayer updateLayer;
		
		public TemplatePickable(Reader reader) : base(reader) {
			tags = new Container<string>(reader);
			wip = reader.ReadBoolean();
			lowUpdate = reader.ReadBoolean();
			updateLayer = (WorldUpdateLayer)reader.ReadUInt32();
		}

		public enum WorldUpdateLayer {
			Gameplay,
			CutScene,
			Menu,
			TRC
		}
	}
}
