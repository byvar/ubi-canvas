using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ITF.ActorComponents {
	public class RO2_FriendlyBTAIComponent : BTAIComponent {
		[Serialize(0, "path")] public Path path;
		[Serialize(1, "prisonerVisualType")] public Prisoner prisonerVisualType;
		[Serialize(2, "prisonerType")] public Type prisonerType;
		[Serialize(3, "prisonerIndexType")] public Index prisonerIndexType;
		[Serialize(4, "canReceiveHits", game = Settings.Game.RA)] public bool canReceiveHits;
		/*[Serialize(5, "targetWaypoint")] public ObjectPath targetWaypoint;
		[Serialize(6, "respawnPoint")] public ObjectPath respawnPoint;
		[Serialize(7, "rescued")] public bool rescued;*/

		public RO2_FriendlyBTAIComponent(Reader reader) : base(reader) {
		}

		public enum Prisoner {
			Soldier = 0,
			Baby,
			Fool,
			Princess,
			Prince,
			Queen,
			King
		}

		public enum Type {
			None = 0,
			Rope,
			Pole,
			Cage1,
			Cage2,
			TortureHit,
			TortureJump,
			Bullet
		}

		public enum Index {
			Map1 = 0,
			Map2,
			Map3,
			Map4,
			Map5,
			Map6,
			Map7,
			Map8
		}
	}
}
