using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class RO2_LeafScrewComponent : RO2_AIComponent {
		[Serialize(0, "actorSpawnedPath")] public Path actorSpawnedPath;
		[Serialize(1, "actorSpawnType")] public SpawnActorType actorSpawnType;

		public RO2_LeafScrewComponent(Reader reader) : base(reader) {
		}

		public enum SpawnActorType {
			Other = 0,
			Turnip,
			LumsCage
		}
	}
}
