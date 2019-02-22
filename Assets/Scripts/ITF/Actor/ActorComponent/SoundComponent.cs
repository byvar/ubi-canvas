using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class SoundComponent : ActorComponent {
		[Serialize(0, "soundList")] public Container<SoundDescriptor_Template> soundList;

		public SoundComponent(Reader reader) : base(reader) {
		}
	}
}
