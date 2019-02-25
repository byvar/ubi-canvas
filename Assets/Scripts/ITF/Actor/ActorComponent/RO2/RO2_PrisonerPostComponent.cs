using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class RO2_PrisonerPostComponent : RO2_AIComponent {
		// public bool isBroken; <- not serialized for files because they're never already broken

		public RO2_PrisonerPostComponent(Reader reader) : base(reader) {
		}
	}
}
