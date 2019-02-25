using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class CheckpointComponent : ActorComponent {
		[Serialize(0, "INDEX")] public uint INDEX;
		[Serialize(1, "joinAlive")] public bool joinAlive;
		[Serialize(2, "persistent", game = Settings.Game.RA)] public bool persistent;
		[Serialize(3, "persistentSaveOnce", game = Settings.Game.RA)] public bool persistentSaveOnce;

		public CheckpointComponent(Reader reader) : base(reader) {
		}
	}
}
