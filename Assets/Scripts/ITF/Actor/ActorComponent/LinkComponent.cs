using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class LinkComponent : ActorComponent {
		public Container<SoundDescriptor_Template> children;

		public LinkComponent(Reader reader) : base(reader) {
			children = new Container<SoundDescriptor_Template>(reader);
		}
	}
}
